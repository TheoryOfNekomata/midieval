using MidiEval.Analyzer.Elements.Notes;
using System;

namespace MidiEval.Analyzer.Elements {

	/// <summary>
	/// Class for a note.
	/// </summary>
	public class Note {

		protected bool Equals(Note other) {
			return this.Pitch.Equals(other.Pitch) && this.NoteOn == other.NoteOn && this.NoteOff == other.NoteOff;
		}

		public override int GetHashCode() {
			unchecked {
				var hashCode = this.Pitch.GetHashCode();
				hashCode = (hashCode * 397) ^ this.NoteOn;
				hashCode = (hashCode * 397) ^ this.NoteOff;
				return hashCode;
			}
		}

		/// <summary>
		/// The pitch of the note.
		/// </summary>
		public Pitch Pitch { get; set; }

		/// <summary>
		/// The time (by ticks) when the note is on.
		/// </summary>
		public int NoteOn { get; set; }

		/// <summary>
		/// The time (by ticks) when the note is off.
		/// </summary>
		public int NoteOff { get; set; }

		/// <summary>
		/// The duration (by ticks) of the note.
		/// </summary>
		public int Duration {
			get { return this.NoteOff - this.NoteOn; }
		}

		/// <summary>
		/// Initializes a new instance of a <see cref="Note"/> class.
		/// </summary>
		/// <param name="pitch">The pitch of the note.</param>
		/// <param name="noteOn">The time (by ticks) when the note is on.</param>
		/// <param name="noteOff">The time (by ticks) when the note is off.</param>
		public Note(Pitch pitch, int noteOn, int noteOff) {
			this.Pitch = pitch;
			this.NoteOn = noteOn;
			this.NoteOff = noteOff;
		}

		public override bool Equals(object obj) {
			if(ReferenceEquals(null, obj))
				return false;
			if(ReferenceEquals(this, obj))
				return true;
			if(obj.GetType() != this.GetType())
				return false;
			return Equals((Note) obj);
		}
	}
}