using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    public class Program
    { 
        static void Main(string[] args)
        {
            //Create an object of data type Number and assign an amount to it
            Number num1 = new Number() { Amount = 35 };
            //Print this amount to the conosle
            Console.WriteLine(num1.Amount);
            Console.ReadLine();
        }
    }
}
