// This file was auto-generated based on version 1.4.0 of the canonical data.

using Xunit;

namespace LeapProject.UnitTests
{
    public class LeapTest
    {
        [Fact]
        public void Year_not_divisible_by_4_is_common_year()
        {
            Assert.False(LeapYear.IsLeapYear(2015));
        }

        [Fact]
        public void Year_divisible_by_4_not_divisible_by_100_is_leap_year()
        {
            Assert.True(LeapYear.IsLeapYear(1996));
        }

        [Fact]
        public void Year_divisible_by_100_not_divisible_by_400_is_common_year()
        {
            Assert.False(LeapYear.IsLeapYear(2100));
        }

        [Fact]
        public void Year_divisible_by_400_is_leap_year()
        {
            Assert.True(LeapYear.IsLeapYear(2000));
        }

        [Fact]
        public void Year_divisible_by_200_not_divisible_by_400_is_common_year()
        {
            Assert.False(LeapYear.IsLeapYear(1800));
        }
    }
}