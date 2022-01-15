using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alkemy_DesarrolloChallenge.Models
{
    public class MyDbContext : DbContext

    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = LAPTOP-622ROEGK\SQLEXPRESS; Database= AlkemyCF; Trusted_Connection=True;");
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Comments> Comments { get; set; }



    }
}
