using System.Collections.Generic;
using System.Linq;

namespace MidiEval.Analyzer.Elements {

	public class Channel {

		/// <summary>
		/// Initializes a new instance of the <see cref="Channel"/> class.
		/// </summary>
		public Channel() {
			this.Notes = new List<Note>();
		}

		/// <summary>
		/// Gets the channel's notes.
		/// </summary>
		/// <value>
		/// A list of the channel's notes.
		/// </value>
		public List<Note> Notes { get; private set; }

		/// <summary>
		/// Gets the notes in the specified time range.
		/// </summary>
		/// <param name="start">Start time (in ticks).</param>
		/// <param name="end">End time (in ticks).</param>
		/// <returns></returns>
		public Note[] GetNotesInTimeRange(int start, int end) {
			return this.Notes
				.Where(
					note => start > note.NoteOff && end >= note.NoteOff
						|| start >= note.NoteOn && end > note.NoteOn
				).ToArray();
		}
	}
}