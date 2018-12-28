using lab05.Brush;
using lab05.Canvas;

namespace lab05.Factory
{
    interface IAbstractFactory
    {
        ICanvas CreateCanvas();
        IBrush CreateBrush();
    }
}
