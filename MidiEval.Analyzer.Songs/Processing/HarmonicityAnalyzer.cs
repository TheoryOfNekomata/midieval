using MidiEval.Analyzer.Elements.Notes;
using Sanford.Multimedia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MidiEval.Analyzer.Songs.Processing {

	public class HarmonicityAnalyzer {
		private static readonly HarmonicityAnalyzer _instance = new HarmonicityAnalyzer();

		private readonly Dictionary<KeyFindingProfile, float[,]> _profiles = new Dictionary<KeyFindingProfile, float[,]>() {
			{
				KeyFindingProfile.KrumhanslSchmuckler,
				new [,] {
					{ 6.35F, 2.23F, 3.48F, 2.33F, 4.38F, 4.09F, 2.52F, 5.19F, 2.39F, 3.66F, 2.29F, 2.88F },
					{ 6.33F, 2.68F, 3.52F, 5.38F, 2.60F, 3.53F, 2.54F, 4.75F, 3.98F, 2.69F, 3.34F, 3.17F }
				}
			}, {
				KeyFindingProfile.AardenEssen,
				new [,] {
					{ 17.7661F, 0.145624F, 14.9265F, 0.160186F, 19.8049F, 11.3587F, 0.291248F, 22.062F, 0.145624F, 8.15494F, 0.232998F, 4.95122F },
					{ 18.2648F, 0.737619F, 14.0499F, 16.8599F, 0.702494F, 14.4362F, 0.702494F, 18.6161F, 4.56621F, 1.93186F, 7.37619F, 1.75623F }
				}
			}, {
				KeyFindingProfile.Simple,
				new [,] {
					{ 2F, 0F, 1F, 0F, 1F, 1F, 0F, 2F, 0F, 1F, 0F, 1F },
					{ 2F, 0F, 1F, 1F, 0F, 1F, 0F, 2F, 1F, 0F, 0.5F, 0.5F }
				}
			}, {
				KeyFindingProfile.BellmanBudge,
				new [,] {
					{ 16.80F, 0.86F, 12.95F, 1.41F, 13.49F, 11.93F, 1.25F, 20.28F, 1.80F, 8.04F, 0.62F, 10.57F },
					{ 18.16F, 0.69F, 12.99F, 13.34F, 1.07F, 11.15F, 1.38F, 21.07F, 7.49F, 1.53F, 0.92F, 10.21F }
				}
			}, {
				KeyFindingProfile.TemperleyKostkaPayne,
				new [,] {
					{ 0.748F, 0.060F, 0.488F, 0.082F, 0.670F, 0.460F, 0.096F, 0.715F, 0.104F, 0.366F, 0.057F, 0.400F },
					{ 0.712F, 0.084F, 0.474F, 0.618F, 0.049F, 0.460F, 0.105F, 0.747F, 0.404F, 0.067F, 0.133F, 0.330F }
				}
			}
		};

		public static HarmonicityAnalyzer Instance {
			get { return _instance; }
		}

		private bool IsMinorKey(Key key) {
			return (int) key <= 14;
		}

		public float Analyze(Pitch pitch, Key key, KeyFindingProfile profile = KeyFindingProfile.Simple) {
			return this._profiles[profile][this.IsMinorKey(key) ? 1 : 0, (int) pitch.Key];
		}

		private float GetMinorHarmonicity(Pitch pitch1, Pitch pitch2, KeyFindingProfile profile = KeyFindingProfile.Simple) {
			return this._profiles[profile][1, Math.Abs(pitch1.MidiPitch - pitch2.MidiPitch) % 12];
		}

		private float GetMajorHarmonicity(Pitch pitch1, Pitch pitch2, KeyFindingProfile profile = KeyFindingProfile.Simple) {
			return this._profiles[profile][0, Math.Abs(pitch1.MidiPitch - pitch2.MidiPitch) % 12];
		}

		private float[] AnalyzeIntervals(Pitch[] pitches, KeyFindingProfile profile = KeyFindingProfile.Simple) {
			var pitchList = new List<Pitch>(pitches);
			pitchList.Sort((pitch, pitch1) => pitch.Key - pitch1.Key);
			var pitchArray = pitchList.ToArray();

			return pitchArray
				.Select((t, i) =>
					(
						this.GetMajorHarmonicity(t, pitchArray[(i + 1) % pitchArray.Length], profile)
						+ this.GetMinorHarmonicity(t, pitchArray[(i + 1) % pitchArray.Length], profile)
					) / 2
				).ToArray();
		}

		public float AnalyzeAverage(Pitch[] pitches, KeyFindingProfile profile = KeyFindingProfile.Simple) {
			return this.AnalyzeIntervals(pitches, profile).Average();
		}
	}
}