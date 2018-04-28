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

        public Form1()
        {
            InitializeComponent();
            bmap = new Bitmap(PictureBox.Size.Width, PictureBox.Size.Height);
            graphics = Graphics.FromImage(bmap);
            graphics.Clear(Color.White);
            PictureBox.Image = bmap;
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
            shapeList.myList.Add(circle);
            shapeList.myList.Add(ellipse);
            shapeList.Draw(graphics);
            PictureBox.Image = bmap;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            PictureBox.Image = bmap;
        }
    }
}
