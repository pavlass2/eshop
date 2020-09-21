﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApp;

namespace WebApp.Migrations
{
    [DbContext(typeof(ShopDbContext))]
    partial class ShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebApp.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AuthorId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("Descriotion")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("EncryptedId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<int>("Language")
                        .HasColumnType("int");

                    b.Property<string>("PicturePath")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("WebApp.Models.Author", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("WebApp.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AddressCity")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("AddressCountry")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("AddressHouseNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("AddressStreet")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("AddressZip")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("CustomerName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("DateTimeDelivered")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DateTimeDispatched")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DateTimeOrdered")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Delivery")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("EncryptedId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Items")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Payment")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("SecondName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
