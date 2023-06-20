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
            //Creating the Math01 operation
            Math01 math01 = new Math01();
            //Creating the Console.WriteLine for the first integer and assigning the input to num1
            Console.WriteLine("Pick an integer");
            int num1 = Convert.ToInt32(Console.ReadLine());
            //Creating the second Console.WriteLine for the second integer and assignging it to num2
            Console.WriteLine("Pick another integer");
            
            int num2 = Convert.ToInt32(Console.ReadLine());
            //Displaying the Method
            math01.MathOp(num1, num2);
            
            Console.ReadLine();
        }
    }
}
