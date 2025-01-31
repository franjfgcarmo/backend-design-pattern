﻿using System;
using System.Diagnostics;

namespace TPV.v1.Utils
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

		public int Read(string title, int min, int max)
		{
			Debug.Assert(title != null);
			ClosedInterval limits = new ClosedInterval(min, max);
			ClosedIntervalView limitsView = new ClosedIntervalView(
					"El valor debe estar entre ", limits);
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

		public int Read(string title, int max)
		{
			return Read(title, 1, max);
		}
	}
}
