using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Print the current date and time to the console
            Console.WriteLine("The current time is: " + DateTime.Now);
            //Ask for a number
            Console.WriteLine("Enter a number");
            float answer = float.Parse(Console.ReadLine());
            //Prints the time and date it will be in X amount of hours
            Console.WriteLine("In " + answer + " hours it will be " + DateTime.Now.AddHours(answer));
            Console.ReadLine();
        }
    }
}
