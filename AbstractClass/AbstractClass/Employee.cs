using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
     public class Employee : Person, IQuittable
    {
        //Implement the SayName() method
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
        //Employee class inherit the interface and implement the Quit() method
        public void IQuit(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
