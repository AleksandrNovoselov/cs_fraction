using System;

namespace cs_figura
{
    public class Ellipse : Figura
    {
        private double _radius1;
        private double _radius2;

        public Ellipse(string figure, double radius1, double radius2) : base(figure)
        {
            _radius1 = radius1;
            _radius2 = radius2;
        }

        public override double PerimeterFigure()
        {
            double sqrt = Math.Sqrt((Math.Pow(_radius1, 2) + Math.Pow(_radius2, 2)) / 2);
            return Perimeter = 2 * pi * sqrt;
        }

        public override double SquareFigure()
        {
            return Square = pi * _radius1 * _radius2;
        }
    }
}