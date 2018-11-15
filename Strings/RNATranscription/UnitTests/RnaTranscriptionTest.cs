// This file was auto-generated based on version 1.3.0 of the canonical data.

using Xunit;

namespace RnaTranscriptionProject.UnitTests
{
    public class RnaTranscriptionTest
    {
        [Fact]
        public void Empty_rna_sequence()
        {
            Assert.Equal("", RnaTranscriptor.ToRna(""));
        }

        [Fact]
        public void Rna_complement_of_cytosine_is_guanine()
        {
            Assert.Equal("G", RnaTranscriptor.ToRna("C"));
        }

        [Fact]
        public void Rna_complement_of_guanine_is_cytosine()
        {
            Assert.Equal("C", RnaTranscriptor.ToRna("G"));
        }

        [Fact]
        public void Rna_complement_of_thymine_is_adenine()
        {
            Assert.Equal("A", RnaTranscriptor.ToRna("T"));
        }

        [Fact]
        public void Rna_complement_of_adenine_is_uracil()
        {
            Assert.Equal("U", RnaTranscriptor.ToRna("A"));
        }

        [Fact]
        public void Rna_complement()
        {
            Assert.Equal("UGCACCAGAAUU", RnaTranscriptor.ToRna("ACGTGGTCTTAA"));
        }
    }
}