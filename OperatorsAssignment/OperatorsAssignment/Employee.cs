using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    public class Employee
    { 
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int Id { get; set; }

        public static Employee operator== (Employee a, Employee b)
        {
            return a == b;
        }
        public static Employee operator!= (Employee a, Employee b) 
        {
            return a != b;
        }
    }
}
