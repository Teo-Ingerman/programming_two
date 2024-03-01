using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car jeff = new Car(60, 48, 0.1);

            Console.WriteLine(jeff.fuel_situation());
        }
    }
    class Car
    {
        public int tank_size;
        public int fuel;
        public double fuel_usage;



        public Car(int tank_size, int fuel, double fuel_usage)
        {
            this.tank_size = tank_size;
            this.fuel = fuel;
            this.fuel_usage = fuel_usage;
        }


        public int free_tank_space()
        {
            return tank_size - fuel;
        }

        public int distance_left()
        {
            return Convert.ToInt32(fuel / fuel_usage);
        }

        public string fuel_situation()
        {
            int how_much_free = free_tank_space();
            int distance_reacheble = distance_left();
            return $"fuel left: {fuel}l, free space in tank: {how_much_free}l, how far to drive with current fuel level: {distance_reacheble}km";

        }
    }
}
