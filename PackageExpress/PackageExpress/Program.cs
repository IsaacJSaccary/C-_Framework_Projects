using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating the weight integer and defining it.
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.WriteLine("Please enter the package weight");
            int weight = Convert.ToInt32(Console.ReadLine());
            //Creating the if statement that declares what message will pop up
            //if the weight is more than 50
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
            }
            //Creating and defining the width integer
            int width = Convert.ToInt32(Console.ReadLine());
            //Creating and defining the height integer as well as creating the message
            //for the package height
            Console.WriteLine("Please enter the package height");
            int height = Convert.ToInt32(Console.ReadLine());
            //Creating the integer length and the phrase asking for the length input
            Console.WriteLine("Please enter the package length");
            int length = Convert.ToInt32(Console.ReadLine());
            //Creating the decimal total to give us our total amount for the shipping cost
            //and creating the message that pops up along with the total amount.
            decimal total = (width * height * length * weight / 100);
            Console.WriteLine("Your estimated total for shipping this packagage is: $" + total + " Thank you!");

            Console.Read();
        }
    }
}
