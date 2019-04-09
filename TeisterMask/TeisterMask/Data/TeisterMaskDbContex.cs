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
        private const string DbConnString = @"Server=****;Database=MasterTask_db;Integrated Security=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=*****;Database=MasterTaskdb;Integrated Security=True;");
        }
    }
}
