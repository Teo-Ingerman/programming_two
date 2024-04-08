using System;
using System.Drawing;
using System.Windows.Forms;

namespace paint_program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeDrawingSurface();
        }
        private Color pen_color = Color.Black;
        private float pen_thickness;
        // bool for checking if drawing or not
        private bool drawing = false;
        private Bitmap drawing_surface = new Bitmap(679, 426);
        private Point previous_point;

        private void InitializeDrawingSurface()
        {
            using (Graphics g = Graphics.FromImage(drawing_surface))
            {
                g.Clear(Color.Transparent);
            }
        }

        // Changes the pen color to the selected color
        private void button1_Click_1(object sender, EventArgs e)
        {

            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                pen_color_button.BackColor = c.Color;
                pen_color = c.Color;
            }
        }

        // Changes the background to a selcted color
        private void background_color_button_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                background_color_button.BackColor = c.Color;
                panel1.BackColor = c.Color;
                
            }
        }

        // Changes the background to a selected image
        private void background_image_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                string file_path = f.FileName;
                panel1.BackgroundImageLayout = ImageLayout.Stretch;
                panel1.BackgroundImage = Image.FromFile(file_path);
            }
        }

        private void panel_mouse_move(object sender, MouseEventArgs e)
        {
            drawing = true;
            previous_point = e.Location;
        }

        private void panel_mouse_down(object sender, MouseEventArgs e)
        {
            if  (drawing)
            {
                using (Graphics g = Graphics.FromImage(drawing_surface))
                {
                    // Skapa en penna med svart färg och tjocklek 4
                    pen_thickness = Convert.ToInt32(pen_size_combo_box.Text);
                    Pen pen = new Pen(Color.Black, 4);

                    // Rita en linje från föregående musposition till nuvarande musposition med den svarta pennan
                    g.DrawLine(pen, previous_point, e.Location);
                }
                previous_point = e.Location;

                // Uppdatera PictureBox för att visa de ändringar som gjorts på ritområdet
                panel1.Invalidate();
            }
        }

        private void panel_mouse_up(object sender, MouseEventArgs e)
        {
            drawing = false;
        }

        private void panel_paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(drawing_surface, Point.Empty);
        }
    }
}
