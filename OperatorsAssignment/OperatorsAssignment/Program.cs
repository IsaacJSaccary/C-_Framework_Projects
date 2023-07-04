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
            Employee employee = new Employee();
                
                employee.firstName = "John";
                employee.lastName = "Smith";
                employee.Id = 1;
                
                employee.firstName = "Smith";
                employee.lastName = "John";
                employee.Id = 2;
            
            Console.ReadLine();

            
        }
    }
}
