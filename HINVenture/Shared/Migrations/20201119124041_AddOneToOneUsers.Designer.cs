﻿// <auto-generated />
using System;
using HINVenture.Shared.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HINVenture.Shared.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201119124041_AddOneToOneUsers")]
    partial class AddOneToOneUsers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HINVenture.Shared.Models.Entities.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "3e1494ad-f065-4802-8b47-9b1e17471ec7",
                            ConcurrencyStamp = "2636887f-9bb8-4b72-8d2e-c8af95551b1a",
                            Name = "freelancer",
                            NormalizedName = "FREELANCER"
                        },
                        new
                        {
                            Id = "0d046923-6890-4e2a-a29d-7cdc44e2dd1e",
                            ConcurrencyStamp = "0b47c6b5-592c-4642-b01e-516a763d99cb",
                            Name = "customer",
                            NormalizedName = "CUSTOMER"
                        },
                        new
                        {
                            Id = "56f5e664-821e-4793-b0a0-63a33b1de6f8",
                            ConcurrencyStamp = "9575aacd-68c1-47dd-9eee-05a0ee088e72",
                            Name = "senior",
                            NormalizedName = "SENIOR"
                        },
                        new
                        {
                            Id = "0b11086a-dac7-43a3-9eb8-b43242da8f69",
                            ConcurrencyStamp = "1c6a7bca-a0db-47be-b955-cea53c8bc34a",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("HINVenture.Shared.Models.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CryptocoinAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SpecialityId")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("SpecialityId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("HINVenture.Shared.Models.Entities.CustomerUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.ToTable("CustomerUser");
                });

            modelBuilder.Entity("HINVenture.Shared.Models.Entities.FreelancerUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<float>("Rate")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("FreelancerUser");
                });

            modelBuilder.Entity("HINVenture.Shared.Models.Entities.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FreelancerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PostedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("FreelancerId");

                    b.HasIndex("OrderId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("HINVenture.Shared.Models.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CurrentFreelancerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PostedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CurrentFreelancerId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("HINVenture.Shared.Models.Entities.OrderProgress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FreelancerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Month")
                        .HasColumnType("datetime2");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ReadyLine")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FreelancerId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderProgresses");
                });

            modelBuilder.Entity("HINVenture.Shared.Models.Entities.Speciality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FreelancerUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FreelancerUserId");

                    b.HasIndex("OrderId");

                    b.ToTable("Specialities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "C# developer"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Python developer"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Java developer"
                        });
                });

            modelBuilder.Entity("HINVenture.Shared.Models.Entities.UserRoles", b =>
                {
                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("RoleId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("HINVenture.Shared.Models.Entities.ApplicationUser", b =>
                {
                    b.HasOne("HINVenture.Shared.Models.Entities.Speciality", null)
                        .WithMany("Freelancers")
                        .HasForeignKey("SpecialityId");
                });

            modelBuilder.Entity("HINVenture.Shared.Models.Entities.CustomerUser", b =>
                {
                    b.HasOne("HINVenture.Shared.Models.Entities.ApplicationUser", "ApplicationUser")
                        .WithOne("CustomerUser")
                        .HasForeignKey("HINVenture.Shared.Models.Entities.CustomerUser", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HINVenture.Shared.Models.Entities.FreelancerUser", b =>
                {
                    b.HasOne("HINVenture.Shared.Models.Entities.ApplicationUser", "ApplicationUser")
                        .WithOne("FreelancerUser")
                        .HasForeignKey("HINVenture.Shared.Models.Entities.FreelancerUser", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HINVenture.Shared.Models.Entities.Message", b =>
                {
                    b.HasOne("HINVenture.Shared.Models.Entities.CustomerUser", "Customer")
                        .WithMany("Messages")
                        .HasForeignKey("CustomerId");

                    b.HasOne("HINVenture.Shared.Models.Entities.FreelancerUser", "Freelancer")
                        .WithMany("Messages")
                        .HasForeignKey("FreelancerId");

                    b.HasOne("HINVenture.Shared.Models.Entities.Order", "Order")
                        .WithMany("Messages")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("HINVenture.Shared.Models.Entities.Order", b =>
                {
                    b.HasOne("HINVenture.Shared.Models.Entities.FreelancerUser", "CurrentFreelancer")
                        .WithMany("CurrentOrders")
                        .HasForeignKey("CurrentFreelancerId");

                    b.HasOne("HINVenture.Shared.Models.Entities.CustomerUser", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("HINVenture.Shared.Models.Entities.OrderProgress", b =>
                {
                    b.HasOne("HINVenture.Shared.Models.Entities.FreelancerUser", "Freelancer")
                        .WithMany("OrderProgresses")
                        .HasForeignKey("FreelancerId");

                    b.HasOne("HINVenture.Shared.Models.Entities.Order", "Order")
                        .WithMany("OrderProgreses")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("HINVenture.Shared.Models.Entities.Speciality", b =>
                {
                    b.HasOne("HINVenture.Shared.Models.Entities.FreelancerUser", null)
                        .WithMany("Specs")
                        .HasForeignKey("FreelancerUserId");

                    b.HasOne("HINVenture.Shared.Models.Entities.Order", null)
                        .WithMany("Specs")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("HINVenture.Shared.Models.Entities.UserRoles", b =>
                {
                    b.HasOne("HINVenture.Shared.Models.Entities.ApplicationRole", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HINVenture.Shared.Models.Entities.ApplicationUser", "User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("HINVenture.Shared.Models.Entities.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("HINVenture.Shared.Models.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HINVenture.Shared.Models.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("HINVenture.Shared.Models.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
