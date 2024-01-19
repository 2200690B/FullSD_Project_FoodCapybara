﻿// <auto-generated />
using System;
using FullSD_Project_FoodCapybara.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FullSD_Project_FoodCapybara.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Duende.IdentityServer.EntityFramework.Entities.DeviceFlowCodes", b =>
                {
                    b.Property<string>("UserCode")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("DeviceCode")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("Expiration")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("UserCode");

                    b.HasIndex("DeviceCode")
                        .IsUnique();

                    b.HasIndex("Expiration");

                    b.ToTable("DeviceCodes", (string)null);
                });

            modelBuilder.Entity("Duende.IdentityServer.EntityFramework.Entities.Key", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Algorithm")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DataProtected")
                        .HasColumnType("bit");

                    b.Property<bool>("IsX509Certificate")
                        .HasColumnType("bit");

                    b.Property<string>("Use")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Use");

                    b.ToTable("Keys", (string)null);
                });

            modelBuilder.Entity("Duende.IdentityServer.EntityFramework.Entities.PersistedGrant", b =>
                {
                    b.Property<string>("Key")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("ConsumedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("datetime2");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Key");

                    b.HasIndex("ConsumedTime");

                    b.HasIndex("Expiration");

                    b.HasIndex("SubjectId", "ClientId", "Type");

                    b.HasIndex("SubjectId", "SessionId", "Type");

                    b.ToTable("PersistedGrants", (string)null);
                });

            modelBuilder.Entity("FullSD_Project_FoodCapybara.Server.Models.ApplicationUser", b =>
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

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

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
                            Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4a1b9010-46b6-4ecd-b5f2-c9bb67e4d663",
                            Email = "admin@localhost.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@LOCALHOST.COM",
                            NormalizedUserName = "ADMIN@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAELxG852va/CQuU3QG1VzT4RwFvCjzHNHBCL1nwO3YgFGSTWLL21LAbtH+vT0+TFHRA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1e51f464-01b8-47ce-abcd-f4dd2b7b7f78",
                            TwoFactorEnabled = false,
                            UserName = "admin@localhost.com"
                        },
                        new
                        {
                            Id = "3700efa7-66dc-47f0-860f-e506d04102e4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fc32e169-bdc1-4d01-a561-3ea16c12a886",
                            Email = "staff@localhost.com",
                            EmailConfirmed = false,
                            FirstName = "Staff",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "STAFF@LOCALHOST.COM",
                            NormalizedUserName = "STAFF@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEGl9zl4LHDv3fwveOVOa1P1dPOHuiErquz9vSPcMK94yV2eGDwXoE3N400IVnvxwTA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ffa53d74-f7b1-4487-9f4f-5a5d193a2f55",
                            TwoFactorEnabled = false,
                            UserName = "staff@localhost.com"
                        });
                });

            modelBuilder.Entity("FullSD_Project_FoodCapybara.Shared.Domain.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CustAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("CustPayment")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("CustPhone")
                        .HasColumnType("int");

                    b.Property<string>("CustUsername")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("FullSD_Project_FoodCapybara.Shared.Domain.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("FoodCost")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("FoodDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FoodName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FoodRating")
                        .HasColumnType("int");

                    b.Property<int>("RestId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RestId");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FoodCost = 12.99m,
                            FoodDesc = "Classic pizza with tomato, mozzarella, and basil.",
                            FoodName = "Margherita  Pizza",
                            FoodRating = 5,
                            RestId = 1
                        },
                        new
                        {
                            Id = 2,
                            FoodCost = 14.99m,
                            FoodDesc = "Pizza with pepperoni and cheese.",
                            FoodName = "Pepperoni Pizza",
                            FoodRating = 4,
                            RestId = 1
                        },
                        new
                        {
                            Id = 3,
                            FoodCost = 7.99m,
                            FoodDesc = "Crispy breadsticks with garlic butter.",
                            FoodName = "Garlic Breadsticks",
                            FoodRating = 4,
                            RestId = 1
                        },
                        new
                        {
                            Id = 4,
                            FoodCost = 2.49m,
                            FoodDesc = "Classic carbonated beverage.",
                            FoodName = "Soda",
                            FoodRating = 3,
                            RestId = 1
                        },
                        new
                        {
                            Id = 5,
                            FoodCost = 1.99m,
                            FoodDesc = "Refreshing iced tea.",
                            FoodName = "Iced Tea",
                            FoodRating = 3,
                            RestId = 1
                        },
                        new
                        {
                            Id = 6,
                            FoodCost = 3.99m,
                            FoodDesc = "A flaky and buttery croissant filled with rich chocolate.",
                            FoodName = "Chocolate Croissant",
                            FoodRating = 4,
                            RestId = 2
                        },
                        new
                        {
                            Id = 7,
                            FoodCost = 2.49m,
                            FoodDesc = "Soft and moist muffin bursting with juicy blueberries.",
                            FoodName = "Blueberry Muffin",
                            FoodRating = 5,
                            RestId = 2
                        },
                        new
                        {
                            Id = 8,
                            FoodCost = 4.49m,
                            FoodDesc = "Classic croissant with a sweet almond filling and crunchy almonds on top.",
                            FoodName = "Almond Croissant",
                            FoodRating = 4,
                            RestId = 2
                        },
                        new
                        {
                            Id = 9,
                            FoodCost = 3.79m,
                            FoodDesc = "Spiraled pastry with layers of cinnamon sugar and topped with cream cheese icing.",
                            FoodName = "Cinnamon Roll",
                            FoodRating = 5,
                            RestId = 2
                        },
                        new
                        {
                            Id = 10,
                            FoodCost = 3.29m,
                            FoodDesc = "Delicate pastry filled with sweet cream cheese filling.",
                            FoodName = "Cheese Danish",
                            FoodRating = 4,
                            RestId = 2
                        });
                });

            modelBuilder.Entity("FullSD_Project_FoodCapybara.Shared.Domain.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustId")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderPrice")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("OrderStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("StaffId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("FullSD_Project_FoodCapybara.Shared.Domain.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FoodID")
                        .HasColumnType("int");

                    b.Property<int>("OIQuantity")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FoodID");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("FullSD_Project_FoodCapybara.Shared.Domain.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PaymentTotal")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("FullSD_Project_FoodCapybara.Shared.Domain.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("RestAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RestAddress = "TastyVille Street 69 Papa's Mall #01-123",
                            RestCategory = "Fast Food",
                            RestDescription = "Be it for delivery or takeaway from the nearest Papa's pizzeria outlet, we have pizza makers ready to make fresh and hot pizzas to satisfy your cravings.  Enjoy freshly made and oven-baked pizzas by Papa's Pizzeria!",
                            RestImage = "Rest1.png",
                            RestName = "Papa's Pizzeria"
                        },
                        new
                        {
                            Id = 2,
                            RestAddress = "TastyVille Street 69 Papa's Mall #01-124",
                            RestCategory = "Bakeries",
                            RestDescription = "Experience the art of baking at Papa's Bakeria, where each pastry is crafted with passion and expertise. Indulge in our delightful cakes, fresh bread, and savory pastries, we guarantee a journey of exquisite flavors and quality ingredients! Enjoy the warmth of our ovens as we bring you the finest baked goods in TastyVille.",
                            RestImage = "Rest2.png",
                            RestName = "Papa's Bakeria"
                        });
                });

            modelBuilder.Entity("FullSD_Project_FoodCapybara.Shared.Domain.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReviewDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReviewOnRestFoods")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReviewRating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("FullSD_Project_FoodCapybara.Shared.Domain.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool?>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("StaffEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StaffPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StaffPhone")
                        .HasColumnType("int");

                    b.Property<string>("StaffPosition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StaffUsername")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Staffs");
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
                            Id = "adminGUID-20db-474f-8407-5a6b159518ba",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "staffGUID-20db-474f-8407-5a6b159518bb",
                            Name = "Staff",
                            NormalizedName = "STAFF"
                        },
                        new
                        {
                            Id = "userGUID-20db-474f-8407-5a6b159518bb",
                            Name = "User",
                            NormalizedName = "USER"
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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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
                            UserId = "3781efa7-66dc-47f0-860f-e506d04102e4",
                            RoleId = "adminGUID-20db-474f-8407-5a6b159518ba"
                        },
                        new
                        {
                            UserId = "3700efa7-66dc-47f0-860f-e506d04102e4",
                            RoleId = "staffGUID-20db-474f-8407-5a6b159518bb"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("FullSD_Project_FoodCapybara.Shared.Domain.Food", b =>
                {
                    b.HasOne("FullSD_Project_FoodCapybara.Shared.Domain.Restaurant", "Restaurant")
                        .WithMany("Menu")
                        .HasForeignKey("RestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("FullSD_Project_FoodCapybara.Shared.Domain.Order", b =>
                {
                    b.HasOne("FullSD_Project_FoodCapybara.Shared.Domain.Customer", "Customer")
                        .WithMany("CustOrderHistory")
                        .HasForeignKey("CustomerId");

                    b.HasOne("FullSD_Project_FoodCapybara.Shared.Domain.Staff", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("FullSD_Project_FoodCapybara.Shared.Domain.OrderItem", b =>
                {
                    b.HasOne("FullSD_Project_FoodCapybara.Shared.Domain.Food", "Food")
                        .WithMany()
                        .HasForeignKey("FoodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FullSD_Project_FoodCapybara.Shared.Domain.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Food");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("FullSD_Project_FoodCapybara.Shared.Domain.Payment", b =>
                {
                    b.HasOne("FullSD_Project_FoodCapybara.Shared.Domain.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("FullSD_Project_FoodCapybara.Shared.Domain.Review", b =>
                {
                    b.HasOne("FullSD_Project_FoodCapybara.Shared.Domain.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
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
                    b.HasOne("FullSD_Project_FoodCapybara.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("FullSD_Project_FoodCapybara.Server.Models.ApplicationUser", null)
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

                    b.HasOne("FullSD_Project_FoodCapybara.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("FullSD_Project_FoodCapybara.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FullSD_Project_FoodCapybara.Shared.Domain.Customer", b =>
                {
                    b.Navigation("CustOrderHistory");
                });

            modelBuilder.Entity("FullSD_Project_FoodCapybara.Shared.Domain.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("FullSD_Project_FoodCapybara.Shared.Domain.Restaurant", b =>
                {
                    b.Navigation("Menu");
                });
#pragma warning restore 612, 618
        }
    }
}
