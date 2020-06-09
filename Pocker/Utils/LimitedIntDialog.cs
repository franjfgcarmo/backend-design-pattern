using System.Diagnostics;

namespace Poker.Utils
{
	public class LimitedIntDialog
	{

		private static LimitedIntDialog limitedIntDialog;

		public static LimitedIntDialog Instance()
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

		public virtual int Read(string title, int min, int max)
		{
			Debug.Assert(!string.ReferenceEquals(title, null));
			ClosedInterval limits = new ClosedInterval(min, max);
			ClosedIntervalView limitsView = new ClosedIntervalView("El valor debe estar entre ", limits);
			int value;
			bool ok;
			do
			{
				value = IO.Instance().ReadInt(title + " " + limitsView + ": ");
				ok = limits.Includes(value);
				if (!ok)
				{
					limitsView.Writeln();
				}
			} while (!ok);
			return value;
		}

		public virtual int Read(string title, int max)
		{
			return this.Read(title, 1, max);
		}
	}

}