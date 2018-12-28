using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab05.Canvas
{
    class CircleCanvas : DrawWindow, ICanvas
    {
        public string canvasType = "Circle";
        #region IAbstractCanvas interface
        public string GetCanvasType()
        {
            return canvasType;
        }
        public PictureBox SetDrawBox(PictureBox pictureBox)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox.Width - 3, pictureBox.Height - 3);
            Region rg = new Region(gp);
            pictureBox.Region = rg;
            return pictureBox;
        }
        #endregion IAbstractCanvas interface

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.DrawBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawBox
            // 
            this.DrawBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DrawBox.Location = new System.Drawing.Point(13, 12);
            this.DrawBox.Size = new System.Drawing.Size(235, 207);
            // 
            // CircleCanvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(260, 231);
            this.Name = "CircleCanvas";
            this.Load += new System.EventHandler(this.CircleCanvas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DrawBox)).EndInit();
            this.ResumeLayout(false);

        }

        private void CircleCanvas_Load(object sender, EventArgs e)
        {

        }

        private void labelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
