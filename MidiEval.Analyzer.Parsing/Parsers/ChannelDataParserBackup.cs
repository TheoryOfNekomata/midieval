using MidiEval.Analyzer.Elements;
using MidiEval.Analyzer.Elements.Notes;
using Sanford.Collections.Generic;
using Sanford.Multimedia.Midi;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace MidiEval.Analyzer.Data.Parsers {

	public class ChannelDataParserBackup : IMidiDataParser {
		private const int MidiChannels = 16;

		private readonly Dictionary<int, Dictionary<int, int>>[] _notes = new Dictionary<int, Dictionary<int, int>>[MidiChannels];
		private readonly Dictionary<int, int>[] _sustainedNotes = new Dictionary<int, int>[MidiChannels];
		private readonly Deque<KeyValuePair<int, int>>[] _noteTimes = new Deque<KeyValuePair<int, int>>[MidiChannels];

		private readonly Dictionary<int, int>[] _sustainTimes = new Dictionary<int, int>[MidiChannels];
		private readonly Dictionary<int, int>[] _sostenutoTimes = new Dictionary<int, int>[MidiChannels];

		public Dictionary<int, Dictionary<int, int>>[] Notes {
			get { return this._notes; }
		}

		public int?[] LastSustainPedalTime { get; set; }

		public int?[] LastSostenutoPedalTime { get; set; }

		public ChannelDataParserBackup() {
			for(var i = 0; i < MidiChannels; i++) {
				this._notes[i] = new Dictionary<int, Dictionary<int, int>>();
				this._sustainedNotes[i] = new Dictionary<int, int>();
				this._noteTimes[i] = new Deque<KeyValuePair<int, int>>();
			}
			this.LastSustainPedalTime = new int?[MidiChannels];
			this.LastSostenutoPedalTime = new int?[MidiChannels];
		}

		private void ProcessNoteOn(int absoluteTicks, int channel, int pitch) {
			Dictionary<int, int> time;

			if(!this._notes[channel].TryGetValue(pitch, out time))
				this._notes[channel].Add(pitch, new Dictionary<int, int>());
			this._noteTimes[channel].PushFront(new KeyValuePair<int, int>(pitch, absoluteTicks)); // state: NOTE ON

			if(this._noteTimes[channel].PeekBack().Key != this._noteTimes[channel].PeekFront().Key)
				return;

			this._notes[channel][pitch][absoluteTicks] = this._noteTimes[channel].PopBack().Value;
			this._noteTimes[channel].PopFront();
		}

		private void ProcessNoteOff(int absoluteTicks, int channel, int pitch) {
			Dictionary<int, int> time;

			if(!this._notes[channel].TryGetValue(pitch, out time))
				this._notes[channel].Add(pitch, new Dictionary<int, int>());
			this._noteTimes[channel].PushFront(new KeyValuePair<int, int>(pitch, absoluteTicks)); // state: NOTE ON

			if(this.LastSustainPedalTime[channel] != null && this.LastSustainPedalTime[channel] <= absoluteTicks)
				return;
			if(this.LastSostenutoPedalTime[channel] != null && this.LastSostenutoPedalTime[channel] <= this._noteTimes[channel][pitch].Peek())
				return;

			this._noteTimes[channel].PushBack(new KeyValuePair<int, int>(pitch, absoluteTicks)); // state: NOTE ON

			if(this._noteTimes[channel].PeekBack().Key != this._noteTimes[channel].PeekFront().Key)
				return;

			this._notes[channel][pitch][this._noteTimes[channel].PopFront().Value] = absoluteTicks;
			this._noteTimes[channel].PopBack();
		}

		private void ProcessSustainPedal(int absoluteTicks, int channel, int value) {
			this.LastSustainPedalTime[channel] = value > 0 ? absoluteTicks : (int?) null;
		}

		private void ProcessSostenutoPedal(int absoluteTicks, int channel, int value) {
			// TODO check for sustained notes
			//this.LastSostenutoPedalTime[channel] = value > 0 ? absoluteTicks : (int?) null;
		}

		private void ProcessController(int absoluteTicks, int channel, ControllerType type, int value) {
			switch(type) {
				case ControllerType.HoldPedal1:
					this.ProcessSustainPedal(absoluteTicks, channel, value);
					break;

				case ControllerType.SustenutoPedal:
					this.ProcessSostenutoPedal(absoluteTicks, channel, value);
					break;

				default:
					if((int) type >= 0x123) // 0x120 = All Sound Off
						foreach(var pitch in this._noteTimes[channel].Keys)

							while(this._noteTimes[pitch].Count > 0)

								this.ProcessNoteOff(absoluteTicks, channel, pitch);
					break;
			}
		}

		public void ProcessChannelMessage(int absoluteTicks, ChannelMessage message) {
			var channel = message.MidiChannel;
			switch(message.Command) {
				case ChannelCommand.NoteOn:
					this.ProcessNoteOn(absoluteTicks, channel, message.Data1);
					break;

				case ChannelCommand.NoteOff:
					this.ProcessNoteOff(absoluteTicks, channel, message.Data2);
					break;

				case ChannelCommand.Controller:
					this.ProcessController(absoluteTicks, channel, (ControllerType) message.Data1, message.Data2);
					break;
			}
		}

		public void EnterEvent(MidiEvent @event) {
			this.ProcessChannelMessage(@event.AbsoluteTicks, (ChannelMessage) @event.MidiMessage);
		}

		public Channel[] GetChannels() {
			var channels = new Channel[16];
			for(var i = 0; i < channels.Length; i++) {
				channels[i] = new Channel();
				foreach(var note in this._notes[i])
					foreach(var period in this._notes[i][note.Key])
						channels[i].Notes.Add(new Note(new Pitch(note.Key), period.Key, period.Value));
			}

			return channels;
		}
	}
}