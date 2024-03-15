using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ovning_11_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int x;
        public int y;
        public int side_length;

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Circle circle = new Circle(300, 200, 50, Color.Yellow);

            SolidBrush cirlce_brush = new SolidBrush(circle.color);

            g.FillEllipse(cirlce_brush, circle.rect);


        }

        private void button1_Click(object sender, EventArgs e)
        {

            int diameter;
            try
            {
                diameter = Convert.ToInt32(textBox1.Text);
            }
            catch (System.FormatException)
            {
                diameter = 101;
            }

            int diameter_part = Convert.ToInt32(diameter / 5);
                



        }

        //public void 



    }
}
