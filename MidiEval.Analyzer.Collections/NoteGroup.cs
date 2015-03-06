using MidiEval.Analyzer.Elements;
using System.Collections.Generic;
using System.Linq;

namespace MidiEval.Analyzer.Collections {

	/// <summary>
	/// Class for a group of <see cref="Note"/>s.
	/// </summary>
	public abstract class NoteGroup {

		/// <summary>
		/// Gets the notes in the note group.
		/// </summary>
		/// <value>
		/// The notes.
		/// </value>
		public List<Note> Notes { get; private set; }

		protected NoteGroup() {
		}

		protected NoteGroup(IEnumerable<Note> notes) {
			this.Notes = new List<Note>(notes);
		}

		/// <summary>
		/// Gets the note in the note group with the latest Note Off.
		/// </summary>
		/// <value>
		/// The note with the latest Note Off.
		/// </value>
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

		/// <summary>
		/// Gets the note in the note group with the Earliest Note On.
		/// </summary>
		/// <value>
		/// The note with the earliest Note On.
		/// </value>
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

		public int Start {
			get { return this.EarliestNote.NoteOn; }
		}

		public int End {
			get { return this.LatestNote.NoteOff; }
		}

		public int Duration {
			get { return this.LatestNote.NoteOff - this.EarliestNote.NoteOn; }
		}
	}
}