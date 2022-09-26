using System;

namespace cs_figura
{
    public class Rhomb : Figura
    {
        private double _diagonal1;
        private double _diagonal2;

        public Rhomb(string figure, double diagonal1, double diagonal2) : base(figure)
        {
            _diagonal1 = diagonal1;
            _diagonal2 = diagonal2;
            SquareFigure();
            PerimeterFigure();
        }

        public override double PerimeterFigure()
        {
            return Perimeter = 2 * Math.Sqrt(Math.Pow(_diagonal1, 2) + Math.Pow(_diagonal2, 2));
        }

        public override double SquareFigure()
        {
            return Square = _diagonal1 * _diagonal2 / 2;
        }
    }
}