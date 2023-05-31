using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fun = "Hello my";
            string stuff = " name is ";
            string things = "Isaac";
            string upper = fun.ToUpper();
            Console.WriteLine(upper + stuff + things);
            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Isaac");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
