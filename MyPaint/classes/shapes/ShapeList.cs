using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyPaint
{ 
    public class ShapeList
    {
        public List<Shape> myList = new List<Shape> { };
        Pen pen = new Pen(Color.Black, 3);
        int y1 = 10;
        int y2 = 50;

        public void Draw(Graphics g)
        {
            foreach (Shape myDraw in myList)
            {
                myDraw.Draw(g, pen, new Point(20, y1), new Point(80, y2));
                y1 += 70;
                y2 += 70;
            }
        }
    }
}
