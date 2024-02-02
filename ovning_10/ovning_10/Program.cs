using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning_10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person_1 = new Person("Sam", "Sam", 1, "sam");
            Person person_2 = new Person("Steven", "Bam", -1, "Sam Sam");

            string p1_sum = person_1.summary();
            string p2_sum = person_2.summary();

            Console.WriteLine(p1_sum);
            Console.WriteLine(p2_sum);
        }
    }
    class Person
    {
        public string first_name;
        public string last_name;
        public int age;
        public string interest;

        public Person(string f_name, string l_name, int years, string interesse)
        {
            first_name = f_name; 
            last_name = l_name; 
            age = years; 
            interest = interesse;
        }
        public string summary()
        {

            return $"My name is {first_name} {last_name}, I'm {age} years old and I like {interest}";
        }
    }



}
