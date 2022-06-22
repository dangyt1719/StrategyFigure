using MathSDK.Interfaces;

namespace MathSDK
{
    public class MathSDK
    {
        public IFigure _figure {private get;set;}

        public MathSDK(IFigure figure)
        {
            _figure = figure;
        }
        public double GetArea()
        {
            return _figure.Area();
        }
    }
}