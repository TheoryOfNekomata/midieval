using MidiEval.Analyzer.Elements;
using Sanford.Multimedia;
using Sanford.Multimedia.Midi;

namespace MidiEval.Analyzer.Parsing {

	/// <summary>
	/// A class for extracting data from meta messages such as tempo, time signature, and key signature.
	/// </summary>
	public class MetaExtractor {
		private static readonly MetaExtractor _instance = new MetaExtractor();

		private void Initialize() {
			this.Tempo = 120;
			this.TimeSignature = new TimeSignature(4, 4);
			this.KeySignature = Key.CMajor;
		}

		/// <summary>
		/// Gets or sets the key signature.
		/// </summary>
		/// <value>
		/// The key signature.
		/// </value>
		public Key KeySignature { get; set; }

		/// <summary>
		/// Gets or sets the time signature.
		/// </summary>
		/// <value>
		/// The time signature.
		/// </value>
		public TimeSignature TimeSignature { get; set; }

		/// <summary>
		/// Gets or sets the tempo.
		/// </summary>
		/// <value>
		/// The tempo.
		/// </value>
		public double Tempo { get; set; }

		/// <summary>
		/// Gets the instance.
		/// </summary>
		/// <value>
		/// The instance.
		/// </value>
		public static MetaExtractor Instance {
			get { return _instance; }
		}

		/// <summary>
		/// Parses the specified sequence.
		/// </summary>
		/// <param name="sequence">The sequence.</param>
		/// <returns>The instance of the <see cref="MetaExtractor"/>, to be used on retrieving the parsed meta data.</returns>
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