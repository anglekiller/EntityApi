using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityframworkCodeFirst.Model
{
    public class apiDBcontext : DbContext
    {
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Users> User { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=papa-yaga;Initial Catalog=testThoi;Integrated Security=True");
        }
    }
}
