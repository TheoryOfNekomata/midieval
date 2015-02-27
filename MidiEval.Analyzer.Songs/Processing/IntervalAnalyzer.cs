namespace MidiEval.Analyzer.Songs.Processing {

	// TODO Interval Analyzer
	public class IntervalAnalyzer {
		private static readonly IntervalAnalyzer _instance = new IntervalAnalyzer();

		//public int[][] GetChannelIntervals(Channel channel) {
		//	for(var i = 0; i < channel.Notes.Count - 1; i++) {
		//	}
		//}

		/// <summary>
		/// Gets the instance of the <see cref="IntervalAnalyzer"/> class.
		/// </summary>
		/// <value>
		/// The instance of the <see cref="IntervalAnalyzer"/> class.
		/// </value>
		public static IntervalAnalyzer Instance {
			get { return _instance; }
		}
	}
}