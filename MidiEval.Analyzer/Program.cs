using MidiEval.Analyzer.Forms;
using MidiEval.Analyzer.Processing;
using MidiEval.Analyzer.Properties;
using MidiEval.Analyzer.Songs;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace MidiEval.Analyzer {

	/// <summary>
	/// The Program class for MIDIEval, serving as its main entry point.
	/// </summary>
	internal static class Program {

		/// <summary>
		/// Gets the settings of the program.
		/// </summary>
		/// <value>
		/// The settings.
		/// </value>
		public static Properties.Settings Settings { get; private set; }

		private static readonly Dictionary<string, Song>[] _songs = new[] {
			new Dictionary<string, Song>(),
			new Dictionary<string, Song>()
		};

		public static double[][,] Harmonicities { get; private set; }

		/// <summary>
		/// Gets the loaded songs in the program.
		/// </summary>
		/// <value>
		/// The songs loaded in the program.
		/// </value>
		public static Dictionary<string, Song>[] Songs {
			get { return _songs; }
		}

		/// <summary>
		/// Runs the analyzer.
		/// </summary>
		public static void RunAnalyzer(KeyFindingProfile profile = KeyFindingProfile.Simple) {
			var analyzer = Analyzer.Instance
				.Analyze(new[] {
					_songs[0].Values.ToArray(),
					_songs[1].Values.ToArray()
				}, profile);

			Harmonicities = analyzer.Harmonicities;
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main() {
			Settings = Settings.Default;
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Main());
		}
	}
}