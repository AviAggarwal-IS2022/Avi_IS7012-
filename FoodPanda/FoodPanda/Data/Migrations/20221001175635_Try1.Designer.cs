﻿// <auto-generated />
using System;
using FoodPanda.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FoodPanda.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221001175635_Try1")]
    partial class Try1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FoodPanda.Models.Club", b =>
                {
                    b.Property<int>("ClubId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClubId"), 1L, 1);

                    b.Property<int?>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("ClubName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CuisineId")
                        .HasColumnType("int");

                    b.Property<int?>("DishId")
                        .HasColumnType("int");

                    b.Property<int?>("LiquorId")
                        .HasColumnType("int");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.HasKey("ClubId");

                    b.HasIndex("LocationId");

                    b.ToTable("Club");
                });

            modelBuilder.Entity("FoodPanda.Models.Cuisine", b =>
                {
                    b.Property<int>("CuisineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CuisineId"), 1L, 1);

                    b.Property<int?>("ClubId")
                        .HasColumnType("int");

                    b.Property<string>("CuisineName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("CuisineId");

                    b.HasIndex("ClubId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Cuisine");
                });

            modelBuilder.Entity("FoodPanda.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"), 1L, 1);

                    b.Property<string>("CustomerCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerStreet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("FoodPanda.Models.Dish", b =>
                {
                    b.Property<int>("DishId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DishId"), 1L, 1);

                    b.Property<int?>("ClubId")
                        .HasColumnType("int");

                    b.Property<int?>("CuisineId")
                        .HasColumnType("int");

                    b.Property<string>("DishName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("DishId");

                    b.HasIndex("ClubId");

                    b.HasIndex("CuisineId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Dish");
                });

            modelBuilder.Entity("FoodPanda.Models.Liquor", b =>
                {
                    b.Property<int>("LiquorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LiquorId"), 1L, 1);

                    b.Property<int?>("ClubId")
                        .HasColumnType("int");

                    b.Property<string>("LiquorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LiquorType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LiquorId");

                    b.HasIndex("ClubId");

                    b.ToTable("Liquor");
                });

            modelBuilder.Entity("FoodPanda.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocationId"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocationId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("FoodPanda.Models.Restaurant", b =>
                {
                    b.Property<int>("RestaurantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RestaurantId"), 1L, 1);

                    b.Property<int?>("Capacity")
                        .HasColumnType("int");

                    b.Property<int?>("CuisineId")
                        .HasColumnType("int");

                    b.Property<int?>("DishId")
                        .HasColumnType("int");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("RestaurantName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RestaurantId");

                    b.HasIndex("LocationId");

                    b.ToTable("Restaurant");
                });

            modelBuilder.Entity("FoodPanda.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewId"), 1L, 1);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Feedback")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("ReviewId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Review");
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
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

            modelBuilder.Entity("FoodPanda.Models.Club", b =>
                {
                    b.HasOne("FoodPanda.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("FoodPanda.Models.Cuisine", b =>
                {
                    b.HasOne("FoodPanda.Models.Club", null)
                        .WithMany("Cuisine")
                        .HasForeignKey("ClubId");

                    b.HasOne("FoodPanda.Models.Restaurant", null)
                        .WithMany("Cuisine")
                        .HasForeignKey("RestaurantId");
                });

            modelBuilder.Entity("FoodPanda.Models.Dish", b =>
                {
                    b.HasOne("FoodPanda.Models.Club", null)
                        .WithMany("Dish")
                        .HasForeignKey("ClubId");

                    b.HasOne("FoodPanda.Models.Cuisine", "Cuisine")
                        .WithMany()
                        .HasForeignKey("CuisineId");

                    b.HasOne("FoodPanda.Models.Restaurant", null)
                        .WithMany("Dish")
                        .HasForeignKey("RestaurantId");

                    b.Navigation("Cuisine");
                });

            modelBuilder.Entity("FoodPanda.Models.Liquor", b =>
                {
                    b.HasOne("FoodPanda.Models.Club", null)
                        .WithMany("Liquor")
                        .HasForeignKey("ClubId");
                });

            modelBuilder.Entity("FoodPanda.Models.Restaurant", b =>
                {
                    b.HasOne("FoodPanda.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("FoodPanda.Models.Review", b =>
                {
                    b.HasOne("FoodPanda.Models.Customer", "Customer")
                        .WithMany("Review")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodPanda.Models.Restaurant", "Restaurant")
                        .WithMany("Review")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Restaurant");
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

            modelBuilder.Entity("FoodPanda.Models.Club", b =>
                {
                    b.Navigation("Cuisine");

                    b.Navigation("Dish");

                    b.Navigation("Liquor");
                });

            modelBuilder.Entity("FoodPanda.Models.Customer", b =>
                {
                    b.Navigation("Review");
                });

            modelBuilder.Entity("FoodPanda.Models.Restaurant", b =>
                {
                    b.Navigation("Cuisine");

                    b.Navigation("Dish");

                    b.Navigation("Review");
                });
#pragma warning restore 612, 618
        }
    }
}
