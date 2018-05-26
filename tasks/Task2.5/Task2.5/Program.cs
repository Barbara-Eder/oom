using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorboat Titanic = new Motorboat(45000, 50);
            Motorboat Baywatch = new Motorboat(25000, 60);
            Console.WriteLine("Titanic's speed: {0}", Titanic.Speed);
            Console.WriteLine("Baywatch's price: {0}", Baywatch.Price);
            Baywatch.Price = 26000;
            Console.WriteLine("Baywatch's price after resetting: {0}", Baywatch.Price);
            Titanic.EnhanceSpeed();
            Console.WriteLine("Titanic's speed after doubling: {0}", Titanic.Speed);
          
        }
    }

    class Motorboat
    {
        private double price;
        private int speed;

        public Motorboat(double a_price, int a_speed) 
        {
            price = a_price;
            speed = a_speed;
        }

        public int EnhanceSpeed()
        {
            speed *= 2;
            return speed;
        }

        public int Speed
        {
            get
            {
                Console.WriteLine("Speed read:");
                return speed;
            }
            set
            {
                Console.WriteLine("Speed set");
                if (value < 10) throw new Exception("Speed must be at least 10 km/h");
                speed = value;
            }
        }

        public double Price
        {
            get
            {
                Console.WriteLine("Price read:");
                return price;
            }
            set
            {
                Console.WriteLine("Price set");
                if (value < 0) throw new Exception("price must be at least 0");
                price = value;
            }
        }

    }


}
