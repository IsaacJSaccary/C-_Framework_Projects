using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            int HrRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int WkHrs = Convert.ToInt32(Console.ReadLine());
            int Salary = Convert.ToInt32(HrRate) * Convert.ToInt32(WkHrs) * 52;
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            int HrRate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int WkHrs1 = Convert.ToInt32(Console.ReadLine());
            int Salary1 = Convert.ToInt32(HrRate1) * Convert.ToInt32(WkHrs1) * 52;
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(Salary);
            Console.WriteLine("Annual salary of person 2:");
            Console.WriteLine(Salary1);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool isMore = Salary > Salary1;
            Console.WriteLine(isMore);
            Console.ReadLine();

        }
    }
}
