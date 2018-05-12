using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MyPaint
{
    class Circle: Shape
    {
        public override void Draw(Graphics g, Pen pen, Point StartPoint, Point FinishPoint)
        {
            int height = 0;
            int width = FinishPoint.X - StartPoint.X;
            if (((width > 0) && (FinishPoint.Y < StartPoint.Y)) || ((width < 0) && (FinishPoint.Y > StartPoint.Y)))
            {
                height = -width;
            }
            else
            {
                height = width;
            }
            g.DrawEllipse(pen, StartPoint.X, StartPoint.Y, width, height);
        }
    }
}
