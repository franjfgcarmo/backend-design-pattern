using System.Diagnostics;

namespace Poker.Utils
{
	internal class ClosedIntervalView
	{

		private string title;

		private ClosedInterval closedInterval;

		public ClosedIntervalView(string title, ClosedInterval closedInterval)
		{
			Debug.Assert(!string.ReferenceEquals(title, null));
			Debug.Assert(closedInterval != null);
			this.title = title;
			this.closedInterval = closedInterval;
		}

		public virtual void writeln()
		{
			IO.instance().writeln(title + " " + this.ToString());
		}

		public override string ToString()
		{
			return "[" + closedInterval.Min + ", " + closedInterval.Max + "]";
		}
	}

}