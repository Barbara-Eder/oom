using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Task2._5
{

    class Program
    {
        static void Main(string[] args)
        {
            
            Motorboat Titanic = new Motorboat("Titanic", 45000, 50);
            Motorboat Baywatch = new Motorboat("Baywatch", 25000, 60);
            Console.WriteLine("Titanic's speed: {0}", Titanic.Speed);
            Console.WriteLine("Baywatch's price: {0}", Baywatch.Price);
            Baywatch.Price = 26000;
            Console.WriteLine("Baywatch's price after resetting: {0}", Baywatch.Price);
            Titanic.EnhanceSpeed();
            Console.WriteLine("Titanic's speed after doubling: {0}", Titanic.Speed);

            Rowboat Speedy = new Rowboat("Speedy", 1500, 2);
            Console.WriteLine("Speedy's price: {0}", Speedy.Price);

            //Task 3.4: array

            Console.WriteLine("array:");

            IBoat[] array = new IBoat[] { Titanic, Baywatch, Speedy };

            foreach (var i in array)
            {
                Console.WriteLine("boat {0}: after using enhance speed method: {1}", i.Name, i.EnhanceSpeed());
            }

            //Task 4.2: serialization

            Console.WriteLine("serialization:");

            foreach (var i in array) 
            {
                string jsonstring = JsonConvert.SerializeObject(i);
                Console.WriteLine(jsonstring);
            }

        }

        }
    }


    public interface IBoat
    {
        double Price { get; }
        string Name { get; }
        int EnhanceSpeed();
    }


    public class Motorboat : IBoat
    {
        private double price;
        private int speed;
        private string name;

        public Motorboat(string a_name, double a_price, int a_speed)
            {
                if (a_speed < 0) throw new ArgumentOutOfRangeException("speed must be at least 0 km/h");
                if (a_price < 0) throw new ArgumentOutOfRangeException("price must be at least 0");
                price = a_price;
                speed = a_speed;
                name = a_name;
            }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value < 0) throw new Exception("price must be at least 0");
                price = value;
            }
        }

        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (value < 0) throw new Exception("speed must be at least 0 km/h");
                speed = value;
            }
        }

        public int EnhanceSpeed()
            {
                speed *= 2;
                return speed;
            }

    }


    public class Rowboat : IBoat
    {
        private double price;
        private int number_oars;
        private string name;

        public Rowboat(string a_name, double a_price, int a_number)
        {
        if (a_number < 0) throw new ArgumentOutOfRangeException("cannot be negative");
            name = a_name;
            price = a_price;
            number_oars = a_number;
        }

        public string Name
        {
            get
            {
                return name;
            }

        }

        public double Price
            {
                get
                {
                    return price;
                }
                set
                {
                    if (value < 0) throw new Exception("price must be at least 0");
                    price = value;
                }
            }
  
        public int Number_oars
        {
            get
            {
                return number_oars;
            }
            set
            {
                if (value < 1) throw new Exception("rowboat must have at least 1 oar");
                number_oars = value;
            }
        }

        public int EnhanceSpeed()
        {
            number_oars *= 2;
            return number_oars;
        }

    }
