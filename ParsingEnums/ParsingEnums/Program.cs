using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            bool isvalid = false;
            while(!isvalid)
            {
                //Wrap it in a try/catch block
                try
                {
                    //Prompt the user to enter the current day of the week
                    Console.WriteLine("Enter the current day of the week");
                    string dayinput = Console.ReadLine();
                    //Assign the value to a variable of that enum data type
                    DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), dayinput);
                    Console.WriteLine("Have a nice " + day);
                    Console.ReadLine();
                    isvalid = true;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Please enter an actual day of the week");
                }
            }
            
        }

    }
}
