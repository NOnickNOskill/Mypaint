using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace MyPaint
{
    class CArc : Figure
    {
        public Point topLeft, bottomRight;

        public CArc(Point topLeft, Point bottomRight, Color color, float penWidth)
        {
            this.topLeft = topLeft;
            this.bottomRight = bottomRight;
            this.color = color;
            this.penWidth = penWidth;
        }

        public override void Draw(PictureBox pictureBox)
        {
            Pen myPen = new Pen(color, penWidth);
            Graphics g = Graphics.FromHwnd(pictureBox.Handle);

            int width = bottomRight.X - topLeft.X;
            int height = bottomRight.Y - topLeft.Y;
            int startAngle = 90;
            int sweepAngle = 180;
            g.DrawArc(myPen, topLeft.X, topLeft.Y, width, height, startAngle, sweepAngle);
        }
    }
}
