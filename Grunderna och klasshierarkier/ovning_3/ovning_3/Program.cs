using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] whole_numbers = { 1, 2, 3, 4, 5 };

            Console.Write("whole numbers: ");

            foreach (int number in whole_numbers)
            {
                Console.Write($"{number}, ");
            }

            int total = 0;
            Console.Write("\ntotal: ");
            foreach (int number in whole_numbers)
            {
                total += number;
            }
            
            Console.Write($"{total}\n");
            

            for (int i = 0; i < whole_numbers.Length; i++)
            {
                whole_numbers[i] = whole_numbers[i]*2;
            }

            Console.Write("whole numbers (doubled): ");


            foreach (int number in whole_numbers)
            {
                Console.Write($"{number}, ");
            }

            Console.Write("\n");
        }
    }
}
