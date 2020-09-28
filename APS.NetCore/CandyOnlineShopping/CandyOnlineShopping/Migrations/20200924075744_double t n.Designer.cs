﻿// <auto-generated />
using System;
using CandyOnlineShopping.Models.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CandyOnlineShopping.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200924075744_double t n")]
    partial class doubletn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CandyOnlineShopping.Models.Entity.Candy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CandyId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnName("CandyDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnName("CandyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Candy");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Assorted Chocolate Candy",
                            ImageThumbnailUrl = "\\Images\\thumbnail\\chocolateCandy-small.jpg",
                            ImageUrl = "\\Images\\chocolateCandy.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Assorted Chocolate Candy",
                            Price = 4.95m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Another Assorted Chocolate Candy",
                            ImageThumbnailUrl = "\\Images\\thumbnail\\chocolateCandy2-small.jpg",
                            ImageUrl = "\\Images\\chocolateCandy2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Another Assorted Chocolate Candy",
                            Price = 3.95m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Another Chocolate Candy.",
                            ImageThumbnailUrl = "\\Images\\thumbnail\\chocolateCandy3-small.jpg",
                            ImageUrl = "\\Images\\chocolateCandy3.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Another Chocolate Candy",
                            Price = 5.75m
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "Assorted Fruit Candy",
                            ImageThumbnailUrl = "\\Images\\thumbnail\\fruitCandy-small.jpg",
                            ImageUrl = "\\Images\\fruitCandy.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Assorted Fruit Candy",
                            Price = 3.95m
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "Fruit Candy.",
                            ImageThumbnailUrl = "\\Images\\thumbnail\\fruitCandy2-small.jpg",
                            ImageUrl = "\\Images\\fruitCandy2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Fruit Candy",
                            Price = 7.00m
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Description = "Another Assorted Fruit Candy ",
                            ImageThumbnailUrl = "\\Images\\thumbnail\\fruitCandy3-small.jpg",
                            ImageUrl = "\\Images\\fruitCandy3.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Another Assorted Fruit Candy",
                            Price = 11.25m
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Description = "Assorted Gummy Candy.",
                            ImageThumbnailUrl = "\\Images\\thumbnail\\gummyCandy-small.jpg",
                            ImageUrl = "\\Images\\gummyCandy.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Assorted Gummy Candy",
                            Price = 3.95m
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Description = "Another Assorted Gummy Candy",
                            ImageThumbnailUrl = "\\Images\\thumbnail\\gummyCandy2-small.jpg",
                            ImageUrl = "\\Images\\gummyCandy2.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Another Assorted Gummy Candy",
                            Price = 1.95m
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            Description = "Gummy Candy",
                            ImageThumbnailUrl = "\\Images\\thumbnail\\gummyCandy3-small.jpg",
                            ImageUrl = "\\Images\\gummyCandy3.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Gummy Candy",
                            Price = 13.95m
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 4,
                            Description = "Halloween Candy.",
                            ImageThumbnailUrl = "\\Images\\thumbnail\\halloweenCandy-small.jpg",
                            ImageUrl = "\\Images\\halloweenCandy.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Halloween Candy",
                            Price = 1.95m
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 4,
                            Description = "Assorted Halloween Candy",
                            ImageThumbnailUrl = "\\Images\\thumbnail\\halloweenCandy2-small.jpg",
                            ImageUrl = "\\Images\\halloweenCandy2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Assorted Halloween Candy",
                            Price = 12.95m
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 4,
                            Description = "Another Halloween Candy",
                            ImageThumbnailUrl = "\\Images\\thumbnail\\halloweenCandy3-small.jpg",
                            ImageUrl = "\\Images\\halloweenCandy3.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Another Halloween Candy",
                            Price = 21.95m
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 5,
                            Description = "Hard Candy",
                            ImageThumbnailUrl = "\\Images\\thumbnail\\hardCandy-small.jpg",
                            ImageUrl = "\\Images\\hardCandy.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Hard Candy",
                            Price = 6.95m
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 5,
                            Description = "Another Hard Candy.",
                            ImageThumbnailUrl = "\\Images\\thumbnail\\hardCandy2-small.jpg",
                            ImageUrl = "\\Images\\hardCandy2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Another Hard Candy",
                            Price = 2.95m
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 5,
                            Description = "Best Hard Candy",
                            ImageThumbnailUrl = "\\Images\\thumbnail\\hardCandy3-small.jpg",
                            ImageUrl = "\\Images\\hardCandy3.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Best Hard Candy",
                            Price = 16.95m
                        });
                });

            modelBuilder.Entity("CandyOnlineShopping.Models.Entity.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CategoryId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnName("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnName("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Chocolate Candy",
                            Name = "Chocolate Candy"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Fruit Candy",
                            Name = "Fruit Candy"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Gummy Candy",
                            Name = "Gummy Candy"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Halloween Candy",
                            Name = "Halloween Candy"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Hardy Candy",
                            Name = "Hard Candy"
                        });
                });

            modelBuilder.Entity("CandyOnlineShopping.Models.Entity.ShoppingCartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ShoppingCartItemId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("CandyId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CandyId");

                    b.ToTable("ShoppingCartItem");
                });

            modelBuilder.Entity("CandyOnlineShopping.Models.Entity.Candy", b =>
                {
                    b.HasOne("CandyOnlineShopping.Models.Entity.Category", "Category")
                        .WithMany("Candies")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CandyOnlineShopping.Models.Entity.ShoppingCartItem", b =>
                {
                    b.HasOne("CandyOnlineShopping.Models.Entity.Candy", "Candy")
                        .WithMany()
                        .HasForeignKey("CandyId");
                });
#pragma warning restore 612, 618
        }
    }
}
