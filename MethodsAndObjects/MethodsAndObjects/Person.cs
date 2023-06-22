using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    public class Person
    {
        //Created data type string FirstName and LastName
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Created void method SayName() to display the full name to the console
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + LastName);
        }
    }
}
