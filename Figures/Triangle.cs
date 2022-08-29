namespace Figures
{
    public sealed class Triangle : FigureBase, ITriangle
    {
        public double FirstSide { get; }

        public double SecondSide { get; }

        public double ThirdSide { get; }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0)
                throw new ArgumentOutOfRangeException(nameof(firstSide), firstSide, "Side length of triangle must be a positive.");
            if (secondSide <= 0)
                throw new ArgumentOutOfRangeException(nameof(secondSide), secondSide, "Side length of triangle must be a positive.");
            if (thirdSide <= 0)
                throw new ArgumentOutOfRangeException(nameof(thirdSide), thirdSide, "Side length of triangle must be a positive.");

            if (firstSide + secondSide <= thirdSide ||
                firstSide + thirdSide <= secondSide ||
                secondSide + thirdSide <= firstSide)
                throw new ArgumentException("This triangle can't exist.");

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        public bool IsRightAngled()
        {
            var sides = new[] { FirstSide, SecondSide, ThirdSide };
            var maxSide = sides.Max();
            return maxSide * maxSide == sides.Where(side => side != maxSide).Select(side => side * side).Sum();
        }

        protected override double CalculateSquare()
        {
            var semiPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - FirstSide) * (semiPerimeter - SecondSide) * (semiPerimeter - ThirdSide));
        }
    }
}
