using LoanSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LoanSystem.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<FacilityGroup> FacilityGroups => Set<FacilityGroup>();
        public DbSet<Facility> Facilities => Set<Facility>();
        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<LoanRequest> LoanRequests => Set<LoanRequest>();
        public DbSet<BankUser> BankUsers => Set<BankUser>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>().HasKey(c => c.Id);
            modelBuilder.Entity<FacilityGroup>().HasKey(fg => fg.Id);
            modelBuilder.Entity<Facility>().HasKey(f => f.Id);
            modelBuilder.Entity<LoanRequest>().HasKey(lr => lr.Id);
            modelBuilder.Entity<BankUser>().HasKey(bu => bu.Id);
        }
    }
}
