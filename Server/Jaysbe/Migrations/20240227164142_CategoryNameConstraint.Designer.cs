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
    [Migration("20240227164142_CategoryNameConstraint")]
    partial class CategoryNameConstraint
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

                    b.HasIndex("Name")
                        .IsUnique();

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
                            Id = "7271bd88-cd38-4078-bbf0-230cf4794de8",
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
                            Id = "e2823794-a97c-41c7-91c4-362e67c7d52a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5f9918c0-a4df-4a33-996a-908fd7b22e53",
                            Email = "user1@user.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER1@USER.COM",
                            NormalizedUserName = "USER1",
                            PasswordHash = "AQAAAAIAAYagAAAAEFWJrcuU6akEBhZ0XtKxE9cUBNyMUc83O3FreTNnzzX3hxlAc3TI+9p+wazMR2N1sg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ae34d25d-7010-4d08-a6cf-5fcbff246866",
                            TwoFactorEnabled = false,
                            UserName = "user1"
                        },
                        new
                        {
                            Id = "c4970663-53d8-4c02-8d33-7c93964be5df",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "46d2be1c-bbb9-461d-a3db-57f3197abab2",
                            Email = "user2@user.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER2@USER.COM",
                            NormalizedUserName = "USER2",
                            PasswordHash = "AQAAAAIAAYagAAAAEFWJrcuU6akEBhZ0XtKxE9cUBNyMUc83O3FreTNnzzX3hxlAc3TI+9p+wazMR2N1sg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6bfe749c-9b19-4009-a7d4-98a2af5a418e",
                            TwoFactorEnabled = false,
                            UserName = "user2"
                        },
                        new
                        {
                            Id = "588c146a-766e-4b72-9092-4134383e8c6a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2faa1707-0062-4c8b-8c74-dc3b3e23e45b",
                            Email = "user3@user.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER3@USER.COM",
                            NormalizedUserName = "USER3",
                            PasswordHash = "AQAAAAIAAYagAAAAEFWJrcuU6akEBhZ0XtKxE9cUBNyMUc83O3FreTNnzzX3hxlAc3TI+9p+wazMR2N1sg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "46664c11-810b-46e8-96ea-d20e3344d254",
                            TwoFactorEnabled = false,
                            UserName = "user3"
                        },
                        new
                        {
                            Id = "49605273-7e25-4632-a712-f4b9f867e5fa",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "04f0a9b3-e5a8-4a04-9e54-5431ae08a267",
                            Email = "user4@user.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER4@USER.COM",
                            NormalizedUserName = "USER4",
                            PasswordHash = "AQAAAAIAAYagAAAAEFWJrcuU6akEBhZ0XtKxE9cUBNyMUc83O3FreTNnzzX3hxlAc3TI+9p+wazMR2N1sg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "32a6d174-5766-461d-afbf-228ea4917bd0",
                            TwoFactorEnabled = false,
                            UserName = "user4"
                        },
                        new
                        {
                            Id = "da2519b2-d723-4ced-a6b4-6923aff54bfd",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b7189844-b20b-45e7-a4ca-9938d5ba6ae8",
                            Email = "user5@user.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER5@USER.COM",
                            NormalizedUserName = "USER5",
                            PasswordHash = "AQAAAAIAAYagAAAAEFWJrcuU6akEBhZ0XtKxE9cUBNyMUc83O3FreTNnzzX3hxlAc3TI+9p+wazMR2N1sg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "dfda6315-3625-4fa8-ae48-15af09c1ae7d",
                            TwoFactorEnabled = false,
                            UserName = "user5"
                        },
                        new
                        {
                            Id = "672af8c7-e4e6-419e-b477-920db37636a8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "97adc489-2019-442e-8122-f1ade2688a50",
                            Email = "user6@user.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER6@USER.COM",
                            NormalizedUserName = "USER6",
                            PasswordHash = "AQAAAAIAAYagAAAAEFWJrcuU6akEBhZ0XtKxE9cUBNyMUc83O3FreTNnzzX3hxlAc3TI+9p+wazMR2N1sg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8b1594fd-acee-4433-b320-a53e92bf64ef",
                            TwoFactorEnabled = false,
                            UserName = "user6"
                        },
                        new
                        {
                            Id = "8791fc29-3898-436c-8577-1357a11bcc05",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a659e9f3-ca43-47ad-a193-589b4f41b08c",
                            Email = "user7@user.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER7@USER.COM",
                            NormalizedUserName = "USER7",
                            PasswordHash = "AQAAAAIAAYagAAAAEFWJrcuU6akEBhZ0XtKxE9cUBNyMUc83O3FreTNnzzX3hxlAc3TI+9p+wazMR2N1sg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "435b34ca-6273-4a8c-9d78-16cb35816634",
                            TwoFactorEnabled = false,
                            UserName = "user7"
                        },
                        new
                        {
                            Id = "8316701a-0c32-4e9a-b91d-3be274c8f979",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f1e7fc5c-4346-4936-a339-0107d49a6720",
                            Email = "user8@user.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER8@USER.COM",
                            NormalizedUserName = "USER8",
                            PasswordHash = "AQAAAAIAAYagAAAAEFWJrcuU6akEBhZ0XtKxE9cUBNyMUc83O3FreTNnzzX3hxlAc3TI+9p+wazMR2N1sg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "cad98386-f20c-4a6f-a9f1-22ec40acb1fa",
                            TwoFactorEnabled = false,
                            UserName = "user8"
                        },
                        new
                        {
                            Id = "4d6efc47-c777-46f6-92d1-34e0c868bea4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "03e4ec8a-beea-41dc-addb-1335c61e36f9",
                            Email = "user9@user.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER9@USER.COM",
                            NormalizedUserName = "USER9",
                            PasswordHash = "AQAAAAIAAYagAAAAEFWJrcuU6akEBhZ0XtKxE9cUBNyMUc83O3FreTNnzzX3hxlAc3TI+9p+wazMR2N1sg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f26e8e1f-8490-4edf-83c6-32017e98f59a",
                            TwoFactorEnabled = false,
                            UserName = "user9"
                        },
                        new
                        {
                            Id = "32bc3886-f0c0-4339-97e5-5f4ee850e783",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "22c11d59-68cd-4ab5-945a-d2f3a93c9f1b",
                            Email = "user10@user.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER10@USER.COM",
                            NormalizedUserName = "USER10",
                            PasswordHash = "AQAAAAIAAYagAAAAEFWJrcuU6akEBhZ0XtKxE9cUBNyMUc83O3FreTNnzzX3hxlAc3TI+9p+wazMR2N1sg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "02a0d734-1b00-4bc0-ab3c-5661d7af407d",
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
                            UserId = "e2823794-a97c-41c7-91c4-362e67c7d52a",
                            RoleId = "7271bd88-cd38-4078-bbf0-230cf4794de8"
                        },
                        new
                        {
                            UserId = "c4970663-53d8-4c02-8d33-7c93964be5df",
                            RoleId = "7271bd88-cd38-4078-bbf0-230cf4794de8"
                        },
                        new
                        {
                            UserId = "588c146a-766e-4b72-9092-4134383e8c6a",
                            RoleId = "7271bd88-cd38-4078-bbf0-230cf4794de8"
                        },
                        new
                        {
                            UserId = "49605273-7e25-4632-a712-f4b9f867e5fa",
                            RoleId = "7271bd88-cd38-4078-bbf0-230cf4794de8"
                        },
                        new
                        {
                            UserId = "da2519b2-d723-4ced-a6b4-6923aff54bfd",
                            RoleId = "7271bd88-cd38-4078-bbf0-230cf4794de8"
                        },
                        new
                        {
                            UserId = "672af8c7-e4e6-419e-b477-920db37636a8",
                            RoleId = "7271bd88-cd38-4078-bbf0-230cf4794de8"
                        },
                        new
                        {
                            UserId = "8791fc29-3898-436c-8577-1357a11bcc05",
                            RoleId = "7271bd88-cd38-4078-bbf0-230cf4794de8"
                        },
                        new
                        {
                            UserId = "8316701a-0c32-4e9a-b91d-3be274c8f979",
                            RoleId = "7271bd88-cd38-4078-bbf0-230cf4794de8"
                        },
                        new
                        {
                            UserId = "4d6efc47-c777-46f6-92d1-34e0c868bea4",
                            RoleId = "7271bd88-cd38-4078-bbf0-230cf4794de8"
                        },
                        new
                        {
                            UserId = "32bc3886-f0c0-4339-97e5-5f4ee850e783",
                            RoleId = "7271bd88-cd38-4078-bbf0-230cf4794de8"
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
