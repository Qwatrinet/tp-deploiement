﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Products.Api.Db;

#nullable disable

namespace Products.Api.Migrations
{
    [DbContext(typeof(ProductsDbContext))]
    [Migration("20250305084853_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Products.Api.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Eau de Javel",
                            Price = 1.8899999999999999
                        },
                        new
                        {
                            Id = 2,
                            Name = "Savon de Marseille",
                            Price = 3.4900000000000002
                        },
                        new
                        {
                            Id = 3,
                            Name = "Vinaigre blanc",
                            Price = 0.98999999999999999
                        },
                        new
                        {
                            Id = 4,
                            Name = "Bicarbonate de soude",
                            Price = 1.55
                        },
                        new
                        {
                            Id = 5,
                            Name = "Éponge multifonctions",
                            Price = 1.24
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
