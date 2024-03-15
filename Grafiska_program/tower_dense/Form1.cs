using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tower_dense
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public Color enemy_color = Color.Red;
        public int enemy_x = 0;
        public int enemy_y = 100;


        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            SolidBrush track_brush = new SolidBrush(Color.FromArgb(0, 0, 0));

            SolidBrush enemy_brush = new SolidBrush(enemy_color);

            // track
            g.FillRectangle(track_brush, 0, 100, 200, 40);
            g.FillRectangle(track_brush, 160, 100, 40, 200);
            g.FillRectangle(track_brush, 160, 300, 5000, 40);

            // enemy
            g.FillEllipse(enemy_brush, enemy_x, enemy_y, 40, 40);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {



            (enemy_x, enemy_y) = enemy_position_calc(enemy_x, enemy_y);




            Invalidate();
        }

        public (int, int) enemy_position_calc(int enemy_x, int enemy_y)
        {
            if (enemy_y == 300)
            {
                enemy_x += 1;
            }

            else if (enemy_x == 160)
            {
                enemy_y += 1;
            }
            else
            {
                enemy_x += 1;
            }

            return (enemy_x, enemy_y);
        }

    }
}
