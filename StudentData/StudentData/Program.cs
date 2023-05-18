using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData
{
    class Program
    {
        static void Main(string[] args)
        {
            //Title and subtitle of the daily report
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");
            
            //Asking name
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Nice to meet you " + yourName + "!");

            
            //What course are you on?
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();

            //Group of code for page number
            Console.WriteLine("What page are you on?");
            string pageNum = Console.ReadLine();

            //Group of code for assistance
            Console.WriteLine("Do you need help with anything? Please answer \"True\" or \"False\"");
            Console.ReadLine();

            //Group of code for feedback
            Console.WriteLine("Were there any positive experiences you'd like to share? Plaease give specifics");
            Console.ReadLine();

            Console.WriteLine("Is there any feedback you'd like to provide? Please be specific.");
            Console.ReadLine();

            //Group of code for hours studied
            Console.WriteLine("How many hours did you study today? (If you're still studying than how many so far)");
            Console.ReadLine();

            //Group of code for ending statement
            Console.WriteLine("Thank you for your answers. An instructor will respond shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
