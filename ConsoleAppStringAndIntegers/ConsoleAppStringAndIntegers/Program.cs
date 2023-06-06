using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStringAndIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberOne = new List<int>() { 12, 34, 53, 62, 72, 78, 13, 96 };

            try
            {
                Console.WriteLine("Pick a number");
                decimal numberTwo = Convert.ToDecimal(Console.ReadLine());

                foreach (decimal number in numberOne)
                {
                    Console.WriteLine(number / numberTwo);
                }
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not divide by 0.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            Console.WriteLine("The program has exited the try/catch block.");
            Console.ReadLine();
        }
    }
}
