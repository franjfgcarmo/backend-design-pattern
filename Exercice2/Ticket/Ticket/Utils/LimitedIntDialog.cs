using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets.v1.Utils
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

		public int Read(String title, int min, int max)
		{
			Debug.Assert(title != null);
			ClosedInterval limits = new ClosedInterval(min, max);
			ClosedIntervalView limitsView = new ClosedIntervalView(
					"El valor debe estar entre ", limits);
			int value;
			bool ok;
			do
			{
				value =IO.Instance().ReadInt(title + " " + limitsView + ": ");
				ok = limits.includes(value);
				if (!ok)
				{
					limitsView.Writeln();
				}
			} while (!ok);
			return value;
		}

		public int Read(String title, int max)
		{
			return this.Read(title, 1, max);
		}
	}
}
