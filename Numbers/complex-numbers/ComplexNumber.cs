using System;

namespace ComplexNumbers
{
    public struct ComplexNumber
    {
        public ComplexNumber(double real, double imaginary)
            => (Real, Imaginary) = (real, imaginary);    

        public double Real { get; }
        public double Imaginary { get; }
    
        public ComplexNumber Multiply(ComplexNumber other)
            => new ComplexNumber(Real * other.Real - Imaginary * other.Imaginary, 
                                 Imaginary * other.Real + Real * other.Imaginary); 

        public ComplexNumber Add(ComplexNumber other) 
            => new ComplexNumber(Real + other.Real, Imaginary + other.Imaginary);

        public ComplexNumber Subtract(ComplexNumber other)
            => new ComplexNumber(Real - other.Real, Imaginary - other.Imaginary);

        public ComplexNumber DivideBy(ComplexNumber other)
        {
            var denominator  = (Math.Pow(other.Real, 2) + Math.Pow(other.Imaginary, 2));
        
            return new ComplexNumber((Real * other.Real + Imaginary * other.Imaginary) / denominator, 
                                     (Imaginary * other.Real - Real * other.Imaginary) / denominator);
        }
        
        public double Abs() => Math.Sqrt(Real * Real + Imaginary * Imaginary);

        public ComplexNumber Conjugate() => new ComplexNumber(Real, -Imaginary);

        public ComplexNumber Exp()
            => new ComplexNumber(Math.Pow(Math.E, Real) * Math.Cos(Imaginary), 
                                 Math.Pow(Math.E, Real) * Math.Sin(Imaginary));

        public static ComplexNumber operator +(ComplexNumber thisOne, ComplexNumber other) => thisOne.Add(other);
        public static ComplexNumber operator -(ComplexNumber thisOne, ComplexNumber other) => thisOne.Subtract(other);
        public static ComplexNumber operator /(ComplexNumber thisOne, ComplexNumber other) => thisOne.DivideBy(other);
        public static ComplexNumber operator *(ComplexNumber thisOne, ComplexNumber other) => thisOne.Multiply(other);
    }
}