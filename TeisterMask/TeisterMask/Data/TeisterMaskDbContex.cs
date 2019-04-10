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
        private const string DbConnString = @"Server=TS-PC\SQLEXPRESS;Database=MasterTaskdb;Integrated Security=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DbConnString);
        }
    }
}
