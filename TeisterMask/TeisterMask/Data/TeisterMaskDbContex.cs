using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TeisterMask.Models;

namespace TeisterMask.Data
{
    public class TeisterMaskDbContex : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
        private const string DbConnString = @"Server=192.168.2.21;Database=MasterTaskdb;Integrated Security=false;User id=sa;Password =gogo890418@";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DbConnString);
        }
    }
}
