﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MyPaint
{
    class Ellipse: Shape
    {
        public override void Draw(Graphics g, Pen pen, Point StartPoint, Point FinishPoint)
        {
            int height = FinishPoint.Y - StartPoint.Y;
            int width = FinishPoint.X - StartPoint.X;
            g.DrawEllipse(pen, StartPoint.X, StartPoint.Y, width, height);
        }
    }
}
