using Microsoft.EntityFrameworkCore;

namespace Lab_5_2.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : 
            base(options) { }
        public DbSet<Contact> Contacts { get; set; }
    }
}