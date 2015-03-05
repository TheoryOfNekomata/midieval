using Sanford.Multimedia.Midi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MidiEval.Analyzer.Songs.Input {

	public class EventParser {

		protected int Compare(int x, int y) {
			return x - y;
		}

		protected int Compare(MessageType x, MessageType y) {
			return (int) x - (int) y;
		}

		protected int Compare(ChannelCommand x, ChannelCommand y) {
			return (int) x - (int) y;
		}

		protected int CompareEvents(MidiEvent x, MidiEvent y) {
			var ticks = this.Compare(x.AbsoluteTicks, y.AbsoluteTicks);
			if(ticks != 0)
				return ticks;

			/*
			var messageType = this.Compare(x.MidiMessage.MessageType, y.MidiMessage.MessageType);
			if(messageType != 0)
				return messageType;
			 */

			return this.Compare(x.MidiMessage.MessageType, y.MidiMessage.MessageType);
			/*
			try {
				var channelCommand = this.Compare(
					((ChannelMessage) x.MidiMessage).Command,
					((ChannelMessage) y.MidiMessage).Command);
				return channelCommand;
			} catch(Exception) {
				return messageType;
			}
			 */
		}
	}
}