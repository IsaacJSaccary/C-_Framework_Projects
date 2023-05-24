using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 6;
            int x = 3;
            int y = 4;
            while (x < i)
            {
                Console.WriteLine(x);
                x++;
            }

            do
            {
                Console.WriteLine(i);
                i--;
            }
            while (i > y);
            Console.ReadLine();
        }
    }
}
