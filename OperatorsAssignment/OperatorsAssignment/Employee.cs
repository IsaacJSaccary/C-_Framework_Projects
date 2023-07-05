using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    //Create an Employee class
    public class Employee
    { 
        //With FirstName
        public string firstName { get; set; }
        //LastName
        public string lastName { get; set; }
        //And Id properties.
        public int Id { get; set; }
        //Overload the "==" operator so it checks if two employee ebjects are equal by comparing their Id.
        public static bool operator== (Employee a, Employee b)
        {
            return a.Id == b.Id;
        }
        public static bool operator!= (Employee a, Employee b) 
        {
            return a.Id != b.Id;
        }
    }
}
