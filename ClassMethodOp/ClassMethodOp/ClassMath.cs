using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodOp
{
    public class ClassMath
    {
        //Created the MathOp method for int num1
        public void MathOp(int num1)
        {
            int result = num1 / 2;
            Console.WriteLine(result);
        }
        //Created the MathOp method for decimal num2
        public static void MathOp(decimal num2 = 8)
        {
            decimal results = num2 + 7;
            Console.WriteLine(results);
        }
    }
}