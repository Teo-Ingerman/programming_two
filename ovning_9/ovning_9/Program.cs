using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning_9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(nice_word_finder('p'));
                    
        }
    
           
        static double degree_converter(double degree, char system_from  )
        {
            double new_degree = 0;

            if (system_from == 'F')
            {
                new_degree = (degree-32)*(5/9);
            }
            if (system_from == 'C')
            {
                new_degree = (degree * (9/5)) - 32;
            }
            return new_degree;
        }

        

        static string nice_word_finder(char letter)
        {
            string nice_word;

            Random rnd = new Random();

            List<string> word_list = new List<string>();

            String line;
            try
            {
                StreamReader sr = new StreamReader("nice_words.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    word_list.Add(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

            string[] resultWords = word_list.Where(word => word.StartsWith(letter.ToString(), StringComparison.OrdinalIgnoreCase)).ToArray();

            int word_index = rnd.Next(0, resultWords.Count() - 1);

            nice_word = resultWords[word_index];

            return nice_word;

        }


    
    }
}
