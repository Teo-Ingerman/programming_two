using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppgift_8_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int x_coord = 180;

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            SolidBrush brush = new SolidBrush(Color.FromArgb(0, 0, 0));

            g.FillRectangle(brush, x_coord, 165, 170, 80);
        }

        private void button_right_Click(object sender, EventArgs e)
        {
            x_coord += 5;
            Invalidate();
        }

        private void button_left_Click(object sender, EventArgs e)
        {
            x_coord -= 5;
            Invalidate();
        }
    }
}
