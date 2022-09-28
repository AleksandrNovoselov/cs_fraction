namespace cs_figura
{
    public class Parallelogram : Figura
    {
        private readonly double _side1;
        private readonly double _side2;
        private readonly double _height;

        public Parallelogram(string figure, double side1, double side2, double height) : base(figure)
        {
            _side1 = side1;
            _side2 = side2;
            _height = height;
        }

        public override double PerimeterFigure()
        {
            return Perimeter=(_side1+_side2)*2;
        }

        public override double SquareFigure()
        {
            return Square=_side1*_height;
        }
    }
}