using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate two objects of the Employee class and assign values to their properties.
            Employee employee1 = new Employee();
                
                employee1.firstName = "John";
                employee1.lastName = "Smith";
                employee1.Id = 1;

            Employee employee2 = new Employee();
            employee2.firstName = "Smith";
            employee2.lastName = "John";
            employee2.Id = 2;

            Console.WriteLine(employee1 == employee2);
            
            Console.ReadLine();

            
        }
    }
}
