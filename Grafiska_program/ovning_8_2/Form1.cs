using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ovning_8_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Color light_color = Color.Green;
        public int light_height = 165;

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics background = e.Graphics;

            Graphics light = e.Graphics;

            SolidBrush light_brush = new SolidBrush(light_color);

            SolidBrush back_brush = new SolidBrush(Color.FromArgb(0, 0, 0));

            background.FillRectangle(back_brush, 180, 165, 80, 200);

            Rectangle rect = new Rectangle(180, light_height, 80, 80);


            background.FillEllipse(light_brush, rect);


        }

        private void button_Click(object sender, EventArgs e)
        {
            if (light_height == 165)
            {
                light_height = 285;
                light_color = Color.Red;
            }
            else
            {
                light_height = 165;
                light_color = Color.Green;
            }
            Invalidate();
        }
    }
}
