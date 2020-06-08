using System.Diagnostics;

namespace Poker.Utils
{
	public class ClosedInterval
	{

		private int min;

		private int max;

		public ClosedInterval(int min, int max)
		{
			Debug.Assert(min <= max);
			this.min = min;
			this.max = max;
		}

		public virtual bool includes(int value)
		{
			return min <= value && value <= max;
		}

		internal virtual int Min
		{
			get
			{
				return min;
			}
		}

		internal virtual int Max
		{
			get
			{
				return max;
			}
		}

	}

}