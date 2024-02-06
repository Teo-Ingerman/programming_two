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




            int[] distinct_dice = dice.Distinct().ToArray();


            foreach (int die in dice)
            {
                dice_counts[die]++;
            }

            // Yatzy

            if (distinct_dice.Count() == 1)
            {
                dice_combos.Add("yatzy", 50);
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
