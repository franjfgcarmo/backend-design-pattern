using System.Diagnostics;

namespace Manager.v1.Utils
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

        public virtual void Writeln() => IO.Instance().Writeln(title + " " + this.ToString());

        public override string ToString() => "[" + closedInterval.Min + ", " + closedInterval.Max + "]";
    }

}