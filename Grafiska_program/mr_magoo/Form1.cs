using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mr_magoo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int player_x = 200;
        public int player_y = 200;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            SolidBrush player = new SolidBrush(Color.DarkGreen);

            g.FillEllipse(player, player_x, player_y, 30, 30);

        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                player_y -= 10;
            }
            if (e.KeyCode == Keys.S)
            {
                player_y += 10;
            }
            if (e.KeyCode == Keys.A)
            {
                player_x -= 10;
            }
            if (e.KeyCode == Keys.D)
            {
                player_x += 10;
            }
            Invalidate();
        }
    }
}
