using MidiEval.Analyzer.Elements;
using MidiEval.Analyzer.Elements.Notes;
using Sanford.Multimedia.Midi;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MidiEval.Analyzer.Parsing {

	public class NoteExtractor {
		private static NoteExtractor _instance = new NoteExtractor();

		public static NoteExtractor Instance {
			get { return _instance; }
			set { _instance = value; }
		}

		public Channel[] Parse(Sequence sequence) {
			var channels = new Channel[16];
			var noteOns = new Dictionary<int, Dictionary<int, Queue<int>>>();

			for(var i = 0; i < channels.Length; i++)
				channels[i] = new Channel();

			foreach(var track in sequence)
				for(var i = 0; i < track.Count; i++) {
					var @event = track.GetMidiEvent(i);
					var message = @event.MidiMessage;

					if(message.MessageType != MessageType.Channel)
						continue;

					var channelMessage = (ChannelMessage) message;
					var time = @event.AbsoluteTicks;

					//MessageBox.Show("" + channelMessage.Command);

					switch(channelMessage.Command) {
						case ChannelCommand.NoteOff:
							var noteOffPitch = channelMessage.Data1;
							var lastNoteOnTime = noteOns[channelMessage.MidiChannel][noteOffPitch].Dequeue();
							channels[channelMessage.MidiChannel].Notes.Add(
								new Note(
									new Pitch(channelMessage.Data1),
									lastNoteOnTime,
									time
								)
							);
							break;

						case ChannelCommand.NoteOn:
							var noteOnPitch = channelMessage.Data1;
							try {
								noteOns[channelMessage.MidiChannel][noteOnPitch].Enqueue(time);
							} catch(KeyNotFoundException) {
								try {
									noteOns[channelMessage.MidiChannel][noteOnPitch] = new Queue<int>();
								} catch(KeyNotFoundException) {
									noteOns[channelMessage.MidiChannel] = new Dictionary<int, Queue<int>>();
									noteOns[channelMessage.MidiChannel][noteOnPitch] = new Queue<int>();
								}
								noteOns[channelMessage.MidiChannel][noteOnPitch].Enqueue(time);
							}
							break;

						case ChannelCommand.Controller:
							var ctrlType = (ControllerType) channelMessage.Data1;
							var ctrlValue = channelMessage.Data2;
							//MessageBox.Show("" + ctrlType);
							switch(ctrlType) {
								case ControllerType.AllNotesOff:
									foreach(var channel in noteOns) {
										var channelIndex = channel.Key;
										foreach(var pitch in channel.Value) {
											var channelPitch = pitch.Key;
											var pitchTimeQueue = pitch.Value;
											while(pitchTimeQueue.Count > 0)
												channels[channelIndex].Notes.Add(
													new Note(
														new Pitch(channelPitch),
														pitchTimeQueue.Dequeue(),
														time
													)
												);
										}
									}
									break;

								case ControllerType.AllSoundOff:
									goto case ControllerType.AllNotesOff;
								case ControllerType.OmniModeOn:
									goto case ControllerType.AllNotesOff;
								case ControllerType.OmniModeOff:
									goto case ControllerType.AllNotesOff;
								case ControllerType.PolyOperation:
									goto case ControllerType.AllNotesOff;
								case ControllerType.MonoOperation:
									goto case ControllerType.AllNotesOff;
								case ControllerType.HoldPedal1:
									if(ctrlValue == 0)
										goto case ControllerType.AllNotesOff;
									break;
							}
							break;
					}
				}

			return channels;
		}
	}
}