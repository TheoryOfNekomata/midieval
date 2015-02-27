using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Sanford.Multimedia.Midi;

using MidiEval.Core;

namespace MidiEval {
	static class Program {
		static BinaryReader _reader;

		public static void Analyze(string _fileName) {

			var _sequence = new Sequence(_fileName);

			foreach(var _track in _sequence) {
				for(var i = 0; i < _track.Count; i++) {
					var _midiEvent = _track.GetMidiEvent(i);

					var _messageType = _midiEvent.MidiMessage.MessageType;
					var _status = _midiEvent.MidiMessage.Status;
					var _bytes = _midiEvent.MidiMessage.GetBytes();
					
					if(_messageType == MessageType.Channel) {
						var _event = _status & 0xF0;
						var _channel = _status & 0x0F;
						var _key = _bytes[1] & 0x7F;
						var _velocity = _bytes[2] & 0x7F;

						var _eventName = "";

						switch(_event) {
							case 0x80:
								_eventName = "Note OFF";
								break;
							case 0x90:
								_eventName = "Note ON";
								break;
							default:
								_eventName = "Others";
								continue;
						}

						System.Windows.Forms.MessageBox.Show(
							"Ch. " + _channel + " " + _eventName + " @" + _midiEvent.AbsoluteTicks + ":" +
							" Key #" + _key +
							" (" + _velocity + ")"
						);
					}
				}
			}
			
			//MidiSegmenter.Instance.GetPhrases(_stream);
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
