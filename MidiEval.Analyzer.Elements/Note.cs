using MidiEval.Analyzer.Elements.Notes;
using System;

namespace MidiEval.Analyzer.Elements {

	/// <summary>
	/// Class for a note.
	/// </summary>
	public class Note {

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
		/// Initializes a new instance of a note.
		/// </summary>
		/// <param name="pitch">The pitch of the note.</param>
		/// <param name="noteOn">The time (by ticks) when the note is on.</param>
		/// <param name="noteOff">The time (by ticks) when the note is off.</param>
		public Note(Pitch pitch, int noteOn, int noteOff) {
			this.Pitch = pitch;
			this.NoteOn = noteOn;
			this.NoteOff = noteOff;
		}
	}
}