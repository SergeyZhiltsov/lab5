using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace lab05
{
    class Move : TextBox
    {
        //точка перемещения
        Point DownPoint;
        //нажата ли кнопка мыши
        bool IsDragMode;

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            DownPoint = mevent.Location;
            IsDragMode = true;
            base.OnMouseDown(mevent);
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            IsDragMode = false;
            base.OnMouseUp(mevent);
        }

        protected override void OnMouseMove(MouseEventArgs mevent)
        {
            //если кнопка мыши нажата
            if (IsDragMode)
            {
                Point p = mevent.Location;
                //вычисляем разницу в координатах между положением курсора и "нулевой" точкой кнопки
                Point dp = new Point(p.X - DownPoint.X, p.Y - DownPoint.Y);
                Location = new Point(Location.X + dp.X, Location.Y + dp.Y);
            }
            base.OnMouseMove(mevent);
        }
    }
}
