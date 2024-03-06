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

namespace ovning_7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cost_output.Text = $"your travel will cost 10 Kr";
        }
        private void Tmr2_Tick(object sender, EventArgs e)  //run this logic each timer tick
        {
            
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cost_output_Click(object sender, EventArgs e)
        {
            
        }

        private void age_input_TextChanged(object sender, EventArgs e)
        {
            int age = 0;
            if (age_input.Text != "")
            {
                age = Convert.ToInt32(age_input.Text);
            }
            if (age > 14 & age < 66)
            {
                cost_output.Text = $"your travel will cost 20 Kr";
            }
            else
            {
                cost_output.Text = $"your travel will cost 10 Kr";
            }
            cost_output.Update();
        }
    }
}
