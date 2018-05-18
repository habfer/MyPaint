using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyPaint
{
    class Triangle: Shape
    {
        public override void Draw(Graphics g, Pen pen, Point StartPoint, Point FinishPoint)
        {
            Point MidPoint = new Point(StartPoint.X + 200, StartPoint.Y);
            Point[] curvePoints =
            {
                 StartPoint,
                 MidPoint,
                 FinishPoint,
            };
            g.DrawPolygon(pen, curvePoints);
        }
    }
}
