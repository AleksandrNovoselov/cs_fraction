namespace cs_figura
{
    public class Square : Figura
    {
        private double _lenght;

        public Square(string figure, double lenght) : base(figure)
        {
            _lenght = lenght;
            SquareFigure();
            PerimeterFigure();
        }

        public override double PerimeterFigure()
        {
            return Perimeter = _lenght * 4;
        }

        public override double SquareFigure()
        {
            return Square = _lenght * _lenght;
        }
    }
}