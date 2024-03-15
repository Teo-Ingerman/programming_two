using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yatzy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] dice = { 1, 2, 3, 4, 5, 6 };



        }
    
    static List<(string, int)> point_check(int[] die)
        {
            List<(string, int)> possible_scores = new List<(string, int)>();

            int distinct_die = die.Distinct().Count();

            // separate numbers check

            foreach (int numbers in die)
            {

            } 


            // yatzy check
            if (distinct_die == 1)
            {
                possible_scores.Add(("yatzy", 50));
            }

            // fours
            if (distinct_die == 2 & )


            return possible_scores;
        } 
    
    }
}
