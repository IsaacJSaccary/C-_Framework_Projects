using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FinalProject
{ 
    class Program
    {
        static void Main()
        {
            using (var ctx = new SchoolContext())

            {
                var stud = new Student() { FirstName = "Isaac", LastName = "Saccary", Age = 22 };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
                return;
            }
        }
    }
}
