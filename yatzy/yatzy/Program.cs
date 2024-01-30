using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;


namespace yatzy
{
    internal class Program
    {

        static void print(string message)
        {
            Console.WriteLine(message);
        }
        static string input(string message)
        {
            Console.Write(message);
            string user_input = Console.ReadLine();
            return user_input;
        }


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



        static Dictionary<string, int> dice_combos_possible(List<int> dice)
        {



            int distinct_dice = Convert.ToInt32(dice.Distinct<int>());

            Dictionary<string, int> valid_combos = new Dictionary<string, int> { };

            // creating a dictionary for the dice value and the amount for each dice

            Dictionary<int, int> dice_amounts = new Dictionary<int, int>();

            dice_amounts.Add(1, 0);
            dice_amounts.Add(2, 0);
            dice_amounts.Add(3, 0);
            dice_amounts.Add(4, 0);
            dice_amounts.Add(5, 0);
            dice_amounts.Add(6, 0);

            for (int i = 0; i < dice.Count(); i++)
            {
                int new_count = dice_amounts[i] + 1;
                dice_amounts[i] = new_count;
            }

            SortedDictionary<int, int> ordered_amounts = new SortedDictionary<int, int>(dice_amounts);

            Console.WriteLine(ordered_amounts[0]);




            //distinct_dice = distinct_dice.OrderByDescending(x => x).ToList();



            //Dictionary<int, int> dice_vals = new Dictionary<int, int>();

            //for (int i = 0; i < distinct_dice; i++)
            //{
            //    // count of most prevalent value
            //    int dice_count = dice.Where(x => x.Equals(distinct_dice[i]).Count());

            //    dice_vals.Add(i, dice_count);
            //}



            //// count of most prevalent value
            //int dice_count = dice.Where(x => x.Equals(distinct_dice[0])).Count();


            //// value of the most prevalent value added togeher
            //int dice_sum = distinct_dice[0] * dice_count;


            // Check for house where the second most prevalent value is relevant
            //int dice_count_second = dice.Where(x => x.Equals(distinct_dice[0])).Count();

            // value of the most prevalent value added togeher
            //int dice_sum_second = distinct_dice[1] * dice_count_second;
            
            List<int> keyList = new List<string>(dice_amounts);
            // Sum of the most prevalent die
            int dice_sum = dice_amounts[0] * 

            // checking for yatzy
            if (distinct_dice == 1)
            {
                valid_combos.Add("yatzy", 50);
            }

            // checking for house

            if (distinct_dice == 2 & dice_amounts[0] != 4)  
            {
                int dice_sum = dice_vals[distinct_dice[0]] * dice_vals[dice_vals[distinct_dice[0]]];
                int house_sum = dice_sum + dice_sum_second;
                valid_combos.Add("house", house_sum);
            }

            // checking for fours

            if (dice_vals[distinct_dice[0]] >= 4)
            {
                int dice_sum = dice_vals[distinct_dice[0]] * dice_vals[dice_vals[distinct_dice[0]]];
                valid_combos.Add("fours", dice_sum);
            }

            // checking for threes

            if (dice_vals[distinct_dice[0]] >= 3)
            {
                int dice_sum = dice_vals[distinct_dice[0]] * dice_vals[dice_vals[distinct_dice[0]]];
                valid_combos.Add("threes", dice_sum);
            }

            // checking for two pairs

            if (dice_vals[distinct_dice[0]] > 2 & dice_vals[distinct_dice[1]] > 2)
            {
                int dice_sum = dice_vals[dice_vals[distinct_dice[0]]] * 2 + dice_vals[dice_vals[distinct_dice[1]]] * 2;
                valid_combos.Add("two_pairs", x dice_sum);
            }



            // checking for one pair

            if (dice_count == 2)
            {
                valid_combos.Add("pair", dice_sum);
            }

            foreach (int number in distinct_dice)
            {
                int points = number * 
                valid_combos.Add($"{number}", );
            }

            for (int i = 0; i < distinct_dice.Count(); i++)
            {
                int value = distinct_dice[i];
                int points = value * dice.con(value);
                valid_combos.Add($"{number}", );
            }






            // checking for straights
            if (dice_count == 5)
            {
                if (distinct_dice.Contains(1))
                {
                    valid_combos.Add("small_straight", 15);
                }
                else
                {
                    valid_combos.Add("large_straight", 20);

                }


            }


            // adding chance as it's always possible

            valid_combos.Add("chance", dice.Sum());


            // remove duplicates
            // List<string> noDupes = valid_combos.Distinct().ToList();


            return valid_combos;
        }







        [STAThread]
        static void Main(string[] args)
        {
            List<int> dice = dice_roller();

            List<string> valid_combos = dice_combos_possible(dice);


            //Console.Write("dice: ");
            //foreach (int die in dice)
            //{
            //    Console.Write($"{die} ");
            //}
            //Console.Write("\n");



            //// Check if all values are the same
            //bool is_same = true;

            //for (int i = 0; i < dice.Count(); i++)
            //{
            //    if (dice[i] != dice[0])
            //    {
            //        is_same = false;
            //        break;
            //    }
            //}


            //if (is_same)
            //{
            //    Console.WriteLine("same");
            //}
            //else
            //{
            //    Console.WriteLine("not same");
            //    Console.WriteLine("failure");
            //}







        }
    }
}
