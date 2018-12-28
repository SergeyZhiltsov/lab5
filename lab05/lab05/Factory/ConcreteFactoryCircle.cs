using lab05.Brush;
using lab05.Canvas;

namespace lab05.Factory
{
    class ConcreteFactoryCircle : IAbstractFactory
    {
        #region IAbstractFactory interface
        public IBrush CreateBrush()
        {
            return new Brush.CircleBrush();
        }
        public ICanvas CreateCanvas()
        {
            return new Canvas.CircleCanvas();
        }
        #endregion IAbstractFactory interface
    }
}