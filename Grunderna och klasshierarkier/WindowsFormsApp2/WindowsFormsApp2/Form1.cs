using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("first progeligraM", "Meddelande",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            button1.Cursor = Cursors.No;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            progressBar1.Step = 1;
            button1.Location = new Point(rnd.Next(300, 1500), rnd.Next(300, 800));
            progressBar1.PerformStep();

        }

    }
}
