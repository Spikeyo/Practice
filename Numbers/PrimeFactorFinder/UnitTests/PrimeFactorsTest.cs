// This file was auto-generated based on version 1.1.0 of the canonical data.

using Xunit;

namespace PrimeFactorsProject.UnitTests
{
    public class PrimeFactorsTest
    {
        [Fact]
        public void No_factors()
        {
            Assert.Empty(PrimeFactorFinder.Find(1));
        }

        [Fact]
        public void Prime_number()
        {
            Assert.Equal(new[] { 2 }, PrimeFactorFinder.Find(2));
        }

        [Fact]
        public void Square_of_a_prime()
        {
            Assert.Equal(new[] { 3, 3 }, PrimeFactorFinder.Find(9));
        }

        [Fact]
        public void Cube_of_a_prime()
        {
            Assert.Equal(new[] { 2, 2, 2 }, PrimeFactorFinder.Find(8));
        }

        [Fact]
        public void Product_of_primes_and_non_primes()
        {
            Assert.Equal(new[] { 2, 2, 3 }, PrimeFactorFinder.Find(12));
        }

        [Fact]
        public void Product_of_primes()
        {
            Assert.Equal(new[] { 5, 17, 23, 461 }, PrimeFactorFinder.Find(901255));
        }

        [Fact]
        public void Factors_include_a_large_prime()
        {
            Assert.Equal(new[] { 11, 9539, 894119 }, PrimeFactorFinder.Find(93819012551));
        }
    }
}