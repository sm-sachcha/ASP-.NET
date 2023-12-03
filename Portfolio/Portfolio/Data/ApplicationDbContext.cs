using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Portfolio.Models;

namespace Portfolio.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Contact> Contact { get; set; }
    }
}
