// This file was auto-generated based on version 1.2.1 of the canonical data.

using System;
using Xunit;

namespace CollatzConjectureProject.UnitTests
{
    public class CollatzConjectureTest
    {
        [Fact]
        public void Zero_FindNumSteps_for_one()
        {
            Assert.Equal(0, CollatzConjecture.FindNumSteps(1));
        }

        [Fact]
        public void Divide_if_even()
        {
            Assert.Equal(4, CollatzConjecture.FindNumSteps(16));
        }

        [Fact]
        public void Even_and_odd_FindNumSteps()
        {
            Assert.Equal(9, CollatzConjecture.FindNumSteps(12));
        }

        [Fact]
        public void Large_number_of_even_and_odd_FindNumSteps()
        {
            Assert.Equal(152, CollatzConjecture.FindNumSteps(1000000));
        }

        [Fact]
        public void Zero_is_an_error()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => CollatzConjecture.FindNumSteps(0));
        }

        [Fact]
        public void Negative_value_is_an_error()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => CollatzConjecture.FindNumSteps(-15));
        }
    }
}