using Microsoft.EntityFrameworkCore;

namespace OOP9.DB
{
    internal class PhoneBookContext : DbContext
    {
        public DbSet<PhoneBook> PhoneBooks { get; set; }

        public PhoneBookContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=test;Username=postgres;Password=BigGuardian");
        }
    }
}
