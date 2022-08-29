namespace Figures
{
    public abstract class FigureBase : IFigure
    {
        public virtual double GetSquare()
        {
            return CalculateSquare();
        }

        protected abstract double CalculateSquare();
    }
}
