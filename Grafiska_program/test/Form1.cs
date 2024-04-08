using System;
using System.Drawing;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        private bool isDrawing = false;     // En flagga som indikerar om användaren är i färd med att rita eller inte.
        private Point previousPoint;        // Håller koll på den tidigare muspositionen för att rita linjer.

        // Deklarera en bitmap för att lagra ritområdet
        private Bitmap drawingSurface = new Bitmap(800, 600);
        private Color pen_color = Color.Black;

        public Form1()
        {
            InitializeComponent();

            // Kör metoden för att skapa ett ritområdet genom att rensa det till vit färg
            InitializeDrawingSurface();
        }

        // Metod för att skapa ett ritområde genom att rensa det till transparens.
        private void InitializeDrawingSurface()
        {
            using (Graphics g = Graphics.FromImage(drawingSurface))
            {
                g.Clear(Color.Transparent);
            }
        }

        // Händelsehanterare som aktiveras när användaren klickar ned musknappen för att börja rita.
        private void pxbPapper_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;                   // Användaren har börjat rita                
            previousPoint = e.Location;         // Sparar positionen där muspekaren befann sig när ritningen påbörjades i previousPoint 
        }

        // Händelsehanterare som aktiveras när användaren rör musen och ritningen pågår.
        private void pxbPapper_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics g = Graphics.FromImage(drawingSurface))
                {
                    // Skapa en penna med svart färg och tjocklek 4
                    Pen pen = new Pen(pen_color, 5);

                    // Rita en linje från föregående musposition till nuvarande musposition med den svarta pennan
                    g.DrawLine(pen, previousPoint, e.Location);
                }
                previousPoint = e.Location;

                // Uppdatera PictureBox för att visa de ändringar som gjorts på ritområdet
                pxbPapper.Invalidate();
            }
        }

        // Händelsehanterare som aktiveras när användaren släpper musknappen.
        private void pxbPapper_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;          // Användaren har slutat rita och släppt musknappen
        }

        private void pxbPapper_Paint(object sender, PaintEventArgs e)
        {
            // Rita ritområdet på PictureBox
            e.Graphics.DrawImage(drawingSurface, Point.Empty);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pen_color_button_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                pen_color_button.BackColor = c.Color;
                pen_color = c.Color;
            }
        }
        private void background_color_button_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                background_color_button.BackColor = c.Color;
                panel1.BackColor = c.Color;

            }
        }
    }
}


