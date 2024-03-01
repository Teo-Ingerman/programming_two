using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning_4
{
    internal class Program
    {

        static bool password_check(string password)
        {
            
            Console.Write("password: ");
            string input_password = null;
            while (true)
            {
                var key = Console.ReadKey(true);
                Console.Write("*");
                if (key.Key == ConsoleKey.Enter)
                    break;
                input_password += key.KeyChar;
            }
            Console.Write("\n");
            if (input_password == password)
            {
                return true;
            }
            return false;
        }



        static void Main(string[] args)
        {
            
            
            while (true)
            {
                bool permission = password_check("hello");

                if (permission == true)
                {
                    break;
                }
                Console.Clear();
            }


            int age = 10;
            int price;



            if (age < 15)
            {
                price = 15;
            }
            else if (age < 60)
            {
                price = 60;
            }
            else
            {
                price = 30;
            }

            Console.WriteLine($"price: {price}");


        }
    }
}
