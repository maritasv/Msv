using HINVenture.Shared.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;


namespace HINVenture.Server.Data
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

        }
    }
}
