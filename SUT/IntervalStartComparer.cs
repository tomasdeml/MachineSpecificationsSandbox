using System.Collections.Generic;

namespace SUT
{
    public class IntervalStartComparer : IComparer<Interval>
    {
        public int Compare(Interval x, Interval y)
        {
            return x.Start.CompareTo(y.Start);
        }
    }
}