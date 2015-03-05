using MidiEval.Analyzer.Elements;
using Sanford.Multimedia;
using Sanford.Multimedia.Midi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;

namespace MidiEval.Analyzer.Songs.Input {

	public class MetaEventParser : EventParser {
		private int _keySignature = -1;
		private double _tempo = 120;
		private TimeSignature _timeSignature = new TimeSignature(0, 0);

		public double Tempo {
			get { return this._tempo; }
		}

		public Key KeySignature {
			get { return (Key) this._keySignature; }
		}

		public TimeSignature TimeSignature {
			get { return this._timeSignature; }
			set { this._timeSignature = value; }
		}

		private void ProcessTempo(MetaMessage message) {
			var b = message.GetBytes();
			var tempoBytes = new[] { b[2], b[1], b[0], (byte) 0x00 };
			this._tempo = 60000000.0 / BitConverter.ToInt32(tempoBytes, 0);
		}

		private void ProcessTimeSignature(MetaMessage message) {
			var builder = new TimeSignatureBuilder(message);
			this.TimeSignature = new TimeSignature(builder.Numerator, builder.Denominator);
		}

		private void ProcessKeySignature(MetaMessage message) {
			var builder = new KeySignatureBuilder(message);
			this._keySignature = (int) builder.Key;
		}

		public MetaEventParser(IEnumerable<MidiEvent> midiEvents) {
			var collection = midiEvents as IList<MidiEvent> ?? midiEvents.ToList();
			var eventsList = new List<MidiEvent>(collection);
			eventsList.Sort(this.CompareEvents);

			foreach(var message in
				from midiEvent in eventsList
				where midiEvent.MidiMessage.MessageType == MessageType.Meta
				select (MetaMessage) midiEvent.MidiMessage) {
				switch(message.MetaType) {
					case MetaType.Tempo:
						this.ProcessTempo(message);
						break;

					case MetaType.TimeSignature:
						this.ProcessTimeSignature(message);
						break;

					case MetaType.KeySignature:
						this.ProcessKeySignature(message);
						break;
				}
			}
		}
	}
}