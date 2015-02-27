using System;

namespace MidiEval.Analyzer.Elements.Notes {
	/// <summary>
	/// Struct for an absolute note pitch (key and octave).
	/// </summary>
	public struct Pitch {
		/// <summary>
		/// The key of the pitch.
		/// </summary>
		public Sanford.Multimedia.Note Key { get; set; }

		/// <summary>
		/// The octave of the pitch.
		/// </summary>
		public int Octave { get; set; }

		public int MidiPitch {
			get { return this.Octave * 12 + (int) this.Key; }
		}

		public static int GetInterval(Pitch pitch1, Pitch pitch2) {
			return Math.Abs(pitch1.MidiPitch - pitch2.MidiPitch);
		}

		public int GetInterval(Pitch pitch) {
			return GetInterval(this, pitch);
		}

		public override string ToString() {
			return string.Format("{0}{1}", this.Key, this.Octave);
		}

		public override int GetHashCode() {
			return base.GetHashCode();
		}

		public override bool Equals(object obj) {
			Pitch pitch;

			try {
				pitch = (Pitch) obj;
			} catch(System.Exception) {
				return false;
			}

			return pitch.Key == this.Key && pitch.Octave == this.Octave;
		}

		/// <summary>
		/// Initializes a new instance of a pitch given a key and an octave.
		/// </summary>
		/// <param name="key">The key of the pitch.</param>
		/// <param name="octave">The octave of the pitch.</param>
		public Pitch(Sanford.Multimedia.Note key, int octave) : this() {
			this.Key = key;
			this.Octave = octave;
		}

		/// <summary>
		/// Initializes a new instance of a pitch given a MIDI pitch.
		/// </summary>
		/// <param name="midiPitch">MIDI pitch: a value from 0-127 (where 0 = C-1, 12 = C0, 24 = C1 etc.).</param>
		public Pitch(int midiPitch) : this((Sanford.Multimedia.Note) (midiPitch % 12), midiPitch / 12) {}
	}
}
