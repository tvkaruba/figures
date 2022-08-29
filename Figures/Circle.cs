namespace Figures
{
    public sealed class Circle : FigureBase, ICircle
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException(nameof(radius), radius, "Radius must be a positive number.");

            Radius = radius; 
        }

        protected override double CalculateSquare()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
