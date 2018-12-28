using lab05.Brush;
using lab05.Canvas;

namespace lab05.Factory
{
    class ConcreteFactoryRectangle : IAbstractFactory
    {
        #region IAbstractFactory interface
        public IBrush CreateBrush()
        {
            return new Brush.RectangleBrush();
        }
        public ICanvas CreateCanvas()
        {
            return new Canvas.RectangleCanvas();
        }
        #endregion IAbstractFactory interface
    }
}