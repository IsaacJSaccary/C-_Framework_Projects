using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    public class Program
    {
        static void Main()
        {
            Math01 math01 = new Math01();
            Console.WriteLine("Pick an integer");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick another integer");
            
            int num2 = Convert.ToInt32(Console.ReadLine());
            math01.MathOp(num1, num2);
            
            Console.ReadLine();
        }
    }
}
