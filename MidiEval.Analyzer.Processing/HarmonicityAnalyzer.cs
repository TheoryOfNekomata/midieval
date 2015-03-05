using MidiEval.Analyzer.Elements.Notes;
using Sanford.Multimedia;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MidiEval.Analyzer.Processing {

	/// <summary>
	/// Class for the harmonicity analyzer.
	/// </summary>
	public class HarmonicityAnalyzer {
		private static readonly HarmonicityAnalyzer _instance = new HarmonicityAnalyzer();

		/// <summary>
		/// Gets the instance of the <see cref="HarmonicityAnalyzer"/>.
		/// </summary>
		/// <value>
		/// The instance of the <see cref="HarmonicityAnalyzer"/> class.
		/// </value>
		public static HarmonicityAnalyzer Instance {
			get { return _instance; }
		}

		private bool IsMinorKey(Key key) {
			return (int) key <= 14;
		}

		/// <summary>
		/// Analyzes the harmonicity of the specified pitch.
		/// </summary>
		/// <param name="pitch">The pitch.</param>
		/// <param name="key">The key to where the <paramref name="pitch"/> will be analyzed.</param>
		/// <param name="profile">The key-finding profile to be used.</param>
		/// <returns>A value corresponding to the harmonicity of the <paramref name="pitch"/> to the <paramref name="key"/>.</returns>
		public float Analyze(Pitch pitch, Key key = Key.CMajor, KeyFindingProfile profile = KeyFindingProfile.Simple) {
			return ProfileDictionary.Weights[profile][this.IsMinorKey(key) ? 1 : 0, (int) pitch.Key];
		}

		/// <summary>
		/// Gets the minor harmonicity between two pitches.
		/// </summary>
		/// <param name="pitch1">The first pitch.</param>
		/// <param name="pitch2">The second pitch.</param>
		/// <param name="profile">The key-finding profile to be used.</param>
		/// <returns>The minor harmonicity between the two pitches.</returns>
		private float GetMinorHarmonicity(Pitch pitch1, Pitch pitch2, KeyFindingProfile profile = KeyFindingProfile.Simple) {
			return ProfileDictionary.Weights[profile][1, Math.Abs(pitch1.MidiPitch - pitch2.MidiPitch) % 12];
		}

		/// <summary>
		/// Gets the major harmonicity between two pitches.
		/// </summary>
		/// <param name="pitch1">The first pitch.</param>
		/// <param name="pitch2">The second pitch.</param>
		/// <param name="profile">The key-finding profile to be used.</param>
		/// <returns>The major harmonicity between the two pitches.</returns>
		private float GetMajorHarmonicity(Pitch pitch1, Pitch pitch2, KeyFindingProfile profile = KeyFindingProfile.Simple) {
			return ProfileDictionary.Weights[profile][0, Math.Abs(pitch1.MidiPitch - pitch2.MidiPitch) % 12];
		}

		/// <summary>
		/// Analyzes the harmonicity between two or more pitches.
		/// </summary>
		/// <param name="pitches">The pitches.</param>
		/// <param name="profile">The key-finding profile to be used.</param>
		/// <returns>Array of harmonicities between pitches.</returns>
		private IEnumerable<float> AnalyzeIntervals(IEnumerable<Pitch> pitches, KeyFindingProfile profile = KeyFindingProfile.Simple, Key keySignature = Key.CMajor) {
			var pitchList = new List<Pitch>(pitches);
			pitchList.Sort((pitch, pitch1) => pitch.Key - pitch1.Key);
			var pitchArray = pitchList.ToArray();

			if(pitches.Count() < 2)
				return new[] {
					this.Analyze(pitches.ElementAt(0), keySignature, profile)
				};

			return pitchArray
				.Select((t, i) =>
					(
						this.GetMajorHarmonicity(t, pitchArray[(i + 1) % pitchArray.Length], profile)
						+ this.GetMinorHarmonicity(t, pitchArray[(i + 1) % pitchArray.Length], profile)
					) / 2
				).ToArray();
		}

		/// <summary>
		/// Analyzes the average harmonicity of two or more pitches.
		/// </summary>
		/// <param name="pitches">The pitches.</param>
		/// <param name="profile">The key-finding profile to be used.</param>
		/// <returns>Average harmonicity of the pitches.</returns>
		/// <seealso cref="AnalyzeIntervals"/>
		public float AnalyzeAverage(Pitch[] pitches, KeyFindingProfile profile = KeyFindingProfile.Simple) {
			return this.AnalyzeIntervals(pitches, profile).Average();
		}
	}
}