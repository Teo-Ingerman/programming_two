using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ovning_8_1
{
    public partial class Form1 : Form
    {

        int computer_number;
        int guess_count;

        public Form1()
        {
            InitializeComponent();


            lb1.Items.Add(10);
            lb1.Items.Add(20);
            lb1.SelectedItem = lb1.Items[0];
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


         // button that starts the game
        private void button1_Click(object sender, EventArgs e)
        {
            // Skapa datorns tal genom att hämta det största talet från 
            // listrutan, översätt det till ett heltal och skapa ett
            // slumptal som ligger i intervallet 1 till det största talet.
            string largest_number = lb1.SelectedItem.ToString(); 
            int largest = int.Parse(largest_number);
            Random rnd = new Random();
            computer_number = rnd.Next(1, largest + 1);
            // Avaktivera knappen btnStarta spelet och grupprutan gbxSpeldata. // Aktivera grupprutan gbxSpelet.
            button1.Enabled = false; gb1.Enabled = false; gb2.Enabled = true;
            // Skriv ?? i etiketten lblDatornsTal.
            label4.Text = "??";
            // Sätt instansvariabeln antalGissningar till 0. antalGissningar = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            guess_count++;

            string guess = textBox3.Text;
            int guessed_number;
            try
            {
                guessed_number = int.Parse(guess);
            }
            catch (System.FormatException)
            {
                guessed_number = 0;
            }
            
            if (guessed_number == computer_number)
            {
                label5.Text = $"Korrekt efter {guess_count} försök.";
                gb2.Enabled = false;
                button2.Enabled = true;

                label4.Text = computer_number.ToString();

                // \n doesn't work dont know why
                 textBox2.AppendText($"{guess_count} försök\n");
                textBox2.AppendText(Environment.NewLine);
                //textBox2.Text = $"{guess_count} försök";
            }

            else if (guessed_number < computer_number)
            {
                label5.Text = "För lågt. Försök igen.";
            }

            else
            {
                label5.Text = "För högt. Försök igen.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string largest_number = lb1.SelectedItem.ToString();
            int largest = int.Parse(largest_number);
            Random rnd = new Random();
            computer_number = rnd.Next(1, largest + 1);
            // Avaktivera knappen btnStarta spelet och grupprutan gbxSpeldata. 
            // Aktivera grupprutan gbxSpelet.
            button1.Enabled = false; gb1.Enabled = false; gb2.Enabled = true;
            // Skriv ?? i etiketten lblDatornsTal.
            label4.Text = "??";
            guess_count = 0;
            textBox3.Text = "";
        }
    }
}
