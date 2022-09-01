﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SpaceCart.Data;

namespace SpaceCart.Migrations
{
    [DbContext(typeof(SpaceCartDbContext))]
    [Migration("20220829005356_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("SpaceCart.Models.Database.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(128)
                        .IsUnicode(true)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(32)
                        .IsUnicode(true)
                        .HasColumnType("varchar(32)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Smartphone"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Notebook"
                        },
                        new
                        {
                            Id = 3,
                            Name = "TV"
                        });
                });

            modelBuilder.Entity("SpaceCart.Models.Database.Comment", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("varchar(200)");

                    b.HasKey("ProductId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("SpaceCart.Models.Database.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Path")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Path = "iphonexr.jpg"
                        },
                        new
                        {
                            Id = 2,
                            Path = "samsung10e.jpg"
                        },
                        new
                        {
                            Id = 3,
                            Path = "macbookpro16.jpg"
                        },
                        new
                        {
                            Id = 4,
                            Path = "macbookpro13.jpg"
                        },
                        new
                        {
                            Id = 5,
                            Path = "lgtv.jpg"
                        });
                });

            modelBuilder.Entity("SpaceCart.Models.Database.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<bool?>("CommentsEnabled")
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime");

                    b.Property<int>("CreatorUserId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsUnicode(true)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("ImageId")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(7,2)");

                    b.Property<string>("Producer")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CreatorUserId");

                    b.HasIndex("ImageId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CommentsEnabled = true,
                            CreationTime = new DateTime(2022, 8, 29, 6, 23, 56, 368, DateTimeKind.Local).AddTicks(1103),
                            CreatorUserId = 3,
                            Description = "Example of description about a smartphone.",
                            ImageId = 1,
                            Model = "iPhone XR 64GB",
                            Price = 760.0m,
                            Producer = "Apple"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            CommentsEnabled = true,
                            CreationTime = new DateTime(2022, 8, 29, 6, 23, 56, 368, DateTimeKind.Local).AddTicks(1692),
                            CreatorUserId = 3,
                            Description = "New smartphone Samsung S10e is already in sale.",
                            ImageId = 2,
                            Model = "S10e SM-G970",
                            Price = 650.00m,
                            Producer = "Samsung"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            CommentsEnabled = true,
                            CreationTime = new DateTime(2022, 8, 29, 6, 23, 56, 368, DateTimeKind.Local).AddTicks(1709),
                            CreatorUserId = 3,
                            Description = "New notebook from Apple is already in our store.",
                            ImageId = 3,
                            Model = "Macbook Pro 16\"",
                            Price = 2200.00m,
                            Producer = "Apple"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            CommentsEnabled = true,
                            CreationTime = new DateTime(2022, 8, 29, 6, 23, 56, 368, DateTimeKind.Local).AddTicks(1711),
                            CreatorUserId = 3,
                            Description = "New notebook from Apple is already in our store.",
                            ImageId = 4,
                            Model = "MacBook Pro 13\" Space Gray",
                            Price = 1400.00m,
                            Producer = "Apple"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 3,
                            CommentsEnabled = true,
                            CreationTime = new DateTime(2022, 8, 29, 6, 23, 56, 368, DateTimeKind.Local).AddTicks(1713),
                            CreatorUserId = 3,
                            Description = "New TV with high resolution screen.",
                            ImageId = 5,
                            Model = "43UM7459",
                            Price = 450.00m,
                            Producer = "LG"
                        });
                });

            modelBuilder.Entity("SpaceCart.Models.Database.Purchase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Adress")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime");

                    b.Property<decimal>("FullPrice")
                        .HasColumnType("decimal(8, 2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("SpaceCart.Models.Database.PurchaseProduct", b =>
                {
                    b.Property<int>("PurchaseId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.HasKey("PurchaseId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("PurchaseProducts");
                });

            modelBuilder.Entity("SpaceCart.Models.Database.Rate", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Rates");
                });

            modelBuilder.Entity("SpaceCart.Models.Database.ShoppingCart", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.HasKey("UserId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("SpaceCart.Models.Database.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Adress")
                        .HasMaxLength(256)
                        .IsUnicode(true)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("AuthValue")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasMaxLength(128)
                        .IsUnicode(true)
                        .HasColumnType("varchar(128)");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<string>("PasswordHash")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adress = "",
                            CreationTime = new DateTime(2022, 8, 29, 6, 23, 56, 364, DateTimeKind.Local).AddTicks(1914),
                            Email = "vasylvlasiuk@gmail.com",
                            LastLogin = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Vasyl",
                            PasswordHash = "%�Z҃�@\n�d�mq<�",
                            RoleId = 1,
                            Surname = "Vlasiuk"
                        },
                        new
                        {
                            Id = 2,
                            Adress = "",
                            CreationTime = new DateTime(2022, 8, 29, 6, 23, 56, 367, DateTimeKind.Local).AddTicks(8871),
                            Email = "johndoe@gmail.com",
                            LastLogin = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "John",
                            PasswordHash = "1[��N�W��?�}",
                            RoleId = 2,
                            Surname = "Doe"
                        },
                        new
                        {
                            Id = 3,
                            Adress = "",
                            CreationTime = new DateTime(2022, 8, 29, 6, 23, 56, 367, DateTimeKind.Local).AddTicks(9134),
                            Email = "ostepbondar@gmail.com",
                            LastLogin = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ostap",
                            PasswordHash = "^�g�9ƏQE�/���\"	",
                            RoleId = 3,
                            Surname = "Bondar"
                        });
                });

            modelBuilder.Entity("SpaceCart.Models.Database.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.HasKey("Id");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Name = "Administrator"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Moderator"
                        },
                        new
                        {
                            Id = 1,
                            Name = "SimpleUser"
                        });
                });

            modelBuilder.Entity("SpaceCart.Models.Database.Comment", b =>
                {
                    b.HasOne("SpaceCart.Models.Database.Product", "Product")
                        .WithMany("Comments")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SpaceCart.Models.Database.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SpaceCart.Models.Database.Product", b =>
                {
                    b.HasOne("SpaceCart.Models.Database.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SpaceCart.Models.Database.User", "CreatorUser")
                        .WithMany("Products")
                        .HasForeignKey("CreatorUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SpaceCart.Models.Database.Image", "Image")
                        .WithMany("Products")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("CreatorUser");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("SpaceCart.Models.Database.Purchase", b =>
                {
                    b.HasOne("SpaceCart.Models.Database.User", "User")
                        .WithMany("Purchases")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SpaceCart.Models.Database.PurchaseProduct", b =>
                {
                    b.HasOne("SpaceCart.Models.Database.Product", "Product")
                        .WithMany("PurchaseProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SpaceCart.Models.Database.Purchase", "Purchase")
                        .WithMany("PurchaseProducts")
                        .HasForeignKey("PurchaseId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Purchase");
                });

            modelBuilder.Entity("SpaceCart.Models.Database.Rate", b =>
                {
                    b.HasOne("SpaceCart.Models.Database.Product", "Product")
                        .WithMany("Rates")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SpaceCart.Models.Database.User", "User")
                        .WithMany("Rates")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SpaceCart.Models.Database.ShoppingCart", b =>
                {
                    b.HasOne("SpaceCart.Models.Database.Product", "Product")
                        .WithMany("ShoppingCarts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SpaceCart.Models.Database.User", "User")
                        .WithMany("ShoppingCart")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SpaceCart.Models.Database.User", b =>
                {
                    b.HasOne("SpaceCart.Models.Database.UserRole", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("SpaceCart.Models.Database.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("SpaceCart.Models.Database.Image", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("SpaceCart.Models.Database.Product", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("PurchaseProducts");

                    b.Navigation("Rates");

                    b.Navigation("ShoppingCarts");
                });

            modelBuilder.Entity("SpaceCart.Models.Database.Purchase", b =>
                {
                    b.Navigation("PurchaseProducts");
                });

            modelBuilder.Entity("SpaceCart.Models.Database.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Products");

                    b.Navigation("Purchases");

                    b.Navigation("Rates");

                    b.Navigation("ShoppingCart");
                });

            modelBuilder.Entity("SpaceCart.Models.Database.UserRole", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
