using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab05
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public int x, y;

        private Factory.IAbstractFactory factoryCircle;
        private Factory.IAbstractFactory factoryRectangle;
        public Color currentColor = Color.Black;
        public int size = 5;
        
        public Color CurrentColor()
        {
            return currentColor;
        }

        public int CurrentSize()
        {
            return size;
        }

        private void RectangleMenuItem_Click(object sender, EventArgs e)
        {
            InitCanvas(factoryRectangle);
        }

        private void CircleMenuItem_Click(object sender, EventArgs e)
        {
            InitCanvas(factoryCircle);
        }

        private void InitCanvas(Factory.IAbstractFactory factory)
        {
            Canvas.ICanvas canvas = factory.CreateCanvas();
            DrawWindow dw = new DrawWindow();
            dw.drawType = canvas.GetCanvasType();
            dw.DrawBox = canvas.SetDrawBox(dw.DrawBox);
            dw.MdiParent = this;
            dw.Show();
        }

        private void ButtonColor_Click(object sender, EventArgs e)
        {
            DialogResult D = ColorPickerDialog.ShowDialog();
            if (D == System.Windows.Forms.DialogResult.OK)
            {
                currentColor = ColorPickerDialog.Color;
                ButtonColor.BackColor = currentColor;
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            SizeBar.Value = size;
            ButtonColor.BackColor = currentColor;
            factoryCircle = new Factory.ConcreteFactoryCircle();
            factoryRectangle = new Factory.ConcreteFactoryRectangle();
        }

        private void SizeBar_ValueChanged(object sender, EventArgs e)
        {
            size = SizeBar.Value;
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox tb = new TextBox();
            tb.BorderStyle = BorderStyle.None;
            tb.Multiline = true;
            tb.Text = "text";

            Adapter textBox = new Adapter();
            textBox.text = tb;
            textBox.text.MouseMove += textBox1_MouseMove;
            textBox.text.MouseDown += textBox1_MouseDown;
            textBox.text.TextChanged += textBox.TextChange;


            Point pos = new Point(30, 32);
            tb.Location = pos;
            this.Controls.Add(tb);
            tb.BringToFront();
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point pos = new Point();
                pos = new Point(Cursor.Position.X - x, Cursor.Position.Y - y);
                ((TextBox)sender).Location = PointToClient(pos);
            }
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }
    }

    public abstract class UserText
    {
        public TextBox text;
        public abstract void MouseD(object sender, MouseEventArgs e);
        public abstract void MouseM(object sender, MouseEventArgs e);
        public abstract void TextChange(object sender, EventArgs e);
    }

    public class Adapter : UserText
    {
        private Adaptee adaptee = new Adaptee();
        public override void MouseD(object sender, MouseEventArgs e)
        {
            adaptee.SpecificMouseDown(e);
        }

        public override void MouseM(object sender, MouseEventArgs e)
        {
            text = adaptee.SpecificMouseMove(e, text);
        }

        public override void TextChange(object sender, EventArgs e)
        {
            text = adaptee.SpecificTextChange(e, (TextBox)sender);
        }

    }

    public class Adaptee
    {
        int x = 0;
        int y = 0;
        public void SpecificMouseDown(MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        public TextBox SpecificMouseMove(MouseEventArgs e, TextBox text)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point pos = new Point();
                pos = new Point(Cursor.Position.X - 110, Cursor.Position.Y - 190);
                text.Location = pos;
                return text;
            }
            else return text;
        }

        public TextBox SpecificTextChange(EventArgs e, TextBox text)
        {
            int textWidth = TextRenderer.MeasureText(text.Text, text.Font).Width;
            int textHeight = TextRenderer.MeasureText(text.Text, text.Font).Height;

            text.Width = textWidth;
            if (textWidth != 0)
            {
                int lines = textWidth / text.Width;
                if (textWidth % text.Width != 0)
                    lines++;

                text.Height = textHeight * lines + 7;
            }
            return text;
        }

        public void Enter(KeyEventArgs e, TabPage tp)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tp.Focus();
            }
        }
    }
}
