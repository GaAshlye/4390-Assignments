using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TheCodingClub2.Models
{
    public class CodeDbContext : DbContext
    {
        public CodeDbContext (DbContextOptions<CodeDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Projects> Project {get;set;}
    }
}