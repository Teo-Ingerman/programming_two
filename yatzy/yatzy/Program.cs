using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace yatzy
{
    internal class Program
    {


        static List<int> dice_roller()
        {
            Random rand_val = new Random();


            List<int> dice = new List<int>();


            foreach (int i in Enumerable.Range(0, 5))
            {
                int die = rand_val.Next(1, 7);
                dice.Add(die);
            }


            Console.Write("dice rolled: ");

            foreach (int die in dice)
            {
                Console.Write($"{die} ");
            }
            Console.Write("\n");

            while (true)
            {
                Console.Write("do you want to reroll (y/n)? ");
                char answer = Convert.ToChar(Console.ReadLine());
                if (answer == 'n')
                {
                    Console.Clear();
                    return dice;
                }
                else if (answer == 'y')
                {
                    break;
                }
                Console.Clear();

            }

            Console.Write("Which die do you want to reroll?\n(answer with numbers separeted by spaces): ");
            string reroll_die = Console.ReadLine();

            List<string> result = reroll_die.Split(' ').ToList();


            List<int> index_to_change = new List<int>();

            for (int i = 0; i < result.Count(); i++)
            {
                int new_die = Convert.ToInt32(result[i]);

                int index = dice.IndexOf(new_die);

                index_to_change.Add(index);
            }

            foreach (int i in index_to_change)
            {
                dice[i] = rand_val.Next(1, 7);
            }


            foreach (int die in dice)
            {
                Console.Write($"{die} ");
            }
            Console.Write("\n");

            while (true)
            {
                Console.Write("do you want to reroll (y/n)? ");
                char answer = Convert.ToChar(Console.ReadLine());
                if (answer == 'n')
                {
                    Console.Clear();
                    return dice;
                }
                else if (answer == 'y')
                {
                    break;
                }
                Console.Clear();

            }
            Console.Write("Which die do you want to reroll?\n(answer with numbers separeted by spaces): ");
            string reroll_die2 = Console.ReadLine();

            List<string> result_2 = reroll_die2.Split(' ').ToList();


            List<int> index_to_change_2 = new List<int>();

            for (int i = 0; i < result_2.Count(); i++)
            {
                int new_die = Convert.ToInt32(result_2[i]);

                int index = dice.IndexOf(new_die);

                index_to_change_2.Add(index);
            }

            foreach (int i in index_to_change_2)
            {
                dice[i] = rand_val.Next(1, 7);
            }

            Console.Clear();
            return dice;


        }


        static void Main(string[] args)
        {
            List<int> dice = dice_roller();




            Console.Write("dice: ");
            foreach (int die in dice)
            {
                Console.Write($"{die} ");
            }
            Console.Write("\n");



            // Check if all values are the same
            bool is_same = true;

            for (int i = 0; i < dice.Count(); i++)
            {
                if (dice[i] != dice[0])
                {
                    is_same = false;
                    break;
                }
            }
            

            if (is_same)
            {
                Console.WriteLine("same");
            }
            else
            {
                Console.WriteLine("not same");
                Console.WriteLine("failure");
            }


        }
    }
}
