using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ovning_11_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Circle1 left_circle = new Circle1(50, 50, 200, 230);

            Circle1 right_circle = new Circle1(200, 50, 500, 200);

            SolidBrush left_brush = new SolidBrush(Color.Red);
            SolidBrush right_brush = new SolidBrush(Color.Blue);

            g.FillEllipse(left_brush, left_circle.rect);
            g.FillEllipse(right_brush, right_circle.rect);




        }


    }
}
