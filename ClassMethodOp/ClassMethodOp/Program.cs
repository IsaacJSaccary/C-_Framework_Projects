using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodOp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Created the operation output
            ClassMath classmath = new ClassMath();
            //Created num2 to display output parameters
            decimal num2 = 8;
            //Created the group of text to make num1 a user input
            Console.WriteLine("Enter an integer");
            int num1 = Convert.ToInt32(Console.ReadLine());
            //Called the methods
            classmath.MathOp(num1);
            ClassMath.MathOp(num2);
            Console.ReadLine();
        }
    }
}
