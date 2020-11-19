using HINVenture.Shared.Models;
using HINVenture.Shared.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;


namespace HINVenture.Shared.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string, IdentityUserClaim<string>, UserRoles, IdentityUserLogin<string>, IdentityRoleClaim<string>, IdentityUserToken<string> >
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserRoles>().HasKey(a => new { a.RoleId, a.UserId });

            builder.Entity<UserRoles>().HasOne(a => a.User).WithMany(a => a.Roles).HasForeignKey(a => a.UserId);
            builder.Entity<UserRoles>().HasOne(a => a.Role).WithMany(a => a.Users).HasForeignKey(a => a.RoleId);
            builder.Entity<ApplicationRole>().HasData(new IdentityRole { Name = "freelancer", NormalizedName = "FREELANCER", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            builder.Entity<ApplicationRole>().HasData(new IdentityRole { Name = "customer", NormalizedName = "CUSTOMER", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            builder.Entity<ApplicationRole>().HasData(new IdentityRole { Name = "senior", NormalizedName = "SENIOR", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            builder.Entity<ApplicationRole>().HasData(new IdentityRole { Name = "admin", NormalizedName = "ADMIN", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });

            builder.Entity<Speciality>().HasData(new Speciality { Name = "C# developer", Id = 1});
            builder.Entity<Speciality>().HasData(new Speciality { Name = "Python developer", Id = 2 });
            builder.Entity<Speciality>().HasData(new Speciality { Name = "Java developer", Id = 3 });
        }

        public DbSet<Message> Messages { get; set; }
        public DbSet<OrderProgress> OrderProgresses { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
