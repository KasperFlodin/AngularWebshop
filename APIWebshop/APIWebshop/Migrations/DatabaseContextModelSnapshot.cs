﻿// <auto-generated />
using APIWebshop.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIWebshop.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("APIWebshop.Database.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Photolink")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "S200",
                            Photolink = "https://aca8cd9d105dbd447097-f6f51e4cef559c9308eef9d726fd38a7.ssl.cf1.rackcdn.com/600262-2.jpg",
                            Price = 3000,
                            Type = "Bed"
                        },
                        new
                        {
                            Id = 2,
                            Name = "WoodTable",
                            Photolink = "https://livin.dk/wp-content/uploads/2020/07/spisebord-lakeret-eg-1.jpg",
                            Price = 1200,
                            Type = "Table"
                        },
                        new
                        {
                            Id = 3,
                            Name = "WoodChair",
                            Photolink = "https://cdn.shopify.com/s/files/1/0810/1821/products/Emma-bla-velour-stol-11706.jpg",
                            Price = 299,
                            Type = "Chair"
                        },
                        new
                        {
                            Id = 4,
                            Name = "PlasticChair",
                            Photolink = "https://cdn.shopify.com/s/files/1/0810/1821/products/Emma-bla-velour-stol-11706.jpg",
                            Price = 99,
                            Type = "Chair"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Sleepr",
                            Photolink = "https://aca8cd9d105dbd447097-f6f51e4cef559c9308eef9d726fd38a7.ssl.cf1.rackcdn.com/600262-2.jpg",
                            Price = 5000,
                            Type = "Bed"
                        },
                        new
                        {
                            Id = 6,
                            Name = "z00",
                            Photolink = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS_1lHnZy9bZidanyjBJr5JiIuSxNX1Y2LM0_HpV1TQrdwMLbUHY1kcfC12pxme6jzb9qw&usqp=CAU",
                            Price = 600,
                            Type = "Fence"
                        });
                });

            modelBuilder.Entity("APIWebshop.Database.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(8)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnType("nvarchar(4)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Meterskoven 1",
                            City = "Byen",
                            Email = "Peter.lund@gmail.com",
                            FirstName = "Peter",
                            LastName = "Lund",
                            Password = "123456",
                            Phone = "12345678",
                            Role = 0,
                            Zip = "4321"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Skoven 2",
                            City = "Tarn",
                            Email = "Simon.green@gmail.com",
                            FirstName = "Simon",
                            LastName = "Green",
                            Password = "123456",
                            Phone = "11223344",
                            Role = 1,
                            Zip = "1144"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
