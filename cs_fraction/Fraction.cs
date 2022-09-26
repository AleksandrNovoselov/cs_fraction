using System;

namespace cs_fraction
{
    public class Fraction
    {
        private int _numerator;
        private int _denominator;

        public int Numerator { get => _numerator; set => _numerator = value; }
        public int Denominator { get => _denominator; set => _denominator = value; }

        public Fraction(int numerator, int denominator)//конструктор
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("В знаменателе не может быть нуля");
            }
            if (denominator < 0)
            {
                denominator *= -1;
                numerator *= -1;
            }
            _numerator = numerator;
            _denominator = denominator;

            reduce();
        }

        public Fraction(int number) : this(number, 1)
        {
        }

        public static Fraction operator +(Fraction left, Fraction right)
        {
            return new Fraction(left.Numerator * right.Denominator + right.Numerator * left.Denominator,
                left.Denominator * right.Denominator);
        }

        public static Fraction operator +(Fraction left, int right)
        {
            return left + new Fraction(right);
        }

        public static Fraction operator +(Fraction left, double right)
        {
            return left + new Fraction((int)(right * 1000000), 1000000);
        }


        public static Fraction operator +(int left, Fraction right)
        {
            return right + left;
        }

        public static Fraction operator -(Fraction left, Fraction right)
        {
            return new Fraction(left.Numerator * right.Denominator - right.Numerator * left.Denominator,
                left.Denominator * right.Denominator);
        }

        public static Fraction operator -(Fraction left, int right)
        {
            return left - new Fraction(right);
        }

        public static Fraction operator -(int left, Fraction right)
        {
            return new Fraction(left) - right;
        }

        public static Fraction operator *(Fraction left, Fraction right)
        {
            return new Fraction(left.Numerator * right.Numerator, left.Denominator * right.Denominator);
        }

        public static Fraction operator *(Fraction left, int right)
        {
            return left * new Fraction(right);
        }

        public static Fraction operator *(int left, Fraction right)
        {
            return right * left;
        }

        public static Fraction operator /(Fraction left, Fraction right)
        {
            return new Fraction(left.Numerator * right.Denominator, left.Denominator * right.Numerator);
        }

        public static Fraction operator /(Fraction left, int right)
        {
            return left / new Fraction(right);
        }

        public static Fraction operator /(int left, Fraction right)
        {
            return new Fraction(left) / right;
        }

        public static bool operator ==(Fraction left, Fraction right)
        {
            return (decimal)left.Numerator * right.Denominator == (decimal)right.Numerator * left.Denominator;
        }

        public static bool operator !=(Fraction left, Fraction right)
        {
            return (!(left == right));
        }

        public static bool operator >(Fraction left, Fraction right)
        {
            return (decimal)left.Numerator * right.Denominator > (decimal)right.Numerator * left.Denominator;
        }

        public static bool operator <(Fraction left, Fraction right)
        {
            return (decimal)left.Numerator * right.Denominator < (decimal)right.Numerator * left.Denominator;
        }


        public static bool operator true(Fraction fract)
        {
            return fract.Numerator < fract.Denominator;
        }
        public static bool operator false(Fraction fract)
        {
            return fract.Numerator > fract.Denominator;
        }

        public override string ToString()
        {
            return Numerator + "/" + Denominator;
        }

        private int GreatestCommonDivisor(int a, int b)
        {
            int copy;
            while (b > 0)
            {
                a %= b;
                copy = a;
                a = b;
                b = copy;
            }
            return a;
        }

        private void reduce()
        {
            int gcdVal = GreatestCommonDivisor(Numerator, Denominator);

            Numerator /= gcdVal;
            Denominator /= gcdVal;
        }
    }
}