
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Object IQuittable
            IQuittable iquittable = new Employee();
            //Instantiate an employee object and call SayName()
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            employee.SayName();
            //Call the IQuit method
            iquittable.IQuit(employee);
            Console.ReadLine();
        }
    }
}
