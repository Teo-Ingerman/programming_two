using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning_3_tid_over
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kens = {"jag", "heter", "Ken!"};

            foreach (string ken in kens)
            {
                Console.Write($"{ken} ");
            }

            int[,] numbers = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            numbers[0,2] = 1;
        }
    }
}
