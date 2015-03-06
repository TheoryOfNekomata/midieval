using System;

namespace MidiEval.Analyzer.Elements.Notes {

	/// <summary>
	/// Struct for an absolute note pitch (key and octave).
	/// </summary>
	public struct Pitch {

		public bool Equals(Pitch other) {
			return this.Key == other.Key && this.Octave == other.Octave;
		}

		/// <summary>
		/// The key of the pitch.
		/// </summary>
		public Sanford.Multimedia.Note Key { get; set; }

		/// <summary>
		/// The octave of the pitch.
		/// </summary>
		public int Octave { get; set; }

		/// <summary>
		/// Gets the current pitch's corresponding MIDI pitch.
		/// </summary>
		/// <value>
		/// The MIDI pitch, which is a value from 0-127, with multiples of 12 as C in different octaves.
		/// </value>
		public int MidiPitch {
			get { return this.Octave * 12 + (int) this.Key; }
		}

		/// <summary>
		/// Gets the interval between two pitches.
		/// </summary>
		/// <param name="pitch1">The first pitch.</param>
		/// <param name="pitch2">The second pitch.</param>
		/// <returns>The interval between the pitches.</returns>
		public static int GetInterval(Pitch pitch1, Pitch pitch2) {
			return Math.Abs(pitch1.MidiPitch - pitch2.MidiPitch);
		}

		/// <summary>
		/// Gets the interval relative to another pitch.
		/// </summary>
		/// <param name="pitch">A pitch.</param>
		/// <returns>The interval relative to another pitch.</returns>
		public int GetInterval(Pitch pitch) {
			return GetInterval(this, pitch);
		}

		/// <summary>
		/// Returns a <see cref="System.String" /> that represents this instance.
		/// </summary>
		/// <returns>
		/// A <see cref="System.String" /> that represents this instance.
		/// </returns>
		public override string ToString() {
			return string.Format("{0}{1}", this.Key, this.Octave);
		}

		/// <summary>
		/// Returns a hash code for this instance.
		/// </summary>
		/// <returns>
		/// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
		/// </returns>
		public override int GetHashCode() {
			unchecked {
				return ((int) this.Key * 397) ^ this.Octave;
			}
		}

		/// <summary>
		/// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
		/// </summary>
		/// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
		/// <returns>
		///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
		/// </returns>
		public override bool Equals(object obj) {
			if(ReferenceEquals(null, obj))
				return false;
			return obj is Pitch && Equals((Pitch) obj);
		}

		/// <summary>
		/// Initializes a new instance of a <see cref="Pitch"/> struct, given a key and an octave.
		/// </summary>
		/// <param name="key">The key of the pitch.</param>
		/// <param name="octave">The octave of the pitch.</param>
		public Pitch(Sanford.Multimedia.Note key, int octave)
			: this() {
			this.Key = key;
			this.Octave = octave;
		}

		/// <summary>
		/// Initializes a new instance of a <see cref="Pitch"/> struct, given a MIDI pitch.
		/// </summary>
		/// <param name="midiPitch">MIDI pitch: a value from 0-127 (where 0 = C-1, 12 = C0, 24 = C1 etc.).</param>
		public Pitch(int midiPitch)
			: this((Sanford.Multimedia.Note) (midiPitch % 12), midiPitch / 12) {
		}
	}
}