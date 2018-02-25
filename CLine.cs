using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MyPaint
{
    class CLine : Figure
    {

        public Point topLeft, bottomRight;

        public CLine(Point topLeft, Point bottomRight, Color color, float penWidth)
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
            g.DrawLine(myPen, topLeft, bottomRight);

        }


    }
}
