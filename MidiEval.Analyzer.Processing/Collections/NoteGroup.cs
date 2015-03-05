using Sanford.Multimedia;
using System.Collections.Generic;
using System.Linq;
using Note = MidiEval.Analyzer.Elements.Note;

namespace MidiEval.Analyzer.Processing.Collections {

	public class NoteGroup : Analyzer.Collections.NoteGroup {

		public NoteGroup()
			: base() {
		}

		public NoteGroup(IEnumerable<Note> notes)
			: base(notes) {
		}

		public float GetHarmonicity(KeyFindingProfile profile = KeyFindingProfile.Simple, Key keySignature = Key.CMajor) {
			return HarmonicityAnalyzer.Instance
				.AnalyzeAverage(
					this.Notes
						.Select(note => note.Pitch)
						.ToArray(),
					profile
				);
		}

		public int[] Intervals {
			get { return IntervalAnalyzer.Instance.GetIntervals(this.Notes.ToArray()); }
		}
	}
}