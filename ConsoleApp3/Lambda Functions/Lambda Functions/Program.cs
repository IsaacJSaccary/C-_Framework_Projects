using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list of at least 10 employees. 
            //At least two employees should have the first name "Joe"
            List<Employee> employees = new List<Employee>()
            {
                new Employee() {Id = 34, FirstName = "Joe", LastName = "Arnchek" },
                new Employee() {Id = 45, FirstName = "Joe", LastName = "Boychek"},
                new Employee() {Id = 56, FirstName = "Jim", LastName = "Hamilton"},
                new Employee() {Id = 78, FirstName = "Sam", LastName = "Howard"},
                new Employee() {Id = 35, FirstName = "Frank", LastName = "Hill"},
                new Employee() {Id = 07, FirstName = "Suzanne", LastName = "Waiters"},
                new Employee() {Id = 36, FirstName = "Mary", LastName = "Alan"},
                new Employee() {Id = 74, FirstName = "Gary", LastName = "Prokavic"},
                new Employee() {Id = 28, FirstName = "Robert", LastName = "Shurman"},
                new Employee() {Id = 33, FirstName = "Jesse", LastName = "Simpson"},
            };
            //Using a foreach loop, create a new list of all employees with the first name "Joe"
            List<Employee> joes = new List<Employee>();
            foreach(Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joes.Add(employee);
                }
            }
            //Perform the same action again but with a lambda expression
            List<Employee> joes2 = employees.Where(x => x.FirstName == "Joe").ToList();
            //Using a lambda expression, make a list of all employees with an Id number greater than 5
            List<Employee> bigId = employees.Where(x => x.Id > 5).ToList();
            Console.ReadLine();
        }
    }
}
