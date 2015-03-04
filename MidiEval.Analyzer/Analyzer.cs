using MidiEval.Analyzer.Songs;
using MidiEval.Analyzer.Songs.Processing;
using System.Windows.Forms;

namespace MidiEval.Analyzer {

	/// <summary>
	/// The Analyzer class for MIDIEval.
	/// </summary>
	public class Analyzer {
		private static readonly Analyzer _instance = new Analyzer();

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
		/// Analyzes the specified sets of songs.
		/// </summary>
		/// <param name="songs1">First array of songs.</param>
		/// <param name="songs2">Second array of songs.</param>
		public void Analyze(Song[] songs1, Song[] songs2) {
			foreach(var song in songs1) {
				var i = 1;
				foreach(var channel in song.Channels) {
					var noteGroups = NoteGrouper.Instance.GroupNotes(channel);
					MessageBox.Show("Channel " + i++ + ": " + noteGroups.Length);
				}
			}
		}
	}
}