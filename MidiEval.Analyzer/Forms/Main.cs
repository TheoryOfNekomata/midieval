using MidiEval.Analyzer.Elements;
using MidiEval.Analyzer.Processing;
using MidiEval.Analyzer.Songs;
using Sanford.Multimedia.Midi;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
		}

		public Main() {
			this.Initialize();
		}

		private void BtnAnalyze_Click(object sender, EventArgs e) {
			KeyFindingProfile profile;
			if(!Enum.TryParse(this._cmbBoxProfile.SelectedItem.ToString(), out profile))
				return;
			Program.RunAnalyzer(profile);
			var charts = new[] {
				this._chartHarmonicities1,
				this._chartHarmonicities2
			};

			this._labelGenre1.Text = this._cmbBoxGenre1.Text;
			this._labelGenre2.Text = this._cmbBoxGenre2.Text;

			for(var i = 0; i < Program.Harmonicities.Length; i++) {
				charts[i].Series["Harmonicity"].Points.Clear();
				for(var j = 0; j < Program.Harmonicities[i].GetLength(0); j++)
					charts[i].Series["Harmonicity"].Points.AddXY(
						j + 1,
						Program.Harmonicities[i][j, 0],
						Program.Harmonicities[i][j, 1]);
			}

			this._tabCtrlMain.SelectedTab = this._tabPgOutput;
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
			System.Diagnostics.Process.Start((string) (((LinkLabel) sender).Tag));
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
			listView.Items.Clear();
			songList.Clear();
		}

		private void List_KeyUp(object sender, KeyEventArgs e) {
			var list = (ListView) sender;
			if(e.KeyCode != Keys.Delete)
				return;
			foreach(var item in list.SelectedItems)
				list.Items.Remove((ListViewItem) item);
			//list.SelectedItems
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
			if(Enum.TryParse(cmbBox.SelectedItem.ToString(), out profile))
				Program.Settings.Profile = profile;
			else
				Program.Settings.Profile = KeyFindingProfile.Simple;
			Console.Write(Program.Settings.Profile);
			Program.Settings.Save();
		}

		private void Main_FormClosed(object sender, FormClosedEventArgs e) {
			Program.Settings.Save();
		}
	}
}