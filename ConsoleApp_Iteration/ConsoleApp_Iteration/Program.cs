using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Iteration
{
    class Program
    {
        static void Main()
        {
            string newname = Console.ReadLine();
            string[] names = { "Jesse", "Sam", "Cole", "Steven" };
            Console.WriteLine("Please enter your name:");

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i] + newname[i]);
            }

            Console.ReadLine();
        }
    }
}
