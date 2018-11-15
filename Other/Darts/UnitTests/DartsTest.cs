// This file was auto-generated based on version 1.0.0 of the canonical data.

using Xunit;

namespace DartsProject.UnitTests
{
    public class DartsTest
    {
        [Fact]
        public void A_dart_lands_outside_the_target()
        {
            Assert.Equal(0, Darts.CalculateScore(15.3, 13.2));
        }

        [Fact]
        public void A_dart_lands_just_in_the_border_of_the_target()
        {
            Assert.Equal(1, Darts.CalculateScore(10, 0));
        }

        [Fact]
        public void A_dart_lands_in_the_middle_circle()
        {
            Assert.Equal(5, Darts.CalculateScore(3, 3.7));
        }

        [Fact]
        public void A_dart_lands_right_in_the_border_between_outside_and_middle_circles()
        {
            Assert.Equal(5, Darts.CalculateScore(0, 5));
        }

        [Fact]
        public void A_dart_lands_outside_with_a_coord_of_negative_x_and_positive_y()
        {
            Assert.Equal(0, Darts.CalculateScore(-30, 49));
        }

        [Fact]
        public void A_dart_lands_in_the_middle_with_a_coord_of_negative_x_and_zero_y()
        {
            Assert.Equal(5, Darts.CalculateScore(-3.4, 0));
        }

        [Fact]
        public void A_dart_lands_in_the_bullseye_with_a_coord_of_negative_x_and_negative_y()
        {
            Assert.Equal(10, Darts.CalculateScore(-0.3422, -0.7));
        }
    }
}