using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create the statement and int answer will hold the value
            Console.WriteLine("Please enter a number");
            int answer = Convert.ToInt32(Console.ReadLine());
            //Create the StreamWriter which will send the value to the text file
            using (StreamWriter file = new StreamWriter(@"C:\Users\isaac\Logs.txt", true))
            {
                file.WriteLine(answer);
            }
        }
    }
}
