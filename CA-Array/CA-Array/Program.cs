using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carsArray = { "Chevy", "Ford", "Dodge", "Kia", "Nissan", "BMW" };
            Console.WriteLine("Select a number between 0 and 5");
            int stringSelect = Convert.ToInt32(Console.ReadLine());
            bool validString = false;

            while (!validString)
            {
                try
                {
                    Console.WriteLine("Your favourite car brand is " + carsArray[stringSelect]);
                    validString = true;
                }
                catch
                {
                    Console.WriteLine("Sorry, that number selection is invalid. Please select a number between 0 and 9.");
                    stringSelect = Convert.ToInt32(Console.ReadLine());
                }

                string[] gameArray = { "Call Of Duty", "God Of War", "Apex Legends", "Valorant", "Hogwarts Legacy", "Among Us", "Escape From Tarkov" };
                Console.WriteLine("Select a number between 0 and 6;");
                int stringSelect1 = Convert.ToInt32(Console.ReadLine());
                bool validString1 = false;

                while (!validString1)
                {
                    try
                    {
                        Console.WriteLine("Your favourite video game is " + gameArray[stringSelect1]);
                        validString1 = true;
                    }
                    catch
                    {
                        Console.WriteLine("Sorry, that number selection is invalid. Please select a number between 0 and 6.");
                        stringSelect1 = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.ReadLine();
            }
        }
    }
}

