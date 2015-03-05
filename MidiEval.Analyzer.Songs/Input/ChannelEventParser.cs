using MidiEval.Analyzer.Elements;
using MidiEval.Analyzer.Elements.Notes;
using Sanford.Multimedia.Midi;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace MidiEval.Analyzer.Songs.Input {

	public class ChannelEventParser : EventParser {
		private readonly Channel[] _channels = new Channel[ChannelMessage.MidiChannelMaxValue + 1];
		private readonly Dictionary<int, Stack<int>>[] _notes = new Dictionary<int, Stack<int>>[ChannelMessage.MidiChannelMaxValue + 1];
		private readonly int?[] _sustainPedalDown = new int?[ChannelMessage.MidiChannelMaxValue + 1];
		private readonly int?[] _sostenutoPedalDown = new int?[ChannelMessage.MidiChannelMaxValue + 1];
		private readonly Dictionary<int, Stack<int>>[] _sustainedNotes = new Dictionary<int, Stack<int>>[ChannelMessage.MidiChannelMaxValue + 1];
		private readonly Dictionary<int, Stack<int>>[] _sostenutoNotes = new Dictionary<int, Stack<int>>[ChannelMessage.MidiChannelMaxValue + 1];

		public Channel[] Channels {
			get { return this._channels; }
		}

		public ChannelEventParser(IEnumerable<MidiEvent> midiEvents) {
			for(var i = 0; i < ChannelMessage.MidiChannelMaxValue + 1; i++) {
				this._channels[i] = new Channel();
				this._notes[i] = new Dictionary<int, Stack<int>>();
				this._sustainedNotes[i] = new Dictionary<int, Stack<int>>();
				this._sostenutoNotes[i] = new Dictionary<int, Stack<int>>();
			}

			var collection = midiEvents as IList<MidiEvent> ?? midiEvents.ToList();
			var eventsList = new List<MidiEvent>(collection);
			eventsList.Sort(this.CompareEvents);

			foreach(var midiEvent in eventsList) {
				if(midiEvent.MidiMessage.MessageType != MessageType.Channel)
					continue;
				var message = (ChannelMessage) midiEvent.MidiMessage;
				switch(message.Command) {
					case ChannelCommand.NoteOn:
						this.ProcessNoteOn(midiEvent.AbsoluteTicks, message);
						break;

					case ChannelCommand.NoteOff:
						this.ProcessNoteOff(midiEvent.AbsoluteTicks, message);
						break;

					case ChannelCommand.Controller:
						this.ProcessController(midiEvent.AbsoluteTicks, message);
						break;
				}
			}
		}

		private void ProcessNoteOn(int absoluteTicks, ChannelMessage message) {
			var pitch = message.Data1;
			//var velocity = message.Data2;
			var channel = message.MidiChannel;

			if(this._sustainPedalDown[channel] != null) {
				Stack<int> susTimeStack;
				if(!this._sustainedNotes[channel].TryGetValue(pitch, out susTimeStack)) {
					susTimeStack = new Stack<int>();
					this._sustainedNotes[channel].Add(pitch, susTimeStack);
				}
				susTimeStack.Push(absoluteTicks);
			}
			Stack<int> timeStack;
			if(!this._notes[channel].TryGetValue(pitch, out timeStack)) {
				timeStack = new Stack<int>();
				this._notes[channel].Add(pitch, timeStack);
			}
			timeStack.Push(absoluteTicks);
		}

		private void ProcessNoteOff(int absoluteTicks, ChannelMessage message) {
			var pitch = message.Data1;
			//var velocity = message.Data2;
			var channel = message.MidiChannel;
			Stack<int> timeStack;

			if(this._sustainPedalDown[channel] != null)
				return;

			if(!this._notes[channel].TryGetValue(pitch, out timeStack)) {
				timeStack = new Stack<int>();
				this._notes[channel].Add(pitch, timeStack);
			}
			var note = new Note(new Pitch(pitch), timeStack.Pop(), absoluteTicks);
			this._channels[channel].Notes.Add(note);
		}

		private void ProcessController(int absoluteTicks, ChannelMessage message) {
			switch((ControllerType) message.Data1) {
				/*
				case ControllerType.HoldPedal1:
					this.ProcessSustain(absoluteTicks, message);
					break;

				case ControllerType.SustenutoPedal:
					this.ProcessSostenuto(absoluteTicks, message);
					break;
				 */

				default:
					if(message.Data1 >= 0x120)
						this.ProcessAllNotesOff(absoluteTicks, message);
					break;
			}
		}

		private void ProcessSustain(int absoluteTicks, ChannelMessage message) {
			if(message.Data2 > 0) {
				this._sustainPedalDown[message.MidiChannel] = absoluteTicks;
				foreach(var pitch in this._notes[message.MidiChannel].Keys) {
					var timeStack = this._notes[message.MidiChannel][pitch];
					var susTimeStack = this._sustainedNotes[message.MidiChannel][pitch];
					this.CopyStack(timeStack, susTimeStack);
				}
			} else {
				this._sustainPedalDown[message.MidiChannel] = null;
			}
		}

		private void CopyStack(Stack<int> src, Stack<int> dest) {
			foreach(var item in src.ToArray().Reverse()) {
				dest.Push(item);
			}
		}

		private void ProcessSostenuto(int absoluteTicks, ChannelMessage message) {
			if(message.Data2 > 0)
				this._sostenutoPedalDown[message.MidiChannel] = absoluteTicks;
			else
				this._sostenutoPedalDown[message.MidiChannel] = null;
		}

		private void ProcessAllNotesOff(int absoluteTicks, ChannelMessage message) {
			foreach(var pitch in this._notes[message.MidiChannel].Keys)
				while(this._notes[message.MidiChannel][pitch].Count > 0)
					this.ProcessNoteOff(absoluteTicks, new ChannelMessage(ChannelCommand.NoteOff, message.MidiChannel, pitch));
		}
	}
}