using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IEnumerablevsIQueryable.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace IEnumerablevsIQueryable
{
    public class CompanyDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=localhost\\SQLEXPRESS;Initial Catalog=LCSIC4;Integrated Security=True;TrustServerCertificate=True;"
            )
            .LogTo(Console.WriteLine, LogLevel.Information);
        }
    }
}
