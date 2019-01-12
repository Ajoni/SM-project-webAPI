using Microsoft.EntityFrameworkCore;
using SMprojectWebAPI.Models;

namespace SMprojectWebAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Shoe> Shoes { get; set; }
    }
}
