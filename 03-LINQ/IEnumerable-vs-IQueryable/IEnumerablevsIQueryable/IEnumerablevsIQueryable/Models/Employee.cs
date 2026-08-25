using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IEnumerablevsIQueryable.Models
{
    public class Employee
    {
        [Key]

        public int ID { get; set; }
        public string FirstName { get; set; }

        public string Lastname { get; set; }

        public string Gender { get; set; } 

        public int Salary { get; set; }

        public int DepartmentId { get; set; }

    }
}
