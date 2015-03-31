using FluentAssertions;
using Machine.Specifications;
using Specifications.TestBuilders;

namespace Specifications.IntervalStartComparerSpecifications
{
    [Subject(typeof(SUT.IntervalStartComparer))]
    public class When_comparing_same_intervals
    {
        Establish context = () =>
        {
            interval1 = BuildInterval.SurroundingTodayBy(-1.Days(), 1.Days());
            interval2 = BuildInterval.SurroundingTodayBy(-1.Days(), 1.Days());
        };

        Because of = () => result = new SUT.IntervalStartComparer().Compare(interval1, interval2);

        It should_indicate_both_intervals_are_equal = () => result.Should().Be(0);

        static SUT.Interval interval1;
        static SUT.Interval interval2;
        static int result;
    }
}
