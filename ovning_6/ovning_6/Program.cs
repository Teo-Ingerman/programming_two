using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning_6
{
    internal class Program
    {

        static void print(string message, bool new_line=true)
        {
            if (new_line)
            {
                Console.WriteLine(message);
                return;
            }

            Console.Write($"{message}");
        }


        static void Main(string[] args)
        {
            // uppgift 1
            int counter = 0;
            int goal = 2;

            while (counter < goal)
            {
                counter++;
                Console.WriteLine("Goal not reached");
            }
            Console.WriteLine("Goal reached");


            Console.Clear();


            // uppgift 2

            List<string> email_adresses = new List<string> {("ben.shapiro@dailywire.com"), ("reza.korvar@nfi.se"), ("teo.jazz@tuba.com") };

            string search_word = "hap";

            foreach (string email in email_adresses)
            {
                if (email.Contains(search_word)) {
                    Console.WriteLine(email);
                }
            }

            // uppgift 3

            Random rnd = new Random();

            bool cars_coming = true;
            int car_amount;

            while (cars_coming)
            {
                car_amount = rnd.Next(0,50);
                print($"{car_amount} cars are coming!");

                if (car_amount != 0)
                {
                    
                    print("AI can't pass");
                }
                else
                {
                    cars_coming = false;
                    print("AI can pass");
                }


            }
        }
    }
}
