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
    class CTriangle : Figure
    {
        public Point v1, v2, v3;

        public CTriangle(Point v1, Point v2, Point v3, Color color, float penWidth)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.color = color;
            this.penWidth = penWidth;
        }

        public override void Draw(PictureBox pictureBox)
        {
            Pen myPen = new Pen(color, penWidth);
            Graphics g = Graphics.FromHwnd(pictureBox.Handle);

            Point[] curvePoints = {v1, v2, v3};
            g.DrawPolygon(myPen, curvePoints);
        }

    }
}
