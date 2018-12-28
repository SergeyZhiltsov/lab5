using System.Windows.Forms;

namespace lab05.Canvas
{
    interface ICanvas
    {
        string GetCanvasType();
        PictureBox SetDrawBox(PictureBox pictureBox);
    }
}
