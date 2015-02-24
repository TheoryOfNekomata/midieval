using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MidiEval.Core.Elements;

namespace MidiEval.Core {
	class MidiAnalyzer {
		private static MidiAnalyzer _instance = new MidiAnalyzer();

		private List<Stack<Note>> _patterns;

		public Pattern[] GetPatterns(Note[][] _segments) {
			return null;
		}

		public static MidiAnalyzer Instance {
			get { return _instance; }
		}
	}
}
