using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApi.Models
{
    public class EmployeeDBcontext : DbContext
    {
        public DbSet <Employes> Employes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-K7I2IUV;Initial Catalog=Employee;Integrated Security=True");
        }
    }
}
