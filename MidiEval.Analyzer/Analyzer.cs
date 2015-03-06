using MidiEval.Analyzer.Collections;
using MidiEval.Analyzer.Elements;
using MidiEval.Analyzer.Processing;
using MidiEval.Analyzer.Songs;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NoteGroup = MidiEval.Analyzer.Processing.Collections.NoteGroup;

namespace MidiEval.Analyzer {

	/// <summary>
	/// The Analyzer class for MIDIEval.
	/// </summary>
	public class Analyzer {
		private static readonly Analyzer _instance = new Analyzer();
		private double[][,] _harmonicities;
		private NoteGroup[/* songList */][/* song */][] _noteGroups;
		private List<Song>[] _songLists;
		private Pattern[/* songList */][/* song */][] _patterns;

		/// <summary>
		/// Gets the instance of the Analyzer.
		/// </summary>
		/// <value>
		/// The instance of the Analyzer.
		/// </value>
		public static Analyzer Instance {
			get { return _instance; }
		}

		/// <summary>
		/// Gets the analyzed harmonicities.
		/// </summary>
		/// <value>
		/// The harmonicities.
		/// </value>
		public double[][,] Harmonicities {
			get { return this._harmonicities; }
		}

		/// <summary>
		/// Gets the note groups.
		/// </summary>
		/// <value>
		/// The note groups.
		/// </value>
		public NoteGroup[][][] NoteGroups {
			get { return this._noteGroups; }
		}

		public Pattern[][][] Patterns {
			get { return this._patterns; }
		}

		private Analyzer ReadSongs(Song[][] songs) {
			this._songLists = new List<Song>[songs.Length];
			for(var i = 0; i < this._songLists.Length; i++) {
				this._songLists[i] = new List<Song>();
				foreach(var song in songs[i])
					this._songLists[i].Add(song);
			}
			return this;
		}

		private Analyzer AnalyzeNoteGroups() {
			this._noteGroups = new NoteGroup[this._songLists.Length][][];
			for(var i = 0; i < this._songLists.Length; i++) {
				this._noteGroups[i] = new NoteGroup[this._songLists[i].Count][];
				for(var j = 0; j < this._songLists[i].Count; j++) {
					this._noteGroups[i][j] = NoteGrouper.Instance.GroupNotes(this._songLists[i][j]);
				}
			}
			return this;
		}

		private Analyzer AnalyzeStructures() {
			this._patterns = new Pattern[this._noteGroups.Length][][];
			for(var i = 0; i < this._noteGroups.Length; i++) {
				this._patterns[i] = new Pattern[this._noteGroups[i].Length][];
				for(var j = 0; j < this._noteGroups[i].Length; j++) {
					this._patterns[i][j] = PatternFinder.Instance.FindPatterns(this._noteGroups[i][j]);
				}
			}
			return this;
		}

		private Analyzer AnalyzeHarmonicities(KeyFindingProfile profile = KeyFindingProfile.Simple) {
			this._harmonicities = new double[this._noteGroups.Length][,];
			for(var i = 0; i < this._noteGroups.Length; i++) {
				var songList = this._noteGroups[i];
				this._harmonicities[i] = new double[songList.Length, 2];
				for(var j = 0; j < songList.Length; j++) {
					var song = songList[j];
					var min = float.MaxValue;
					var max = float.MinValue;

					var i1 = i;
					var j1 = j;

					if((int) this._songLists[i1][j1].KeySignature == -1) {
						var thisSong = this._songLists[i1][j1];
						thisSong.KeySignature = KeySignatureAnalyzer.Instance.Analyze(this._songLists[i1][j1]);
					}

					foreach(var harmonicity in song
						.Select(noteGroup => noteGroup.GetHarmonicity(
							profile, this._songLists[i1][j1].KeySignature
						))) {
						if(harmonicity > max)
							max = harmonicity;
						if(harmonicity < min)
							min = harmonicity;
					}
					this._harmonicities[i][j, 0] = min;
					this._harmonicities[i][j, 1] = max;
				}
			}
			return this;
		}

		/// <summary>
		/// Analyzes the specified sets of songs.
		/// </summary>
		/// <param name="songs">Array of songs.</param>
		/// <param name="profile">Key-finding profile to be used.</param>
		public Analyzer Analyze(Song[][] songs, KeyFindingProfile profile = KeyFindingProfile.Simple) {
			return this
				.ReadSongs(songs)
				.AnalyzeNoteGroups()
				.AnalyzeHarmonicities(profile);
			//.AnalyzeStructures();
		}
	}
}