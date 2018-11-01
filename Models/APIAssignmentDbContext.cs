using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace APIAssignment.Models
{
    public class APIAssignmentDbContext : DbContext
    {
        public APIAssignmentDbContext(DbContextOptions<APIAssignmentDbContext> options) : base(options) { }

        public DbSet<Member> Members { get; set; }
        public DbSet<Credential> Credentials { get; set; }
        public DbSet<Song> Songs { get; set; }
    }
}
