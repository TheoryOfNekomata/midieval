using MidiEval.Analyzer.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using NoteGroup = MidiEval.Analyzer.Processing.Collections.NoteGroup;

namespace MidiEval.Analyzer.Processing {

	public class PatternFinder {
		private static readonly PatternFinder _instance = new PatternFinder();

		public static PatternFinder Instance {
			get { return _instance; }
		}

		private int GetIntervalId(IEnumerable<int> intervals) {
			return intervals.GetHashCode();
		}

		private int GetIntervalId(NoteGroup group) {
			return this.GetIntervalId(group.Intervals);
		}

		private int GetIntervalId(int[,] intervalMatrix) {
			return intervalMatrix.GetHashCode();
		}

		private int[] GetIntervalIds(IEnumerable<int[,]> intervals) {
			return intervals
				.Select(this.GetIntervalId)
				.ToArray();
		}

		private IEnumerable<int> GetIntervalIds(IEnumerable<NoteGroup> noteGroups) {
			return noteGroups
				.Select(@group => this.GetIntervalId(@group.Intervals))
				.ToArray();
		}

		public Pattern[] FindPatterns(NoteGroup[] noteGroups) {
			var patterns = new Dictionary<int, Dictionary<Pattern, List<Pattern>>>();
			for(var resolution = noteGroups.Length / 2; resolution > 1; resolution--) {
				patterns.Add(resolution, new Dictionary<Pattern, List<Pattern>>());

				for(var i = 0; i < noteGroups.Length - resolution; i++) {
					var seq1 = noteGroups.Skip(i).Take(resolution).ToArray();
					var pattern1 = new Pattern(seq1);
					for(var j = 0; j < noteGroups.Length - resolution; j++) {
						if(i + resolution > j) // check if they intersect
							continue;

						var seq2 = noteGroups.Skip(j).Take(resolution).ToArray();

						if(!this.GetIntervalIds(seq1).SequenceEqual(this.GetIntervalIds(seq2)))
							continue;
						List<Pattern> similarPatterns;
						if(!patterns[resolution].TryGetValue(pattern1, out similarPatterns)) {
							similarPatterns = new List<Pattern>();
							patterns[resolution].Add(pattern1, similarPatterns);
						}
						patterns[resolution][pattern1].Add(new Pattern(seq2));
						j += seq2.Length - 1;
					}
				}
			}
			var maxPatternCount = 0;
			Dictionary<Pattern, List<Pattern>> maxPatterns = null;
			foreach(var patternDict in patterns.Values.Where(patternDict => patternDict.Count > maxPatternCount)) {
				maxPatternCount = patternDict.Count;
				maxPatterns = patternDict;
			}

			if(maxPatterns == null) {
				return null;
			}
			var thePatterns = new List<Pattern>();
			foreach(var patternKey in maxPatterns) {
				thePatterns.AddRange(patternKey.Value);
				thePatterns.Add(patternKey.Key);
			}
			return thePatterns.ToArray();
		}
	}
}