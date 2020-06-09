using System.Diagnostics;

namespace Poker.Utils
{
	internal class ClosedIntervalView
	{

		private readonly string title;

		private ClosedInterval closedInterval;

		public ClosedIntervalView(string title, ClosedInterval closedInterval)
		{
			Debug.Assert(!string.IsNullOrWhiteSpace(title));
			Debug.Assert(closedInterval != null);
			this.title = title;
			this.closedInterval = closedInterval;
		}

        public virtual void Writeln() => IO.Instance().Writeln(title + " " + this.ToString());

        public override string ToString() => $"[{closedInterval.Min}, {closedInterval.Max}]";
    }

}