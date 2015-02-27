using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using MidiEval.Analyzer.Elements;
using Sanford.Multimedia.Midi;
using Sanford.Multimedia;

namespace MidiEval.Analyzer.Parsing {
	public class MetaExtractor {
		private static MetaExtractor _instance = new MetaExtractor();

		private void Initialize() {
			this.Tempo = 120;
			this.TimeSignature = new TimeSignature(4, 4);
			this.KeySignature = Key.CMajor;
		}

		public Key KeySignature { get; set; }

		public TimeSignature TimeSignature { get; set; }

		public double Tempo { get; set; }

		public static MetaExtractor Instance {
			get { return _instance; }
			set { _instance = value; }
		}

		public MetaExtractor Parse(Sequence sequence) {
			this.Initialize();
			foreach(var track in sequence)
				for(var i = 0; i < track.Count; i++) {
					var @event = track.GetMidiEvent(i);
					var message = @event.MidiMessage;

					if(message.MessageType != MessageType.Meta)
						continue;

					var metaMessage = (MetaMessage) message;
					
					switch(metaMessage.MetaType) {
						case MetaType.TimeSignature:
							var timeSigBuilder = new TimeSignatureBuilder(metaMessage);
							this.TimeSignature = new TimeSignature(timeSigBuilder.Numerator, timeSigBuilder.Denominator);
							break;
						case MetaType.KeySignature:
							var keySigBuilder = new KeySignatureBuilder(metaMessage);
							this.KeySignature = keySigBuilder.Key;
							break;
						case MetaType.Tempo:
							var bytes = metaMessage.GetBytes();
							var ms = 0;
							foreach(var b in bytes) {
								ms <<= 0x08;
								ms |= b;
							}
							this.Tempo = (60000000.00 / ms);
							break;
					}
				}

			return this;
		}
	}
}
