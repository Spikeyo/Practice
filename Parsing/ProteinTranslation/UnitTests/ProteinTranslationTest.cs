// This file was auto-generated based on version 1.1.1 of the canonical data.

using Xunit;

namespace ProteinTranslationProject.UnitTests
{
    public class ProteinTranslationTest
    {
        [Fact]
        public void Methionine_rna_sequence()
        {
            Assert.Equal(new[] { "Methionine" }, ProteinTranslator.Translate("AUG"));
        }

        [Fact]
        public void Phenylalanine_rna_sequence_1()
        {
            Assert.Equal(new[] { "Phenylalanine" }, ProteinTranslator.Translate("UUU"));
        }

        [Fact]
        public void Phenylalanine_rna_sequence_2()
        {        
            Assert.Equal(new[] { "Phenylalanine" }, ProteinTranslator.Translate("UUC"));
        }

        [Fact]
        public void Leucine_rna_sequence_1()
        {
            Assert.Equal(new[] { "Leucine" }, ProteinTranslator.Translate("UUA"));
        }

        [Fact]
        public void Leucine_rna_sequence_2()
        {
            Assert.Equal(new[] { "Leucine" }, ProteinTranslator.Translate("UUG"));
        }

        [Fact]
        public void Serine_rna_sequence_1()
        {
            Assert.Equal(new[] { "Serine" }, ProteinTranslator.Translate("UCU"));
        }

        [Fact]
        public void Serine_rna_sequence_2()
        {
            Assert.Equal(new[] { "Serine" }, ProteinTranslator.Translate("UCC"));
        }

        [Fact]
        public void Serine_rna_sequence_3()
        {
            Assert.Equal(new[] { "Serine" }, ProteinTranslator.Translate("UCA"));
        }

        [Fact]
        public void Serine_rna_sequence_4()
        {
            Assert.Equal(new[] { "Serine" }, ProteinTranslator.Translate("UCG"));
        }

        [Fact]
        public void Tyrosine_rna_sequence_1()
        {
            Assert.Equal(new[] { "Tyrosine" }, ProteinTranslator.Translate("UAU"));
        }

        [Fact]
        public void Tyrosine_rna_sequence_2()
        {
            Assert.Equal(new[] { "Tyrosine" }, ProteinTranslator.Translate("UAC"));
        }

        [Fact]
        public void Cysteine_rna_sequence_1()
        {
            Assert.Equal(new[] { "Cysteine" }, ProteinTranslator.Translate("UGU"));
        }

        [Fact]
        public void Cysteine_rna_sequence_2()
        {
            Assert.Equal(new[] { "Cysteine" }, ProteinTranslator.Translate("UGC"));
        }

        [Fact]
        public void Tryptophan_rna_sequence()
        {
            Assert.Equal(new[] { "Tryptophan" }, ProteinTranslator.Translate("UGG"));
        }

        [Fact]
        public void Stop_codon_rna_sequence_1()
        {
            Assert.Empty(ProteinTranslator.Translate("UAA"));
        }

        [Fact]
        public void Stop_codon_rna_sequence_2()
        {
            Assert.Empty(ProteinTranslator.Translate("UAG"));
        }

        [Fact]
        public void Stop_codon_rna_sequence_3()
        {
            Assert.Empty(ProteinTranslator.Translate("UGA"));
        }

        [Fact]
        public void Translate_rna_strand_into_correct_protein_list()
        {
            Assert.Equal(new[] { "Methionine", "Phenylalanine", "Tryptophan" }, ProteinTranslator.Translate("AUGUUUUGG"));
        }

        [Fact]
        public void Translation_stops_if_stop_codon_at_beginning_of_sequence()
        {
            Assert.Empty(ProteinTranslator.Translate("UAGUGG"));
        }

        [Fact]
        public void Translation_stops_if_stop_codon_at_end_of_two_codon_sequence()
        {
            Assert.Equal(new[] { "Tryptophan" }, ProteinTranslator.Translate("UGGUAG"));
        }

        [Fact]
        public void Translation_stops_if_stop_codon_at_end_of_three_codon_sequence()
        {
            Assert.Equal(new[] { "Methionine", "Phenylalanine" }, ProteinTranslator.Translate("AUGUUUUAA"));
        }

        [Fact]
        public void Translation_stops_if_stop_codon_in_middle_of_three_codon_sequence()
        {
            Assert.Equal(new[] { "Tryptophan" }, ProteinTranslator.Translate("UGGUAGUGG"));
        }

        [Fact]
        public void Translation_stops_if_stop_codon_in_middle_of_six_codon_sequence()
        {
            Assert.Equal(new[] { "Tryptophan", "Cysteine", "Tyrosine" }, ProteinTranslator.Translate("UGGUGUUAUUAAUGGUUU"));
        }
    }
}