using System;
using FluentAssertions;
using Machine.Specifications;

namespace Specifications.IntervalSpecifications
{
    [Subject(typeof(SUT.Interval))]
    public class When_creating_new_one
    {
        Because of = () => interval = new SUT.Interval(new DateTime(2014, 1, 1), new DateTime(2014, 1, 5));

        It should_capture_start_date = () => interval.Start.Should().Be(new DateTime(2014, 1, 1)); 
        It should_capture_end_date = () => interval.End.Should().Be(new DateTime(2014, 1, 5));

        static SUT.Interval interval;
    }
}
