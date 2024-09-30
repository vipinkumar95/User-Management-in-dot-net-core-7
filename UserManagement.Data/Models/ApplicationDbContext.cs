using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UserManagement.Data.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<ApplicationUser> applicationUsers { get; set; }

        public DbSet<LoginModel> loginModels { get; set; }

        public DbSet<RegistrationModel> registrationModels { get; set; }

    }
}
