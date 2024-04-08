using System;
using System.Drawing;
using System.Windows.Forms;

namespace ovning_11_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int x = 300;
        public int y = 300;
        public int side_length = 100;

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Circle circle = new Circle(x, y, side_length, Color.Yellow);

            Pen circle_pen = new Pen(circle.color);

            SolidBrush cirlce_brush = new SolidBrush(circle.color);

            g.FillEllipse(cirlce_brush, circle.rect);
            g.DrawEllipse(circle_pen, circle.rect);

            foreach ()
            {

            }



        }

        private void button1_Click(object sender, EventArgs e)
        {

            Invalidate();

            int diameter;
            try
            {
                diameter = Convert.ToInt32(textBox1.Text);
            }
            catch (System.FormatException)
            {
                diameter = 100;
            }

            int diameter_part = Convert.ToInt32(diameter / 5);
            diameter = diameter_part * 5;

            for (int i = diameter; i < 5; i++)
            {
                Invalidate();
                x = x - diameter;
                y = y - diameter;
                side_length = i * diameter_part;


            }
        }
    }
}
