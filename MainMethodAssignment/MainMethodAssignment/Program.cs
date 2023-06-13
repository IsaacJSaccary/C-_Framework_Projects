using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            math1 math1 = new math1();
            Console.WriteLine(math1.SubFive(100));
            Console.WriteLine(math1.SubFive(100.65m));
            Console.WriteLine(math1.SubFive("100"));
            Console.ReadLine();
        }
    }
}
