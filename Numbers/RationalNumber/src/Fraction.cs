using System;
using System.Diagnostics;

namespace RationalNumbersProject
{
    public static class IntExtension
    {
        public static double ToThePowerOfFraction(this int integer, Fraction power)
        {
            return power.AsPowerOf(integer);
        }
    }

    public struct Fraction
    {
        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new InvalidOperationException();
            }

            Numerator = numerator;
            Denominator = denominator;
            ReduceSelf();
            MoveLoneNegativeSignUp();
            EliminateDoubleNegativeSigns();
        }

        public int Numerator { get; private set; }
        public int Denominator { get; private set; }


        public static Fraction operator +(Fraction r1, Fraction r2)
        {
            return new Fraction(r1.Numerator * r2.Denominator + r2.Numerator * r1.Denominator,
                r1.Denominator * r2.Denominator);
        }
    
        public static Fraction operator -(Fraction r1, Fraction r2)
        {
            return new Fraction(r1.Numerator * r2.Denominator - r2.Numerator * r1.Denominator,
                r1.Denominator * r2.Denominator);
        }

        public static Fraction operator *(Fraction r1, Fraction r2)
        {
            return new Fraction(r1.Numerator * r2.Numerator, 
                r1.Denominator * r2.Denominator);
        }

        public static Fraction operator /(Fraction r1, Fraction r2)
        {
            return new Fraction(r1.Numerator * r2.Denominator, 
                r1.Denominator * r2.Numerator);
        } 
    
        public Fraction Add(Fraction r) => this + r;
        public Fraction Sub(Fraction r) => this - r;
        public Fraction Mul(Fraction r) => this * r;
        public Fraction Div(Fraction r) => this / r;
    
        public Fraction Abs()
        {
            return new Fraction(Math.Abs(Numerator), Math.Abs(Denominator));
        } 
    
        public Fraction ToThePowerOf(int power)
        {
            int absPower = Math.Abs(power);
        
            return new Fraction((int)Math.Pow(Numerator, absPower), 
                (int)Math.Pow(Denominator, absPower));
        }

        public double AsPowerOf(int baseNumber)
        {
            return Math.Pow(baseNumber, (double)Numerator / Denominator);
        }

        private int FindGreatestCommonDivisor(int a, int b)
        {
            return b == 0 ? a : FindGreatestCommonDivisor(b, a % b);
        }

        public override string ToString()
        {
            return $"Num: {Numerator}, Den: {Denominator}";
        }

        private void ReduceSelf()
        {
            int gcd = FindGreatestCommonDivisor(Numerator, Denominator);
        
            Numerator = Numerator / gcd;
        
            Denominator = Denominator / gcd;
        }

        private void MoveLoneNegativeSignUp()
        {
            if (Denominator < 0 && Numerator > 0)
            {
                Denominator *= -1;
                Numerator *= -1;
            }
        }

        private void EliminateDoubleNegativeSigns()
        {
            if (Numerator < 0 && Denominator < 0)
            {
                Numerator *= -1;
                Denominator *= -1;
            }
        }
    }
}