namespace cs_figura
{
    public class Composite
    {
        public Figura[] Figuras { get; set; }
        public double Square { get; set; }

        public Composite(params Figura[] figuras)
        {
            Figuras = figuras;
            SquareFigure();
        }

        public double SquareFigure()
        {
            for (int i = 0; i < Figuras.Length; i++)
            {
                Square += Figuras[i].SquareFigure();
            }
            return Square;
        }

        public override string ToString()
        {
            return $"Составная фигура\tПлощадь {Square} см2";
        }
    }
}