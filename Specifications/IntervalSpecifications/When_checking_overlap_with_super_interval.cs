using FluentAssertions;
using Machine.Specifications;
using Specifications.TestBuilders;

namespace Specifications.IntervalSpecifications
{
    [Subject(typeof(SUT.Interval))]
    public class When_checking_overlap_with_super_interval
    {
        Establish context = () =>
        {
            interval1 = BuildInterval.SurroundingTodayBy(-2.Days(), 2.Days());
            interval2 = BuildInterval.SurroundingTodayBy(-10.Days(), 10.Days());
        };

        Because of = () => intervalsOverlap = interval1.OverlapsWith(interval2);

        It should_detect_overlap = () => intervalsOverlap.Should().BeTrue();

        static SUT.Interval interval1;
        static SUT.Interval interval2;
        static bool intervalsOverlap;
    }
}