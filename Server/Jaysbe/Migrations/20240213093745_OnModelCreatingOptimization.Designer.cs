﻿// <auto-generated />
using System;
using Jaysbe.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Jaysbe.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240213093745_OnModelCreatingOptimization")]
    partial class OnModelCreatingOptimization
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Jaysbe.Models.Category", b =>
                {
                    b.Property<Guid?>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Jaysbe.Models.Product", b =>
                {
                    b.Property<Guid?>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Brand")
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Color")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<decimal?>("DiscountPrice")
                        .HasPrecision(16, 2)
                        .HasColumnType("decimal(16,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("PicturesUrls")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasPrecision(16, 2)
                        .HasColumnType("decimal(16,2)");

                    b.Property<long?>("ProductNumber")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("bigint");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("ThumbnailUrl")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Jaysbe.Models.ProductDescOption", b =>
                {
                    b.Property<Guid?>("ProductDescOptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DescType")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Option")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProductDescOptionId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductDescOption");
                });

            modelBuilder.Entity("Jaysbe.Models.SubCategory", b =>
                {
                    b.Property<Guid?>("SubCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("SubCategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "b42ab474-1b3e-4167-8963-4503dd2422c7",
                            Name = "TestUser",
                            NormalizedName = "TESTUSER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "d7b2e4dd-7a94-4fd2-8f65-da9e1a5c7d30",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9531d03c-536b-4627-a23d-1519e461b8f6",
                            Email = "user1@user.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER1@USER.COM",
                            NormalizedUserName = "USER1",
                            PasswordHash = "AQAAAAIAAYagAAAAEHCIgwEAEAjqCRHpVkd5Un6Bp+vymMkpeTCdpwRDKe7A62cc6e1O8P8k0IuyXSMAAw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "631ca327-55a4-4f97-8d1f-4ffb41ea9bea",
                            TwoFactorEnabled = false,
                            UserName = "user1"
                        },
                        new
                        {
                            Id = "fc671021-4d92-452e-8b6f-26124dd24de1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ca12ebdc-978d-4384-acfd-06a348754be7",
                            Email = "user2@user.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER2@USER.COM",
                            NormalizedUserName = "USER2",
                            PasswordHash = "AQAAAAIAAYagAAAAEHCIgwEAEAjqCRHpVkd5Un6Bp+vymMkpeTCdpwRDKe7A62cc6e1O8P8k0IuyXSMAAw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f1a88463-8655-42ef-947a-48a27b6f131f",
                            TwoFactorEnabled = false,
                            UserName = "user2"
                        },
                        new
                        {
                            Id = "d465ffc3-c504-4f71-b01d-8c92a99d9c1f",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "38daf96f-cb71-4bd1-90c0-9762f4d4fa50",
                            Email = "user3@user.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER3@USER.COM",
                            NormalizedUserName = "USER3",
                            PasswordHash = "AQAAAAIAAYagAAAAEHCIgwEAEAjqCRHpVkd5Un6Bp+vymMkpeTCdpwRDKe7A62cc6e1O8P8k0IuyXSMAAw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b32aa459-e10e-41cb-87e2-1274bb7672ba",
                            TwoFactorEnabled = false,
                            UserName = "user3"
                        },
                        new
                        {
                            Id = "b4b73e25-624b-4903-aade-e5603262e766",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "743b6d02-9ecc-417f-946a-0a2f20f211f9",
                            Email = "user4@user.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER4@USER.COM",
                            NormalizedUserName = "USER4",
                            PasswordHash = "AQAAAAIAAYagAAAAEHCIgwEAEAjqCRHpVkd5Un6Bp+vymMkpeTCdpwRDKe7A62cc6e1O8P8k0IuyXSMAAw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6e2ab1dd-7dfa-4e3d-9556-40a2daa839f3",
                            TwoFactorEnabled = false,
                            UserName = "user4"
                        },
                        new
                        {
                            Id = "6d5b5bd2-30c8-4c05-b7e2-d606f998436b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c56db349-700f-4128-9e2f-d8d237381753",
                            Email = "user5@user.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER5@USER.COM",
                            NormalizedUserName = "USER5",
                            PasswordHash = "AQAAAAIAAYagAAAAEHCIgwEAEAjqCRHpVkd5Un6Bp+vymMkpeTCdpwRDKe7A62cc6e1O8P8k0IuyXSMAAw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f44ce10e-007b-4cb1-b233-0f6444185661",
                            TwoFactorEnabled = false,
                            UserName = "user5"
                        },
                        new
                        {
                            Id = "610026bf-2fd1-48b2-b0a0-e0500b7a5e7d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "180c6abd-15ad-4b94-ac0d-35fbf35cc060",
                            Email = "user6@user.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER6@USER.COM",
                            NormalizedUserName = "USER6",
                            PasswordHash = "AQAAAAIAAYagAAAAEHCIgwEAEAjqCRHpVkd5Un6Bp+vymMkpeTCdpwRDKe7A62cc6e1O8P8k0IuyXSMAAw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a3dba566-78b7-47cf-91e0-4a377c08c674",
                            TwoFactorEnabled = false,
                            UserName = "user6"
                        },
                        new
                        {
                            Id = "baf34ac9-b8f2-4cf3-842d-08ca719e4179",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f9da4800-e263-49b4-a6a2-afd960170100",
                            Email = "user7@user.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER7@USER.COM",
                            NormalizedUserName = "USER7",
                            PasswordHash = "AQAAAAIAAYagAAAAEHCIgwEAEAjqCRHpVkd5Un6Bp+vymMkpeTCdpwRDKe7A62cc6e1O8P8k0IuyXSMAAw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fcb8b604-db64-4996-ab63-b2bf511f3ef4",
                            TwoFactorEnabled = false,
                            UserName = "user7"
                        },
                        new
                        {
                            Id = "a90cb0da-1ae6-475b-9f93-cfe2abbf4e77",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1b216b7c-c1fc-4b34-b0f6-bf6c89af27e4",
                            Email = "user8@user.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER8@USER.COM",
                            NormalizedUserName = "USER8",
                            PasswordHash = "AQAAAAIAAYagAAAAEHCIgwEAEAjqCRHpVkd5Un6Bp+vymMkpeTCdpwRDKe7A62cc6e1O8P8k0IuyXSMAAw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "373e23cd-6c5d-4dee-9e93-fdc5c098dfc1",
                            TwoFactorEnabled = false,
                            UserName = "user8"
                        },
                        new
                        {
                            Id = "73f146e4-b5a7-4253-a845-990d2a86509a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b5df3ea3-8512-441d-aabc-8ae19b9f47a3",
                            Email = "user9@user.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER9@USER.COM",
                            NormalizedUserName = "USER9",
                            PasswordHash = "AQAAAAIAAYagAAAAEHCIgwEAEAjqCRHpVkd5Un6Bp+vymMkpeTCdpwRDKe7A62cc6e1O8P8k0IuyXSMAAw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "92cd5418-a7c0-45bc-8746-7df1e4e740a5",
                            TwoFactorEnabled = false,
                            UserName = "user9"
                        },
                        new
                        {
                            Id = "8aac8893-c4a7-456d-8d71-adcfb237835c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d65bf25e-145f-4ca4-a98a-9c3d0bebc0d5",
                            Email = "user10@user.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER10@USER.COM",
                            NormalizedUserName = "USER10",
                            PasswordHash = "AQAAAAIAAYagAAAAEHCIgwEAEAjqCRHpVkd5Un6Bp+vymMkpeTCdpwRDKe7A62cc6e1O8P8k0IuyXSMAAw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "39552002-234d-4ee3-aae9-697e08c189f9",
                            TwoFactorEnabled = false,
                            UserName = "user10"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
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

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "d7b2e4dd-7a94-4fd2-8f65-da9e1a5c7d30",
                            RoleId = "b42ab474-1b3e-4167-8963-4503dd2422c7"
                        },
                        new
                        {
                            UserId = "fc671021-4d92-452e-8b6f-26124dd24de1",
                            RoleId = "b42ab474-1b3e-4167-8963-4503dd2422c7"
                        },
                        new
                        {
                            UserId = "d465ffc3-c504-4f71-b01d-8c92a99d9c1f",
                            RoleId = "b42ab474-1b3e-4167-8963-4503dd2422c7"
                        },
                        new
                        {
                            UserId = "b4b73e25-624b-4903-aade-e5603262e766",
                            RoleId = "b42ab474-1b3e-4167-8963-4503dd2422c7"
                        },
                        new
                        {
                            UserId = "6d5b5bd2-30c8-4c05-b7e2-d606f998436b",
                            RoleId = "b42ab474-1b3e-4167-8963-4503dd2422c7"
                        },
                        new
                        {
                            UserId = "610026bf-2fd1-48b2-b0a0-e0500b7a5e7d",
                            RoleId = "b42ab474-1b3e-4167-8963-4503dd2422c7"
                        },
                        new
                        {
                            UserId = "baf34ac9-b8f2-4cf3-842d-08ca719e4179",
                            RoleId = "b42ab474-1b3e-4167-8963-4503dd2422c7"
                        },
                        new
                        {
                            UserId = "a90cb0da-1ae6-475b-9f93-cfe2abbf4e77",
                            RoleId = "b42ab474-1b3e-4167-8963-4503dd2422c7"
                        },
                        new
                        {
                            UserId = "73f146e4-b5a7-4253-a845-990d2a86509a",
                            RoleId = "b42ab474-1b3e-4167-8963-4503dd2422c7"
                        },
                        new
                        {
                            UserId = "8aac8893-c4a7-456d-8d71-adcfb237835c",
                            RoleId = "b42ab474-1b3e-4167-8963-4503dd2422c7"
                        });
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

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Jaysbe.Models.Product", b =>
                {
                    b.HasOne("Jaysbe.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Jaysbe.Models.ProductDescOption", b =>
                {
                    b.HasOne("Jaysbe.Models.Product", null)
                        .WithMany("ProductDescriptions")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("Jaysbe.Models.SubCategory", b =>
                {
                    b.HasOne("Jaysbe.Models.Category", null)
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Jaysbe.Models.Category", b =>
                {
                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("Jaysbe.Models.Product", b =>
                {
                    b.Navigation("ProductDescriptions");
                });
#pragma warning restore 612, 618
        }
    }
}
