using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            Time newObject = new Time();
            Console.WriteLine("What is your favourite number");
            int favNum = Convert.ToInt32(Console.ReadLine());
            int favNumPlusTen = newObject.addTen(favNum);
            int favNumPlusTwenty = newObject.addTwenty(favNum);
            int favNumPlusThirty = newObject.addThirty(favNum);
            Console.WriteLine(favNumPlusTen);
            Console.WriteLine(favNumPlusTwenty);
            Console.WriteLine(favNumPlusThirty);

            Console.ReadLine();
            
        }
    }
}
