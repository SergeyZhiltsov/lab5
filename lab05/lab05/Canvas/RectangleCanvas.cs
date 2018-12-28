using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab05.Canvas
{
    class RectangleCanvas : Form, ICanvas
    {
        public string canvasType = "Rectangle";

        public string GetCanvasType()
        {
            return canvasType;
        }
        #region IAbstractCanvas interface
        public PictureBox SetDrawBox(PictureBox pictureBox)
        {
            return pictureBox;
        }
        #endregion IAbstractCanvas interface

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // RectangleCanvas
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "RectangleCanvas";
            this.Load += new System.EventHandler(this.RectangleCanvas_Load);
            this.ResumeLayout(false);

        }

        private void RectangleCanvas_Load(object sender, EventArgs e)
        {

        }
    }
}
