using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class Form1 : Form
    {
        public Bitmap bmap;
        public Graphics graphics;
        private Fabric shapeCreator;

        public Form1()
        {
            InitializeComponent();
            bmap = new Bitmap(PictureBox.Size.Width, PictureBox.Size.Height);
            graphics = Graphics.FromImage(bmap);
        }

        private void DrawAllBtn_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle();
            Ellipse ellipse = new Ellipse();
            Line line = new Line();
            Square square = new Square();
            Rectangle rectangle = new Rectangle();
            ShapeList shapeList = new ShapeList();
            shapeList.myList.Add(line);
            shapeList.myList.Add(square);
            shapeList.myList.Add(rectangle);
            shapeList.myList.Add(ellipse);
            shapeList.myList.Add(circle);
            shapeList.Draw(graphics);
            PictureBox.Image = bmap;
        }

        ShapeList shapeList = new ShapeList();

        Color penColor = Color.Black;
        Pen pen = new Pen(Color.Black, 2);

        public bool isClicked = false;

        Point X;
        Point Y;
        Shape shape;

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (shapeCreator != null)
            {
                shape = shapeCreator.Create();
                pen = new Pen(penColor, 2);
                shape.Pen = pen;
                isClicked = true;
                X = new Point(e.X, e.Y);
            }
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isClicked = false;
            if (shape != null)
            {
                shapeList.myList.Add(shape);
            }
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isClicked)
            {
                Y = new Point(e.X, e.Y);
                PictureBox.Invalidate();
            }
        }

        public void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (shape != null)
            {
                shape.StartPoint = X;
                shape.FinishPoint = Y;
                pen = new Pen(penColor, 2);
                shape.Draw(e.Graphics, shape.Pen, shape.StartPoint, shape.FinishPoint);
                if (shapeList.myList.Count > 0)
                {
                    foreach (var fig in shapeList.myList)
                    {
                        fig.Draw(e.Graphics, fig.Pen, fig.StartPoint, fig.FinishPoint);
                    }
                }
            }
        }

        private void Line_CheckedChanged(object sender, EventArgs e)
        {
            shapeCreator = new LineFabric();
        }

        private void Rectangle_CheckedChanged(object sender, EventArgs e)
        {
            shapeCreator = new RectangleFabric();
        }

        private void Square_CheckedChanged(object sender, EventArgs e)
        {
            shapeCreator = new SquareFabric();
        }

        private void Ellipse_CheckedChanged(object sender, EventArgs e)
        {
            shapeCreator = new EllipseFabric();
        }

        private void Circle_CheckedChanged(object sender, EventArgs e)
        {
            shapeCreator = new CircleFabric();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            shapeList.myList.Clear();
            PictureBox.Image = null;
        }

        private void Triangle_CheckedChanged(object sender, EventArgs e)
        {
            shapeCreator = new TriangleFabric();
        }
    }
}
