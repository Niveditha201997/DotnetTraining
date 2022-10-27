﻿// <auto-generated />
using System;
using FoodManagementData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FoodManagementData.Migrations
{
    [DbContext(typeof(FoodDbContext))]
    [Migration("20221004051946_FoodDbCreate")]
    partial class FoodDbCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("FoodManagementEntity.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AdminEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminPassword")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminId");

                    b.ToTable("admins");
                });

            modelBuilder.Entity("FoodManagementEntity.FoodCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FoodName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.ToTable("foodCategories");
                });

            modelBuilder.Entity("FoodManagementEntity.FoodItem", b =>
                {
                    b.Property<int>("SINo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("FoodName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("foodCategoryCategoryId")
                        .HasColumnType("int");

                    b.HasKey("SINo");

                    b.HasIndex("foodCategoryCategoryId");

                    b.ToTable("foodItems");
                });

            modelBuilder.Entity("FoodManagementEntity.FoodSales", b =>
                {
                    b.Property<int>("SalesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FoodName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("foodCategoryCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SalesId");

                    b.HasIndex("foodCategoryCategoryId");

                    b.ToTable("foodSales");
                });

            modelBuilder.Entity("FoodManagementEntity.FoodItem", b =>
                {
                    b.HasOne("FoodManagementEntity.FoodCategory", "foodCategory")
                        .WithMany()
                        .HasForeignKey("foodCategoryCategoryId");

                    b.Navigation("foodCategory");
                });

            modelBuilder.Entity("FoodManagementEntity.FoodSales", b =>
                {
                    b.HasOne("FoodManagementEntity.FoodCategory", "foodCategory")
                        .WithMany()
                        .HasForeignKey("foodCategoryCategoryId");

                    b.Navigation("foodCategory");
                });
#pragma warning restore 612, 618
        }
    }
}