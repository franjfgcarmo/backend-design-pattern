using System.Diagnostics;

namespace Manager.v1.Utils
{
	public class ClosedInterval
	{

		private readonly int min;

		private readonly int max;

		public ClosedInterval(int min, int max)
		{
			Debug.Assert(min <= max);
			this.min = min;
			this.max = max;
		}

		public virtual bool Includes(int value)
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