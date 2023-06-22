using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate Employee object
            Employee name = new Employee();
            name.FirstName = "Sample ";
            name.LastName = "Student";
            //Called the super class method SayName()
            name.SayName();
            Console.ReadLine();
        }
    }
}
