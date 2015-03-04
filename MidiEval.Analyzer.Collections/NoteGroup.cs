using MidiEval.Analyzer.Elements;
using System.Collections.Generic;
using System.Linq;

namespace MidiEval.Analyzer.Collections {

	public abstract class NoteGroup {

		public List<Note> Notes { get; private set; }

		protected NoteGroup() {
		}

		protected NoteGroup(IEnumerable<Note> notes) {
			this.Notes = new List<Note>(notes);
		}

		public Note LatestNote {
			get {
				Note[] latestNote = { null };
				foreach(var note in this.Notes.Where(
					note => latestNote[0] == null
						|| note.NoteOff > latestNote[0].NoteOff
					)
				)
					latestNote[0] = note;
				return latestNote[0];
			}
		}

		public Note EarliestNote {
			get {
				Note[] earliestNote = { null };
				foreach(var note in this.Notes.Where(
					note => earliestNote[0] == null
							|| note.NoteOn < earliestNote[0].NoteOn
					)
				)
					earliestNote[0] = note;
				return earliestNote[0];
			}
		}
	}
}