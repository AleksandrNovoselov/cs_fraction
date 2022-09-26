namespace cs_figura
{
    public class Rectangle : Figura
    {
        private double _lenght;
        private double _height;

        public Rectangle(string figure, double lenght, double height) : base(figure)
        {
            _lenght = lenght;
            _height = height;
            SquareFigure();
            PerimeterFigure();
        }

        public override double PerimeterFigure()
        {
            return Perimeter = (_height + _lenght) * 2;
        }

        public override double SquareFigure()
        {
            return Square = _height * _lenght;
        }
    }
}