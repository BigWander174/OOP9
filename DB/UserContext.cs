using Microsoft.EntityFrameworkCore;

namespace OOP9.DB
{
    internal class UserContext : DbContext
    {
        public DbSet<User> PhoneBooks { get; set; }

        public UserContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=OOP9;Port=5432;Database=OOP9;Username=postgres;Password=BigGuardian");
        }
    }
}
