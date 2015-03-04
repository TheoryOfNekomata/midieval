using MidiEval.Analyzer.Elements;
using MidiEval.Analyzer.Elements.Notes;
using System;
using System.Collections.Generic;

namespace MidiEval.Analyzer.Processing {

	/// <summary>
	/// Class for finding the intervals between notes.
	/// </summary>
	public class IntervalAnalyzer {
		private static readonly IntervalAnalyzer _instance = new IntervalAnalyzer();

		/// <summary>
		/// Gets the interval between two pitches.
		/// </summary>
		/// <param name="pitch1">The first pitch.</param>
		/// <param name="pitch2">The second pitch.</param>
		/// <returns>The interval between the two pitches</returns>
		public int GetInterval(Pitch pitch1, Pitch pitch2) {
			return Math.Abs(pitch1.MidiPitch - pitch2.MidiPitch);
		}

		/// <summary>
		/// Gets the interval between two notes' pitches.
		/// </summary>
		/// <param name="note1">The first pitch.</param>
		/// <param name="note2">The second pitch.</param>
		/// <returns>The interval between the two pitches</returns>
		public int GetInterval(Note note1, Note note2) {
			return this.GetInterval(note1.Pitch, note2.Pitch);
		}

		/// <summary>
		/// Gets the intervals among notes.
		/// </summary>
		/// <param name="notes">The notes.</param>
		/// <returns>Array of intervals between the notes.</returns>
		public int[] GetIntervals(Note[] notes) {
			var intervals = new List<int>();
			if(notes.Length > 1)
				for(var i = 0; i < notes.Length - 1; i++)
					intervals.Add(this.GetInterval(notes[i], notes[i + 1]));
			return intervals.ToArray();
		}

		/// <summary>
		/// Gets the intervals between two sets of notes.
		/// </summary>
		/// <param name="noteGroup1">First set of notes.</param>
		/// <param name="noteGroup2">Second set of notes.</param>
		/// <returns>Array of intervals among the sets of notes.</returns>
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