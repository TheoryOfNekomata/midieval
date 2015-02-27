using MidiEval.Analyzer.Forms;
using MidiEval.Analyzer.Songs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MidiEval.Analyzer {

	internal static class Program {

		private static readonly Dictionary<string, Song>[] _songs = new[] {
			new Dictionary<string, Song>(),
			new Dictionary<string, Song>()
		};

		public static Dictionary<string, Song>[] Songs {
			get { return _songs; }
		}

		public static void RunAnalyzer() {
			Analyzer.Instance.Analyze(_songs[0].Values.ToArray(), _songs[1].Values.ToArray());
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Main());
		}
	}
}