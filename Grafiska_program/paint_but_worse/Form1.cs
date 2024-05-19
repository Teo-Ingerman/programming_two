using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
namespace paint_but_worse
{



    public partial class Form1 : Form
    {
        private bool isDrawing = false;     // En flagga som indikerar om användaren är i färd med att rita eller inte.
        private Point previousPoint;        // Håller koll på den tidigare muspositionen för att rita linjer.

        // Deklarera en bitmap för att lagra ritområdet
        private Bitmap drawingSurface = new Bitmap(576, 426);
        Pen pen;
        Graphics g;
        string tool;
        Point top_left;
        Bitmap image;

        public Form1()
        {
            InitializeComponent();
            g = Graphics.FromImage(drawingSurface);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 15);
            tool = "pen_tool";
            trackBar1.Value = 15;
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            pxbPapper.BackColor = Color.White;
            // Kör metoden för att skapa ett ritområdet genom att rensa det till transparent färg
            InitializeDrawingSurface();
        }

        // Metod för att skapa ett ritområde genom att rensa det till transparent färg.
        private void InitializeDrawingSurface()
        {
            g.Clear(Color.Transparent);
        }

        // Händelsehanterare som aktiveras när användaren klickar ned musknappen för att börja rita.
        private void pxbPapper_MouseDown(object sender, MouseEventArgs e)
        {
            if (tool == "pen_tool")
            {
                isDrawing = true;                   // Användaren har börjat rita                
                previousPoint = e.Location;         // Sparar positionen där muspekaren befann sig när ritningen påbörjades i previousPoint 
            }
            else
            {
                top_left = e.Location;
            }
        }

        // Händelsehanterare som aktiveras när användaren rör musen och ritningen pågår.
        private void pxbPapper_MouseMove(object sender, MouseEventArgs e)
        {


            if (isDrawing)
            {
                using (Graphics g = Graphics.FromImage(drawingSurface))
                {
                    // Rita en linje från föregående musposition till nuvarande musposition med den svarta pennan
                    g.DrawLine(pen, previousPoint, e.Location);
                }
                previousPoint = e.Location;
            }
           
            // Uppdatera PictureBox för att visa de ändringar som gjorts på ritområdet
            pxbPapper.Invalidate();
        }

        // Händelsehanterare som aktiveras när användaren släpper musknappen.

        private void pxbPapper_MouseUp(object sender, MouseEventArgs e)
        {
            Shape shape = new Shape(top_left, e.Location);

            if (tool == "pen_tool")
            {
                isDrawing = false;          // Användaren har slutat rita och släppt musknappen

            }
            else if (tool == "square_tool")
            {
                g.DrawRectangle(pen, shape.rect);
                
            }
            else if (tool == "circle_tool")
            {
                g.DrawEllipse(pen, shape.rect);
            }
            else if (tool == "image_tool")
            {

                g.DrawImage(image, shape.rect);

            }

            pxbPapper.Invalidate();
        }

        private void pxbPapper_Paint(object sender, PaintEventArgs e)
        {
            // Rita ritområdet på PictureBox
            e.Graphics.DrawImage(drawingSurface, Point.Empty);
        }

        private void track_bar_dragged(object sender, System.EventArgs e)
        {
            pen.Width = trackBar1.Value;
        }

        private void pen_color_click(object sender, System.EventArgs e)
        {
            Button p = (Button)sender;
            pen.Color = p.BackColor;
        }

        private void clear_button_Click(object sender, System.EventArgs e)
        {
            g.Clear(Color.Transparent);
            pxbPapper.BackColor = Color.White;
            pxbPapper.Invalidate();
        }

        private void background_color_Click(object sender, System.EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                pxbPapper.BackColor = c.Color;
            }
        }

        private void tool_changed(object sender, System.EventArgs e)
        {
            Button t = (Button)sender;
            tool = t.Name;
        }

        private void save_button_Click(object sender, System.EventArgs e)
        {
            // Skapa en dialogruta för att välja var bilden ska sparas
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG files (*.png)|*.png";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Spara bilden på den valda sökvägen som PNG
                drawingSurface.Save(saveFileDialog.FileName, ImageFormat.Png);
            }

        }

        private void upload_button_Click(object sender, System.EventArgs e)
        {
            // Skapa en dialogruta för att välja en PNG-bild att öppna
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG files (*.png)|*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Läs in den valda PNG-bilden
                Bitmap loadedImage = new Bitmap(openFileDialog.FileName);

                // Skala om bilden till storleken på ritområdet (PictureBox)
                Bitmap scaledImage = new Bitmap(pxbPapper.Width, pxbPapper.Height);

                g.DrawImage(loadedImage, 0, 0, pxbPapper.Width, pxbPapper.Height);
                pxbPapper.Invalidate();

            }
        }

        private void image_tool(object sender, EventArgs e)
        {
            tool = "image_tool";
            // Skapa en dialogruta för att välja en PNG-bild att öppna
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG files (*.png)|*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(openFileDialog.FileName);

            }
        }
    }
    public class Shape
    {
        public Rectangle rect;
        public Shape(Point top_left, Point bottom_right)
        {

            rect = new Rectangle(top_left.X, top_left.Y, (bottom_right.X - top_left.X), (bottom_right.Y - top_left.Y));


        }
    }
}
