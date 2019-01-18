﻿// <auto-generated />
using System;
using CakesWebApplication.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CakesWebApplication.Migrations
{
    [DbContext(typeof(PiesDbContext))]
    [Migration("20190116104842_addedShopingCart2")]
    partial class addedShopingCart2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CakesWebApplication.Models.CategoryDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("CakesWebApplication.Models.PieDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AllergyInformation");

                    b.Property<int>("CategoryId");

                    b.Property<string>("ImageThumbnailUrl");

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("InStock");

                    b.Property<bool>("IsPieOfTheWeek");

                    b.Property<string>("LongDescription");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<string>("ShortDescription");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Pies");
                });

            modelBuilder.Entity("CakesWebApplication.Models.ShoppingCartItemDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<string>("ShoppingCartId");

                    b.Property<int?>("pieId");

                    b.HasKey("Id");

                    b.HasIndex("pieId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("CakesWebApplication.Models.PieDto", b =>
                {
                    b.HasOne("CakesWebApplication.Models.CategoryDto", "Category")
                        .WithMany("Pies")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CakesWebApplication.Models.ShoppingCartItemDto", b =>
                {
                    b.HasOne("CakesWebApplication.Models.PieDto", "pie")
                        .WithMany()
                        .HasForeignKey("pieId");
                });
#pragma warning restore 612, 618
        }
    }
}