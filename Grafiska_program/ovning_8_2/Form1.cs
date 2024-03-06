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

        public int red = 0;
        public int green = 0;
        public int blue = 0;


        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            SolidBrush brush = new SolidBrush(Color.FromArgb(red, green, blue));

            g.FillRectangle(brush, 180, 165, 340, 80);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            red = rnd.Next(0, 256);
            blue = rnd.Next(0, 256);
            green = rnd.Next(0, 256);

            textBox1.Text = red.ToString();
            textBox2.Text = blue.ToString();
            textBox3.Text = green.ToString();


            Invalidate();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            red = text_change(textBox1.Text);

            Invalidate();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            green = text_change(textBox2.Text);

            Invalidate();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            blue = text_change(textBox3.Text);
           
            Invalidate();
        }

        public int  text_change(string text)
        {
            int output;
            try
            {
                int new_val = Convert.ToInt32(text);

                if (new_val > 255)
                {
                    output = 255;
                }
                else if (new_val < 0)
                {
                    output = 0;
                }
                else
                {
                    output = new_val;
                }
            }
            catch (System.FormatException)
            {
                output = 0;
            }
            return output;
        }


    }
}
