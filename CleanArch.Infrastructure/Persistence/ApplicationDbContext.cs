using Microsoft.EntityFrameworkCore;
using CleanArch.Domain.Entities;

namespace CleanArch.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> User { get; set; }
    }

}