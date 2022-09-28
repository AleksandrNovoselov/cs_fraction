using System;

namespace cs_figura
{
    public class Circle : Figura
    {
        private double _radius;

        public Circle(string figure, double radius) : base(figure)
        {
            _radius = radius;
        }

        public override double PerimeterFigure()
        {
            return Perimeter=2*pi*_radius;
        }

        public override double SquareFigure()
        {
            return Square=pi*Math.Pow(_radius,2);
        }
    }
}
