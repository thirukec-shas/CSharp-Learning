using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IEnumerablevsIQueryable.Models;

namespace IEnumerablevsIQueryable.Models
{

    class Program
    {

        public static void Main(string[] args)
        {
            using (var context = new CompanyDBContext())
            {
                IEnumerable<Employee> employee1 = context.Employees;
                var filteredEmployees1 = employee1.Where(e => e.Salary > 50000).ToList();
                Console.WriteLine("IEnumerable Result:");
                foreach (var emp in filteredEmployees1)
                {
                    Console.WriteLine($"{emp.FirstName} - {emp.Salary}");
                }
            }

            using (var context = new CompanyDBContext())
            {
                IQueryable<Employee> employee2 = context.Employees;
                var filteredEmployees2 = employee2.Where(e => e.Salary > 50000).ToList();
                Console.WriteLine("\nIQueryable Result:");
                foreach(var emp in filteredEmployees2)
                {
                    Console.WriteLine($"{emp.FirstName} - {emp.Salary}");
                }

            }
        }
    }

}