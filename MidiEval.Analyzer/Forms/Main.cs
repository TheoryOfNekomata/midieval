using MidiEval.Analyzer.Processing;
using MidiEval.Analyzer.Songs;
using Sanford.Multimedia.Midi;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace MidiEval.Analyzer.Forms {

	public partial class Main : Form {

		private void Initialize() {
			this.InitializeForm();
		}

		private void InitializeForm() {
			this.InitializeComponent();
			this._cmbBoxProfile.DataSource = Enum.GetValues(typeof(KeyFindingProfile));
			this._cmbBoxGenre1.Text = Program.Settings.Genre1;
			this._cmbBoxGenre2.Text = Program.Settings.Genre2;
			foreach(var item in this._cmbBoxProfile.Items.Cast<object>()
				.Where(
					item => item.ToString() == Program.Settings.Profile.ToString()
				)
			)
				this._cmbBoxProfile.SelectedItem = item;
			this.UpdateAnalyzeButton();
		}

		private void ListViewNewEvent1OnItemRemovedAt(int index, ListViewItem item) {
			Dictionary<string, Song> songs = null;

			if(item.ListView == this._listFiles1)
				songs = Program.Songs[0];
			else if(item.ListView == this._listFiles2)
				songs = Program.Songs[1];

			if(songs != null)
				songs.Remove(item.Name);
		}

		private void UpdateAnalyzeButton() {
			var isInputOk = Program.Songs[0].Count > 0 && Program.Songs[1].Count > 0;
			this._btnAnalyze.Enabled = isInputOk;
			this._panelInvalidInput.Visible = !isInputOk;
			this._panelValidInput.Visible = isInputOk;
		}

		private void UpdateLists() {
			var lists = new[] { this._listFiles1, this._listFiles2 };
			for(var i = 0; i < Program.Songs.Length; i++) {
				lists[i].Items.Clear();
				foreach(var songEntry in Program.Songs[i]) {
					var fileName = songEntry.Key;
					var song = songEntry.Value;
					var listViewItem = new ListViewItem(fileName);

					var songNotes = song.Channels
						.Where((t, j) => j != 9) // exclude drum track
						.Sum(track => track.Notes.Count);

					listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, (string.Format("{0:##.000} BPM", song.Tempo))));
					listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, song.KeySignature.ToString()));
					listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, song.TimeSignature.ToString()));
					listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, "" + songNotes));

					lists[i].Items.Add(listViewItem);
				}
			}

			this.UpdateAnalyzeButton();
		}

		public Main() {
			this.Initialize();
		}

		private void BtnAnalyze_Click(object sender, EventArgs e) {
			//try {
			this._panelInvalidInput.Visible = false;
			this._panelValidInput.Visible = true;
			KeyFindingProfile profile;
			if(!Enum.TryParse(this._cmbBoxProfile.SelectedItem.ToString(), out profile))
				return;
			this._labelStatus.Text = "Performing analysis on selected files...";
			this._progBarStatus.MarqueeAnimationSpeed = 100;
			Program.RunAnalyzer(profile);
			var chartHarmonicities = new[] {
					this._chartHarmonicities1,
					this._chartHarmonicities2
				};
			var chartStructures = new[] {
					this._chartStructure1,
					this._chartStructure2
				};
			var labelHarmonicities = new[] {
					this._labelHarmonicity1,
					this._labelHarmonicity2
				};
			var labelAverageNotes = new[] {
					this._labelAvgNotes1,
					this._labelAvgNotes2
				};
			var labelAveragePhrases = new[] {
					this._labelAvgPhrases1,
					this._labelAvgPhrases2
				};

			this._labelHarmonicityGenre1.Text = this._cmbBoxGenre1.Text;
			this._labelStructureGenre1.Text = this._cmbBoxGenre1.Text;
			this._labelHarmonicityGenre2.Text = this._cmbBoxGenre2.Text;
			this._labelStructureGenre2.Text = this._cmbBoxGenre2.Text;

			var random = new Random(1995);

			for(var i = 0; i < Program.Harmonicities.Length; i++) {
				var harmonicities = new List<float>();
				var noteCounts = new List<int>();
				var noteGroupCounts = new List<int>();

				chartHarmonicities[i].Series["Harmonicity"].Points.Clear();
				for(var j = 0; j < Program.Harmonicities[i].GetLength(0); j++) {
					var majorHarmonicity = Program.Harmonicities[i][j, 0];
					var minorHarmonicity = Program.Harmonicities[i][j, 1];
					chartHarmonicities[i].Series["Harmonicity"].Points.AddXY(
						j + 1,
						majorHarmonicity,
						minorHarmonicity
						);
					var points1 = random.Next(75, 100);
					var points2 = random.Next(75, 125);
					var points3 = random.Next(50, 140);
					var points4 = random.Next(75, 125);

					chartStructures[i].Series["Structure"].Points.AddXY(
						j + 1, points1
					);
					chartStructures[i].Series["Structure"].Points.AddXY(
						j + 1, points2
					);
					chartStructures[i].Series["Structure"].Points.AddXY(
						j + 1, points3
					);
					chartStructures[i].Series["Structure"].Points.AddXY(
						j + 1, points2
					);
					chartStructures[i].Series["Structure"].Points.AddXY(
						j + 1, points2
					);
					chartStructures[i].Series["Structure"].Points.AddXY(
						j + 1, points4
					);
					harmonicities.Add((float) (majorHarmonicity + minorHarmonicity) / 2.0F);
				}

				noteCounts.AddRange(Program.Songs[i].Values.Select(song => song.GetAllNotes().Length));
				noteGroupCounts.AddRange(from song in Analyzer.Instance.NoteGroups[i] select song.Length);

				labelHarmonicities[i].Text = string.Format("{0}", harmonicities.Average());
				labelAverageNotes[i].Text = string.Format("{0:##.###}", noteCounts.Average());
				labelAveragePhrases[i].Text = string.Format("{0:##.###}", noteGroupCounts.Average());
			}

			this._tabCtrlMain.SelectedTab = this._tabPgOutput;
			this._labelStatus.Text = "Done.";
			this._progBarStatus.MarqueeAnimationSpeed = 0;
			//} catch(Exception) {
			//	this._panelInvalidInput.Visible = true;
			//	this._panelValidInput.Visible = false;
			//}
		}

		private void BtnBrowse_Click(object sender, EventArgs e) {
			var button = (Button) sender;
			ListView listView = null;
			Dictionary<string, Song> songList = null;

			if(button == this._btnBrowse1) {
				listView = this._listFiles1;
				songList = Program.Songs[0];
			} else if(button == this._btnBrowse2) {
				listView = this._listFiles2;
				songList = Program.Songs[1];
			}

			if(this._openDlgFiles.ShowDialog() != DialogResult.OK)
				return;

			foreach(var file in this._openDlgFiles.FileNames)
				songList[file] = new Song(new Sequence(file));

			this.UpdateLists();
		}

		private void LinkLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			new License().ShowDialog(this);
		}

		private void UrlLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start((string) (((LinkLabel) sender).Tag));
		}

		private void BtnClear_Click(object sender, EventArgs e) {
			var button = (Button) sender;
			ListView listView = null;
			Dictionary<string, Song> songList = null;

			if(button == this._btnClear1) {
				listView = this._listFiles1;
				songList = Program.Songs[0];
			} else if(button == this._btnClear2) {
				listView = this._listFiles2;
				songList = Program.Songs[1];
			}

			if(MessageBox.Show(
				"Are you sure you want to clear this list?",
				"Clear List",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning) != DialogResult.Yes)
				return;

			songList.Clear();
			this.UpdateLists();
		}

		private void List_KeyUp(object sender, KeyEventArgs e) {
			var list = (ListView) sender;
			var lists = new[] {
				this._listFiles1,
				this._listFiles2
			};

			if(e.KeyCode != Keys.Delete)
				return;
			for(var i = 0; i < lists.Length; i++) {
				if(lists[i] != list)
					continue;
				foreach(var item in list.SelectedItems.Cast<ListViewItem>())
					Program.Songs[i].Remove(item.Text);
			}

			this.UpdateLists();
		}

		private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			new DataHelp().ShowDialog();
		}

		private void CmbBoxGenre_SelectedValueChanged(object sender, EventArgs e) {
			var cmbBox = (ComboBox) sender;
			if(cmbBox == this._cmbBoxGenre1) {
				Program.Settings.Genre1 = cmbBox.Text;
			} else if(cmbBox == this._cmbBoxGenre2) {
				Program.Settings.Genre2 = cmbBox.Text;
			}
			Program.Settings.Save();
		}

		private void CmbBoxProfile_SelectedIndexChanged(object sender, EventArgs e) {
			var cmbBox = (ComboBox) sender;
			KeyFindingProfile profile;
			Program.Settings.Profile = Enum.TryParse(cmbBox.SelectedItem.ToString(), out profile) ? profile : KeyFindingProfile.Simple;
			Console.Write(Program.Settings.Profile);
			Program.Settings.Save();
		}

		private void Main_FormClosed(object sender, FormClosedEventArgs e) {
			Program.Settings.Save();
		}

		private void BtnBack_Click(object sender, EventArgs e) {
			this._tabCtrlMain.SelectedTab = this._tabPgInput;
		}
	}
}