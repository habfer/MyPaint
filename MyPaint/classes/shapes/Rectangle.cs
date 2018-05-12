using System;
using System.Drawing;

namespace MyPaint
{
    class Rectangle: Shape
    {
        public override void Draw(Graphics g, Pen pen, Point StartPoint, Point FinishPoint)
        {
            int height = Math.Abs(FinishPoint.Y - StartPoint.Y);
            int width = Math.Abs(FinishPoint.X - StartPoint.X);
            if (FinishPoint.Y < StartPoint.Y)
            {
                StartPoint = new Point(StartPoint.X, FinishPoint.Y);
            }
            if (FinishPoint.X < StartPoint.X)
            {
                StartPoint = new Point(FinishPoint.X, StartPoint.Y);
            }
            g.DrawRectangle(pen, StartPoint.X, StartPoint.Y, width, height);
        }
    }
}
