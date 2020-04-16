using System;
using System.Diagnostics;

namespace Tickets.v1.Utils
{
	public class ClosedIntervalView
    {
		private readonly string title;

		private readonly ClosedInterval closedInterval;

		public ClosedIntervalView(string title, ClosedInterval closedInterval)
		{
			Debug.Assert(title != null);
			Debug.Assert(closedInterval != null);
			this.title = title;
			this.closedInterval = closedInterval;
		}

		public void Writeln()
		{
			IO.Instance().Writeln(title + " " + ToString());
			
		}

		public override string ToString()
		{
			return $"[{closedInterval.GetMin()}, {closedInterval.GetMax()}]";
		}
	}
}
