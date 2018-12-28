using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace lab05
{
    public partial class DrawWindow : Form
    {
        private Factory.IAbstractFactory factoryCircle;
        private Factory.IAbstractFactory factoryRectangle;
        private bool ispressed = false;
        private Color currentColor = Color.Black;
        private int size = 5;
        public string drawType;
        Graphics g;
        Point prevPoint;
        Point currentPoint;

        public DrawWindow()
        {
            InitializeComponent();
            g = DrawBox.CreateGraphics();
        }

        private void DrawWindow_Load(object sender, EventArgs e)
        {
            factoryCircle = new Factory.ConcreteFactoryCircle();
            factoryRectangle = new Factory.ConcreteFactoryRectangle();
        }

        private void DrawLine(Factory.IAbstractFactory factory)
        {
            Brush.IBrush brush = factory.CreateBrush();
            brush.SetGraph(g);
            brush.SetColor(currentColor);
            brush.SetSize(size);
            brush.Draw(g, prevPoint, currentPoint);
        }

        private void DrawBox_MouseDown(object sender, MouseEventArgs e)
        {
            ispressed = true;
            var parent = this.MdiParent as MainWindow;
            currentColor = parent.CurrentColor();
            size = parent.CurrentSize();
            currentPoint = e.Location;
        }

        private void DrawBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (ispressed)
            {
                prevPoint = currentPoint;
                currentPoint = e.Location;
                switch (drawType)
                {
                    case "Circle":
                        DrawLine(factoryCircle);
                        break;
                    case "Rectangle":
                        DrawLine(factoryRectangle);
                        break;
                }
            }
        }

        private void DrawBox_MouseUp(object sender, MouseEventArgs e)
        {
            ispressed = false;
        }

        private void labelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void DrawBox_Click(object sender, EventArgs e)
        {

        }
    }
}
