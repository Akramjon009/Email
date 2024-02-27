using LoginChecker.Domain.Models.EmailCheck;
using LoginChecker.Domain.Models.User;
using Microsoft.EntityFrameworkCore;

namespace LoginChecker.Infrastructure.Persistance
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options)
        {
            Database.Migrate();
        }
        public  DbSet<EmailCheck> EmailChecks { get; set; }
        public  DbSet<User> Users { get; set; }
    }
}
