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
            try
            {
                int num2 = Convert.ToInt32(Console.ReadLine());
                int result = math01.MathOp(num1, num2);
                Console.WriteLine(num1 + num2 + result);
            }
            catch
            {
                int result = Math01.mathOp(num1);

            }
            Console.ReadLine();
        }
    }
}
