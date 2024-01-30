using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value_1 = 4.5;
            double value_2 = 4.5;

            double value_3 = value_1 * value_2;
            Console.WriteLine(value_3);

            int value_4 = Math.Max(5, 10);

            Console.WriteLine(value_4);

            double value_5 = Math.Max(value_1, value_2);

            Console.WriteLine(value_5);


            Console.WriteLine();

            int circle_radius = 5;

            double cirlce_area;


            cirlce_area = Math.PI * Math.Pow(circle_radius, 2);

            Console.WriteLine($"area: {cirlce_area}");
        
        }
    }
}
