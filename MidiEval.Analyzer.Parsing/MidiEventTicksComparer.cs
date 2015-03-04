using Sanford.Multimedia.Midi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MidiEval.Analyzer.Data {

	public class MidiEventTicksComparer : IComparer<MidiEvent> {

		public int Compare(MidiEvent x, MidiEvent y) {
			return y.AbsoluteTicks - x.AbsoluteTicks;
		}
	}
}