using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace test_2
{
    public partial class Form1 : Form
    {
        private bool drawing;
        private Point previousPoint;
        private List<Point> pointsList;
        private Pen drawingPen;

        public Form1()
        {
            InitializeComponent();
            drawing = false;
            pointsList = new List<Point>();
            drawingPen = new Pen(Color.Black, 2); // Change color and width as needed
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drawing = true;
            previousPoint = e.Location;
            pointsList.Add(previousPoint);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                using (Graphics g = panel1.CreateGraphics())
                {
                    g.DrawLine(drawingPen, previousPoint, e.Location);
                    previousPoint = e.Location;
                    pointsList.Add(previousPoint);
                }
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
            SmoothDrawCurve();
            pointsList.Clear();
        }

        private void SmoothDrawCurve()
        {
            if (pointsList.Count < 3)
                return;

            using (Graphics g = panel1.CreateGraphics())
            {
                for (int i = 0; i < pointsList.Count - 2; i++)
                {
                    Point p0 = pointsList[i];
                    Point p1 = pointsList[i + 1];
                    Point p2 = pointsList[i + 2];

                    Point midPoint1 = new Point((p0.X + p1.X) / 2, (p0.Y + p1.Y) / 2);
                    Point midPoint2 = new Point((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);

                    g.DrawBezier(drawingPen, p0, midPoint1, midPoint2, p2);
                }
            }
        }

        // Clear the drawing panel
        private void ClearButton_Click(object sender, EventArgs e)
        {
            using (Graphics g = panel1.CreateGraphics())
            {
                g.Clear(panel1.BackColor);
            }
        }
    }
}
