using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        // uppgift 1
        static void tv_printout(string name, string sum)
        {
            Console.WriteLine($"{name} har donerat {sum} kronor");
        }

        // tid över
        static void circle_area_calc(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"area is equal to {area}");
            // return area; is probably better 
        }

    }
}
