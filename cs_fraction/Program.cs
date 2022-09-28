using System;

namespace cs_fraction
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Fraction f = new Fraction(3, 4);
            int a = 10;

            Fraction f1 = f * a;

            Console.WriteLine("f1 " + f1.ToString());

            Fraction f2 = a * f;

            Console.WriteLine("f2 " + f2.ToString());

            double d = 1.5;

            Fraction f3 = f + d;

            Console.WriteLine("f3 " + f3.ToString());

            if (f)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);
        }
    }
}