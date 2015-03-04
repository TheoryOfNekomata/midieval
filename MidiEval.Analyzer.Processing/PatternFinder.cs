using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MidiEval.Analyzer.Songs.Processing {

	public class PatternFinder {
		private static readonly PatternFinder _instance = new PatternFinder();

		public static PatternFinder Instance {
			get { return _instance; }
		}

		private int GetIntervalId(int[,] intervalMatrix) {
			return intervalMatrix.GetHashCode();
		}

		private int[] GetIntervalIds(IEnumerable<int[,]> intervals) {
			return intervals
				.Select(this.GetIntervalId)
				.ToArray();
		}

		/*
		 function LCSubstr(S[1..m], T[1..n])
    L := array(1..m, 1..n)
    z := 0
    ret := {}
    for i := 1..m
        for j := 1..n
            if S[i] == T[j]
                if i == 1 or j == 1
                    L[i,j] := 1
                else
                    L[i,j] := L[i-1,j-1] + 1
                if L[i,j] > z
                    z := L[i,j]
                    ret := {S[i-z+1..i]}
                else
                if L[i,j] == z
                    ret := ret ∪ {S[i-z+1..i]}
            else
                L[i,j] := 0
    return ret
		 */

		public void FindPatterns(int[][,] intervals) {
			var intervalIds = this.GetIntervalIds(intervals);

			var patterns = new Dictionary<int, Dictionary<int, List<int>>>();

			for(var resolution = intervalIds.Length / 2; resolution > 1; resolution--) {
				patterns[resolution] = new Dictionary<int, List<int>>();
				for(var i = 0; i < intervalIds.Length - resolution; i++)
					for(var j = 0; j < intervalIds.Length - resolution; j++) {
						if(j == i
							|| !intervalIds.Skip(i).Take(resolution).SequenceEqual(intervalIds.Skip(j).Take(resolution)))
							continue;
						List<int> list;
						if(!patterns[resolution].TryGetValue(i, out list)) {
							list = new List<int>();
							patterns[resolution].Add(i, list);
						}
						list.Add(j);
					}
			}
		}
	}
}