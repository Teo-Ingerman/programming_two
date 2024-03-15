using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning_11_2
{
    internal class Circle
    {
        public Rectangle rect;
        public Color color;


        public Circle(int x, int y, int side_lenght, Color color)
        {
            this.rect = new Rectangle(x, y, side_lenght, side_lenght);
            this.color = color;
        }



    }
}
