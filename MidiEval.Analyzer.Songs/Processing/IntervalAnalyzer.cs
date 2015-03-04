using MidiEval.Analyzer.Elements;
using System;
using System.Collections.Generic;

namespace MidiEval.Analyzer.Songs.Processing {
	// TODO Interval Analyzer

	public class IntervalAnalyzer {
		private static readonly IntervalAnalyzer _instance = new IntervalAnalyzer();

		public int[] GetIntervals(Note[] notes) {
			var intervals = new List<int>();
			if(notes.Length > 1)
				for(var i = 0; i < notes.Length - 1; i++)
					intervals.Add(Math.Abs(notes[i].Pitch.MidiPitch - notes[i + 1].Pitch.MidiPitch));
			return intervals.ToArray();
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