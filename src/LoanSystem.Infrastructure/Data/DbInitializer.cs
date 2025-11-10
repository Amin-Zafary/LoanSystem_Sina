using LoanSystem.Domain.Entities;
using LoanSystem.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace LoanSystem.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static async Task SeedAsync(AppDbContext context)
        {
            await context.Database.EnsureCreatedAsync();
            /*
            // جلوگیری از درج تکراری
            if (context.FacilityGroups.Any()) return;

            // --- FacilityGroups ---
            var groups = new List<FacilityGroup>
            {
                new() { Id = Guid.NewGuid(), Code = "FG01", Name = "تسهیلات مسکن", InterestRate = 18 },
                new() { Id = Guid.NewGuid(), Code = "FG02", Name = "تسهیلات خودرو", InterestRate = 20 },
                new() { Id = Guid.NewGuid(), Code = "FG03", Name = "تسهیلات ازدواج", InterestRate = 12 }
            };
            await context.FacilityGroups.AddRangeAsync(groups);
            await context.SaveChangesAsync();

            // --- Facilities ---
            var facilities = new List<Facility>
            {
                new() { Id = Guid.NewGuid(), Code = "F001", Name = "وام مسکن ۱۰ ساله", FacilityGroupId = groups[0].Id },
                new() { Id = Guid.NewGuid(), Code = "F002", Name = "وام خودرو اقساطی", FacilityGroupId = groups[1].Id },
                new() { Id = Guid.NewGuid(), Code = "F003", Name = "وام ازدواج جوانان", FacilityGroupId = groups[2].Id }
            };
            await context.Facilities.AddRangeAsync(facilities);
            await context.SaveChangesAsync();

            // --- Customers ---
            var customers = new List<Customer>
            {
                new() { Id = Guid.NewGuid(), FullName = "علی رضایی", NationalId = "1234567890", PhoneNumber = "09121111111" },
                new() { Id = Guid.NewGuid(), FullName = "زهرا احمدی", NationalId = "2234567890", PhoneNumber = "09123333333" },
                new() { Id = Guid.NewGuid(), FullName = "مهدی کریمی", NationalId = "3234567890", PhoneNumber = "09124444444" }
            };
            await context.Customers.AddRangeAsync(customers);
            await context.SaveChangesAsync();

            // --- BankUsers ---
            var users = new List<BankUser>
            {
                new() { Id = Guid.NewGuid(), Username = "admin", Password = "admin123", Role = "Admin" },
                new() { Id = Guid.NewGuid(), Username = "employee", Password = "emp123", Role = "Employee" }
            };
            await context.BankUsers.AddRangeAsync(users);
            await context.SaveChangesAsync();

            // --- LoanRequests ---
            var loanRequests = new List<LoanRequest>
            {
                new() {
                    Id = Guid.NewGuid(),
                    CustomerId = customers[0].Id,
                    FacilityId = facilities[0].Id,
                    RequestedAmount = 150_000_000,
                    RequestedMonths = 120,
                    Status = "Pending"
                },
                new() {
                    Id = Guid.NewGuid(),
                    CustomerId = customers[1].Id,
                    FacilityId = facilities[1].Id,
                    RequestedAmount = 50_000_000,
                    RequestedMonths = 36,
                    Status = "Approved"
                },
                new() {
                    Id = Guid.NewGuid(),
                    CustomerId = customers[2].Id,
                    FacilityId = facilities[2].Id,
                    RequestedAmount = 80_000_000,
                    RequestedMonths = 60,
                    Status = "Rejected"
                }
            };
            await context.LoanRequests.AddRangeAsync(loanRequests);
            await context.SaveChangesAsync();*/
        }
    }
}
