using FluentAssertions;
using Machine.Specifications;
using Specifications.TestBuilders;

namespace Specifications.IntervalSpecifications
{
    [Subject(typeof(SUT.Interval))]
    public class When_checking_overlap_with_interval_intersecting_from_left
    {
        Establish context = () =>
        {
            interval1 = BuildInterval.SurroundingTodayBy(-2.Days(), 2.Days());
            interval2 = BuildInterval.SurroundingTodayBy(-4.Days(), -1.Days());
        };

        Because of = () => intervalsOverlap = interval1.OverlapsWith(interval2);

        It should_detect_overlap = () => intervalsOverlap.Should().BeTrue();

        static SUT.Interval interval1;
        static SUT.Interval interval2;
        static bool intervalsOverlap;
    }
}