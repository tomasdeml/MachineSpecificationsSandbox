using System;
using SUT;

namespace Specifications.TestBuilders
{
    static class BuildInterval
    {
        public static Interval SurroundingTodayBy(TimeSpan startDelta, TimeSpan endDelta)
        {
            return new Interval(DateTime.Today.Add(startDelta), DateTime.Today.Add(endDelta));
        }
    }
}
