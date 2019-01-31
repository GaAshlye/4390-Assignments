using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheCodingClub2;

    public class CodeDbContext : DbContext
    {
        public CodeDbContext (DbContextOptions<CodeDbContext> options)
            : base(options)
        {
        }

        public DbSet<TheCodingClub2.User> User { get; set; }

        public DbSet<TheCodingClub2.Projects> Projects { get; set; }
    }
