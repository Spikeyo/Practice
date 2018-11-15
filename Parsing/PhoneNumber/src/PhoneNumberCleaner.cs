//*************************************************************
// Solution for the PhoneNumber exercise in Exercism.io
//
// ~Spikeyo
//*************************************************************

using System;
using System.Linq;

namespace PhoneNumberProject
{
    public static class PhoneNumberCleaner
    {
        public static string Clean(string phoneNumber)
        {
            return phoneNumber.RemoveNonDigits()
                .ValidateAndRemoveCountryCode();
        }

        private static string RemoveNonDigits(this string s)
        {
            return string.Join("", s.Where(char.IsDigit));
        }

        private static string ValidateAndRemoveCountryCode(this string cleanNumber)
        {
            if (cleanNumber.Length != 10 
                && cleanNumber.Length != 11)
            {
                throw new ArgumentException("Incorrect number of digits");
            }

            if (cleanNumber.Length == 11)
            {
                if (IsCountryCodeValid(cleanNumber[0]))
                {
                    throw new ArgumentException("Country code is not valid.");
                }

                cleanNumber = cleanNumber.Remove(0, 1);
            }

            ValidateNANPNumber(cleanNumber);

            return cleanNumber;
        }

        private static void ValidateNANPNumber(string cleanNumber)
        {
            if (!IsNDigitValid(cleanNumber[0]))
            {
                throw new ArgumentException("Area code is not valid.");
            }

            if (!IsNDigitValid(cleanNumber[3]))
            {
                throw new ArgumentException("Exchange code is not valid.");
            }
        }

        private static bool IsCountryCodeValid(char c) => c != '1';
        private static bool IsNDigitValid(char c) => char.GetNumericValue(c) >= 2;
    }
}