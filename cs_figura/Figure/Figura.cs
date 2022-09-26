using System;

namespace cs_figura
{
    public abstract class Figura
    {
        public const double pi = 3.14;

        public double Square { get; set; }
        public double Perimeter { get; set; }
        public string NameFigure { get; set; }

        public Figura(string figure)
        {
            NameFigure = figure;
            SquareFigure();
            PerimeterFigure();
        }

        public abstract double SquareFigure();

        public abstract double PerimeterFigure();

        public virtual void Print()
        {
            Console.WriteLine($"Фигура {NameFigure}\tПлощадь {Square} см2\tПериметр {Perimeter} см");
        }
    }
}