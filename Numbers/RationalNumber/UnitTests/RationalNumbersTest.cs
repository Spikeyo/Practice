// This file was auto-generated based on version 1.0.0 of the canonical data.

using Xunit;

namespace RationalNumbersProject.UnitTests
{
    public class RationalNumbersTest
    {
        [Fact]
        public void Add_two_positive_rational_numbers()
        {
            Assert.Equal(new Fraction(7,6), new Fraction(1, 2) + (new Fraction(2, 3)));
        }

        [Fact]
        public void Add_a_positive_rational_number_and_a_negative_rational_number()
        {
            Assert.Equal(new Fraction(-1, 6), new Fraction(1, 2) + (new Fraction(-2, 3)));
        }

        [Fact]
        public void Add_two_negative_rational_numbers()
        {
            Assert.Equal(new Fraction(-7, 6), new Fraction(-1, 2) + (new Fraction(-2, 3)));
        }

        [Fact]
        public void Add_a_rational_number_to_its_additive_inverse()
        {
            Assert.Equal(new Fraction(0, 1), new Fraction(1, 2) + (new Fraction(-1, 2)));
        }

        [Fact]
        public void Subtract_two_positive_rational_numbers()
        {
            Assert.Equal(new Fraction(-1, 6), new Fraction(1, 2) - (new Fraction(2, 3)));
        }

        [Fact]
        public void Subtract_a_positive_rational_number_and_a_negative_rational_number()
        {
            Assert.Equal(new Fraction(7, 6), new Fraction(1, 2) - (new Fraction(-2, 3)));
        }

        [Fact]
        public void Subtract_two_negative_rational_numbers()
        {
            Assert.Equal(new Fraction(1, 6), new Fraction(-1, 2) - (new Fraction(-2, 3)));
        }

        [Fact]
        public void Subtract_a_rational_number_from_itself()
        {
            Assert.Equal(new Fraction(0, 1), new Fraction(1, 2) - (new Fraction(1, 2)));
        }

        [Fact]
        public void Multiply_two_positive_rational_numbers()
        {
            Assert.Equal(new Fraction(1, 3), new Fraction(1, 2) * (new Fraction(2, 3)));
        }

        [Fact]
        public void Multiply_a_negative_rational_number_by_a_positive_rational_number()
        {
            Assert.Equal(new Fraction(-1, 3), new Fraction(-1, 2) * (new Fraction(2, 3)));
        }

        [Fact]
        public void Multiply_two_negative_rational_numbers()
        {
            Assert.Equal(new Fraction(1, 3), new Fraction(-1, 2) * (new Fraction(-2, 3)));
        }

        [Fact]
        public void Multiply_a_rational_number_by_its_reciprocal()
        {
            Assert.Equal(new Fraction(1, 1), new Fraction(1, 2) * (new Fraction(2, 1)));
        }

        [Fact]
        public void Multiply_a_rational_number_by_1()
        {
            Assert.Equal(new Fraction(1, 2), new Fraction(1, 2) * (new Fraction(1, 1)));
        }

        [Fact]
        public void Multiply_a_rational_number_by_0()
        {
            Assert.Equal(new Fraction(0, 1), new Fraction(1, 2) * (new Fraction(0, 1)));
        }

        [Fact]
        public void Divide_two_positive_rational_numbers()
        {
            Assert.Equal(new Fraction(3, 4), new Fraction(1, 2) / (new Fraction(2, 3)));
        }

        [Fact]
        public void Divide_a_positive_rational_number_by_a_negative_rational_number()
        {
            Assert.Equal(new Fraction(-3, 4), new Fraction(1, 2) / (new Fraction(-2, 3)));
        }

        [Fact]
        public void Divide_two_negative_rational_numbers()
        {
            Assert.Equal(new Fraction(3, 4), new Fraction(-1, 2) / (new Fraction(-2, 3)));
        }

        [Fact]
        public void Divide_a_rational_number_by_1()
        {
            Assert.Equal(new Fraction(1, 2), new Fraction(1, 2) / (new Fraction(1, 1)));
        }

        [Fact]
        public void Absolute_value_of_a_positive_rational_number()
        {
            Assert.Equal(new Fraction(1, 2), new Fraction(1, 2).Abs());
        }

        [Fact]
        public void Absolute_value_of_a_negative_rational_number()
        {
            Assert.Equal(new Fraction(1, 2), new Fraction(-1, 2).Abs());
        }

        [Fact]
        public void Absolute_value_of_zero()
        {
            Assert.Equal(new Fraction(0, 1), new Fraction(0, 1).Abs());
        }

        [Fact]
        public void Raise_a_positive_rational_number_to_a_positive_integer_power()
        {
            Assert.Equal(new Fraction(1, 8), new Fraction(1, 2).ToThePowerOf(3));
        }

        [Fact]
        public void Raise_a_negative_rational_number_to_a_positive_integer_power()
        {
            Assert.Equal(new Fraction(-1, 8), new Fraction(-1, 2).ToThePowerOf(3));
        }

        [Fact]
        public void Raise_zero_to_an_integer_power()
        {
            Assert.Equal(new Fraction(0, 1), new Fraction(0, 1).ToThePowerOf(5));
        }

        [Fact]
        public void Raise_one_to_an_integer_power()
        {
            Assert.Equal(new Fraction(1, 1), new Fraction(1, 1).ToThePowerOf(4));
        }

        [Fact]
        public void Raise_a_positive_rational_number_to_the_power_of_zero()
        {
            Assert.Equal(new Fraction(1, 1), new Fraction(1, 2).ToThePowerOf(0));
        }

        [Fact]
        public void Raise_a_negative_rational_number_to_the_power_of_zero()
        {
            Assert.Equal(new Fraction(1, 1), new Fraction(-1, 2).ToThePowerOf(0));
        }

        [Fact]
        public void Raise_a_real_number_to_a_positive_rational_number()
        {
            Assert.Equal(16, 8.ToThePowerOfFraction(new Fraction(4, 3)), precision: 0);
        }

        [Fact]
        public void Raise_a_real_number_to_a_negative_rational_number()
        {
            Assert.Equal(0.3333333, 9.ToThePowerOfFraction(new Fraction(-1, 2)), precision: 7);
        }

        [Fact]
        public void Raise_a_real_number_to_a_zero_rational_number()
        {
            Assert.Equal(1, 2.ToThePowerOfFraction(new Fraction(0, 1)), precision: 0);
        }
    }
}