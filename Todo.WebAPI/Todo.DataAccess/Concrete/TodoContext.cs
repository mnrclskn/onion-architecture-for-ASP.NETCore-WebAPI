using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Todo.DataAccess.Models;

namespace Todo.DataAccess.Concrete
{
    public class TodoContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-E4H2D95\SQLEXPRESS;Database=TodoDB;Integrated Security=True");
        }

        public DbSet<Company> Companies { get; set; }
    }
}
