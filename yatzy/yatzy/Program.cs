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

        static Dictionary<string, int> possible_dice_combos(int[] dice)
        {
            Dictionary<string, int> dice_combos = new Dictionary<string, int>();

            Dictionary<int, int> dice_counts = new Dictionary<int, int>
            {
                { 1, 0 },
                { 2, 0 },
                { 3, 0 },
                { 4, 0 },
                { 5, 0 },
                { 6, 0 }
            };

            Dictionary<int, int> dice_ordered = new Dictionary<int, int>();

            int[] distinct_dice = dice.Distinct().ToArray();



            foreach (int die in dice)
            {
                dice_counts[die]++;
            }
            foreach (var die in dice_counts)
            {
                print($"{die}");
            }

            print("");
            var sortedDict = (from entry in dice_counts orderby entry.Value descending select entry);

            foreach (var die_count in sortedDict)
            {
                int die = die_count.Key;
                int count = die_count.Value;
                dice_ordered.Add(die, count);
            }

            foreach (var die in dice_ordered)
            {
                print($"{die}");
            }

            // Yatzy

            if (distinct_dice.Count() == 1)
            {
                dice_combos.Add("yatzy", 50);
            }

            if (distinct_dice.Count() == 2)
            {
                dice_combos.Add("fours", 2);
            }




            return dice_combos;
        }


        static void Main(string[] args)
        {
            //int[] dice = dice_roller();

            int[] dice = {1, 1, 1, 1, 3};

            Dictionary<string, int> valid_combos = possible_dice_combos(dice);




        }
    }
}
