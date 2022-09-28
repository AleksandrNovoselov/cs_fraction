namespace cs_figura
{
    public class Trapeze : Figura
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;
        private double _sideD;
        private double _height;

        public Trapeze(string figure, double sideA, double sideB, double sideC, double sideD, double height) : base(figure)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
            _sideD = sideD;
            _height = height;
        }

        public override double PerimeterFigure()
        {
            return Perimeter=_sideA+_sideB+_sideC+_sideD;
        }

        public override double SquareFigure()
        {
            return Square=(_sideA+_sideC)/2*_height;
        }
    }
}
