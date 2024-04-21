using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_menyer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnfärg_Click(object sender, EventArgs e)
        {
            DialogResult r = dlgcolor.ShowDialog();
            if (r == DialogResult.OK)
            {
                btnfärg.BackColor = dlgcolor.Color;
            }
        }

        private void btnteckensnitt_Click(object sender, EventArgs e)
        {
            DialogResult r = fontDialog1.ShowDialog();
            if (r == DialogResult.OK)
            {
                btnteckensnitt.Font = fontDialog1.Font;
            }
        }
        private void btnsökväg_Click(object sender, EventArgs e)
        {

            DialogResult r = folderBrowserDialog1.ShowDialog();
            if (r == DialogResult.OK)
            {
                btnsökväg.Text = folderBrowserDialog1.SelectedPath;
            }



        }
    }
}
