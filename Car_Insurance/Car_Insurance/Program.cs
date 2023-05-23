using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Insurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            int Nage = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? (Yes or no)");
            string answer = Console.ReadLine().ToLower();
            
            bool dui = answer == "yes";
            Console.WriteLine("How many speeding tickets do you have?");
            int tic = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Qualified for insurance?");
            bool qualified = (Nage > 15) && !dui && (tic <= 3);
            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}
