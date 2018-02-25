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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            CRectangle rectangle1 = new CRectangle(new Point(10, 10), new Point(200, 100), Color.Gold, 3);
            rectangle1.Draw(PictureBox);

            CLine line1 = new CLine(new Point(10, 150), new Point(200, 150), Color.Gold, 3);
            line1.Draw(PictureBox);

            CEllipse ellipse1 = new CEllipse(new Point(10, 200), new Point(200, 290), Color.Gold, 3);
            ellipse1.Draw(PictureBox);

            CArc arc1 = new CArc(new Point(10,300), new Point(150, 390), Color.Gold, 3);
            arc1.Draw(PictureBox);

            CTriangle triangle1 = new CTriangle(new Point(400, 10), new Point(400, 100), new Point(500, 100), Color.Gold, 3);
            triangle1.Draw(PictureBox);

            CQuadrangle quadrangle1 = new CQuadrangle(new Point(400, 200), new Point(600, 200), new Point(700, 300), new Point(300, 300), Color.Gold, 3);
            quadrangle1.Draw(PictureBox);
             
        }
    }
}
