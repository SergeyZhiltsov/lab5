using System.Drawing;
using System.Drawing.Drawing2D;

namespace lab05.Brush
{
    class RectangleBrush : IBrush
    {
        private int _size = 5;
        private Color _color = Color.Black;
        private Graphics _g;

        public Pen CreateBrush()
        {
            Pen p = new Pen(_color, _size);
            return p;
        }

        public int SetSize(int size)
        {
            _size = size;
            return size;
        }

        public Color SetColor(Color color)
        {
            _color = color;
            return color;
        }

        public int GetSize(int size)
        {
            return size;
        }

        public Color GetColor(Color color)
        {
            return color;
        }

        public Graphics SetGraph(Graphics g)
        {
            _g = g;
            return _g;
        }

        public void Draw(Graphics g, Point prevPoint, Point currentPoint)
        {
            Pen p = CreateBrush();
            g.DrawRectangle(p, currentPoint.X, currentPoint.Y, _size, _size);
        }
    }
}
