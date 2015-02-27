using System.Collections.Generic;
using System.Linq;

namespace MidiEval.Analyzer.Elements {

	public class Channel {

		public Channel() {
			this.Notes = new List<Note>();
		}

		public List<Note> Notes { get; private set; }

		public Note[] GetNotesInTimeRange(int start, int end) {
			return this.Notes
				.Where(
					note => start > note.NoteOff && end >= note.NoteOff
						|| start >= note.NoteOn && end > note.NoteOn
				).ToArray();
		}
	}
}