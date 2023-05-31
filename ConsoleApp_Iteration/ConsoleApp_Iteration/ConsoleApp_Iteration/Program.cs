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
            Console.WriteLine("Please enter your name:");
            string newname = Console.ReadLine();
            string[] names = { "Jesse", "Sam", "Cole", "Steven" };

            for (int i = 0; i < names.Length; i++)
            {
                names[i] += newname;
            }

            for (int j = 0; j < names.Length; j++)
            {
                Console.WriteLine(names[j]);
            }
            Console.ReadLine();
        }
    }
}
