using MidiEval.Analyzer.Elements;
using MidiEval.Analyzer.Elements.Notes;
using System;
using System.Collections.Generic;

namespace MidiEval.Analyzer.Processing {
	// TODO Interval Analyzer

	public class IntervalAnalyzer {
		private static readonly IntervalAnalyzer _instance = new IntervalAnalyzer();

		public int GetInterval(Pitch pitch1, Pitch pitch2) {
			return Math.Abs(pitch1.MidiPitch - pitch2.MidiPitch);
		}

		public int GetInterval(Note note1, Note note2) {
			return this.GetInterval(note1.Pitch, note2.Pitch);
		}

		public int[] GetIntervals(Note[] notes) {
			var intervals = new List<int>();
			if(notes.Length > 1)
				for(var i = 0; i < notes.Length - 1; i++)
					intervals.Add(this.GetInterval(notes[i], notes[i + 1]));
			return intervals.ToArray();
		}

		public int[,] GetIntervals(Note[] noteGroup1, Note[] noteGroup2) {
			var intervals = new int[noteGroup2.Length, noteGroup1.Length];
			for(var i = 0; i < noteGroup1.Length; i++)
				for(var j = 0; j < noteGroup2.Length; j++)
					intervals[j, i] = this.GetInterval(noteGroup1[i], noteGroup2[j]);
			return intervals;
		}

		/// <summary>
		/// Gets the instance of the <see cref="IntervalAnalyzer"/> class.
		/// </summary>
		/// <value>
		/// The instance of the <see cref="IntervalAnalyzer"/> class.
		/// </value>
		public static IntervalAnalyzer Instance {
			get { return _instance; }
		}
	}
}