using System;

namespace cs_figura
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Triangle triangle = new Triangle("треугольник", 5, 5);
            triangle.Print();

            var sq = new Square("Квадрат", 5);
            sq.Print();

            var rec = new Rectangle("прямоугольник", 5, 7);
            rec.Print();

            var romb = new Rhomb("Ромб", 5, 7);
            romb.Print();

            Composite composite = new Composite(sq, rec, romb);
            Console.WriteLine(composite.ToString());

            Console.ReadKey();
        }
    }
}