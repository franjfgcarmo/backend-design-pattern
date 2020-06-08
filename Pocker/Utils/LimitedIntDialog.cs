using System.Diagnostics;

namespace Poker.Utils
{
	public class LimitedIntDialog
	{

		private static LimitedIntDialog limitedIntDialog;

		public static LimitedIntDialog instance()
		{
			if (limitedIntDialog == null)
			{
				limitedIntDialog = new LimitedIntDialog();
			}
			return limitedIntDialog;
		}

		private LimitedIntDialog()
		{

		}

		public virtual int read(string title, int min, int max)
		{
			Debug.Assert(!string.ReferenceEquals(title, null));
			ClosedInterval limits = new ClosedInterval(min, max);
			ClosedIntervalView limitsView = new ClosedIntervalView("El valor debe estar entre ", limits);
			int value;
			bool ok;
			do
			{
				value = IO.instance().readInt(title + " " + limitsView + ": ");
				ok = limits.includes(value);
				if (!ok)
				{
					limitsView.writeln();
				}
			} while (!ok);
			return value;
		}

		public virtual int read(string title, int max)
		{
			return this.read(title, 1, max);
		}
	}

}