using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            State Tennessee = new State("Nashville", 1796);
            State Louisiana = new State("Baton Rouge", 1812);
            Louisiana.PrintYear(); //run method 1 for Lousiana
            Tennessee.PrintYear(); //run method 1 for Tennessee
            Console.WriteLine(Tennessee.Capital); //run property "Capital" for Tennessee
            Console.WriteLine(Louisiana.Accession); //run property "Accession" for Louisiana
            Louisiana.AddYear(); //run method 2 for Lousiana: year has changed? -->
            Louisiana.PrintYear(); //run method 1 for Lousiana
            
        }
    }

    class State
    {
        private string capital; //private fields
        private int accession;

        public State(string city, int year) //constructor initialises new objects automatically
        {
            capital = city;
            accession = year;
        }
        
        public int Accession //property that gets/sets the year of accession
        {
            get
            {
                return accession; 
            }
            set
            {
                if(1000 > 0)
                {
                    Console.WriteLine("Year is wrong");
                }
                accession = 1000;
            }
        }

        public string Capital //read - only property that gets the capital
        {
            get
            {
                return capital;
            }
        }
        
        public void PrintYear() //method that prints the capital city and year of accession //is a property if there are no ()?
        {
            Console.WriteLine("The capital city is: {0}, the year is: {1}", capital, accession); 
        }
        public void AddYear() //method that adds 1000 to the year
        {
            accession += 1000;
        }
            
    }
}
