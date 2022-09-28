using System;

namespace cs_figura
{
    public class Triangle : Figura
    {
        private readonly double _katetOne;
        private readonly double _katetTwo;

        public Triangle(string figure, double one, double two) : base(figure)
        {
            _katetOne = one;
            _katetTwo = two;
            SquareFigure();
            PerimeterFigure();
        }

        public override double PerimeterFigure()
        {
            double three = Math.Sqrt(_katetOne + _katetTwo);
            Perimeter = _katetOne + _katetTwo + three;
            return Perimeter;
        }

        public override double SquareFigure()
        {
            Square = (_katetOne * _katetTwo) / 2;
            return Square;
        }
    }
}