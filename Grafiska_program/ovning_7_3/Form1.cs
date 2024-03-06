using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ovning_7_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int number = rnd.Next(1, 7);

            

            label1.Text = number.ToString();
            if (number == 6)
            {
                MessageBox.Show("Gratis", "Grattis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
