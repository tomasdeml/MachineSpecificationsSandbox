using System;

namespace SUT
{
    public class Interval
    {
        public Interval(DateTime start, DateTime end)
        {
            Start = start;
            End = end;
        }

        public DateTime Start { get; private set; } 
        public DateTime End { get; private set; }

        public bool OverlapsWith(Interval another)
        {
            return another.Start <= End && Start <= another.End;
        }
    }
}