using CarFind.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarFind.DataAccess
{
    public class CarDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=AHMETSARI; DataBase=CarDb; uid=sa; pwd=123456;");
        }
        public DbSet<Car> Cars { get; set; }
    }
}
