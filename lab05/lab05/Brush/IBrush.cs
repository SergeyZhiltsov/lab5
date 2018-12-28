using System.Drawing;

namespace lab05.Brush
{
    interface IBrush
    {
        Pen CreateBrush();
        int SetSize(int size);
        int GetSize(int size);
        Color SetColor(Color color);
        Color GetColor(Color color);
        Graphics SetGraph(Graphics g);
        void Draw(Graphics g, Point prevPoint, Point currentPoint);
    }
}
