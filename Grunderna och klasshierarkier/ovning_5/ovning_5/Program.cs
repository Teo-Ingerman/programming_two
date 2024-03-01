using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;

            char is_student;

            double discount = 1;
            List<string> discounts = new List<string>();



            Console.Write("age: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("är du student(y/n)? ");
            is_student = char.Parse(Console.ReadLine());

            if (is_student == 'n')
            {
                discount = discount * 0.8;
                discounts.Add("student");
            }

            
            if (age < 18)
            {
                discount = discount * 0.8;
                discounts.Add("ungdom");


            }
            if (age > 65)
            {
                discount = discount * 0.8;
                discounts.Add("pensionär");

            }

            int total_discount = (int)((1 - discount) * 100);

            Console.Write("you are eligible for ");
            foreach (string item in discounts)
            {
                Console.Write($"{item} ");
            }
            Console.Write("\n");
            Console.WriteLine($"total discount: {total_discount}%");
            

        }
    }
}
