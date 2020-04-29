using System.Diagnostics;

namespace TPV.v1.Utils
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

        public bool Includes(int value)
        {
            return min <= value && value <= max;
        }
        public int GetMin()
        {
            return min;
        }

        public int GetMax()
        {
            return max;
        }
    }
}