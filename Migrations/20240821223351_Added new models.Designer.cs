﻿// <auto-generated />
using System;
using InventoryManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InventoryManagement.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20240821223351_Added new models")]
    partial class Addednewmodels
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("InventoryManagement.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "electronics"
                        },
                        new
                        {
                            Id = 2,
                            Name = "jewelery"
                        },
                        new
                        {
                            Id = 3,
                            Name = "men's clothing"
                        },
                        new
                        {
                            Id = 4,
                            Name = "women's clothing"
                        });
                });

            modelBuilder.Entity("InventoryManagement.Models.Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.HasIndex("StoreId");

                    b.ToTable("inventories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ProductId = 1,
                            Quantity = 100,
                            StoreId = 1
                        },
                        new
                        {
                            Id = 2,
                            ProductId = 2,
                            Quantity = 100,
                            StoreId = 2
                        },
                        new
                        {
                            Id = 3,
                            ProductId = 3,
                            Quantity = 100,
                            StoreId = 3
                        },
                        new
                        {
                            Id = 4,
                            ProductId = 4,
                            Quantity = 100,
                            StoreId = 4
                        },
                        new
                        {
                            Id = 5,
                            ProductId = 5,
                            Quantity = 100,
                            StoreId = 1
                        },
                        new
                        {
                            Id = 6,
                            ProductId = 6,
                            Quantity = 100,
                            StoreId = 2
                        },
                        new
                        {
                            Id = 7,
                            ProductId = 7,
                            Quantity = 100,
                            StoreId = 3
                        },
                        new
                        {
                            Id = 8,
                            ProductId = 8,
                            Quantity = 100,
                            StoreId = 4
                        },
                        new
                        {
                            Id = 9,
                            ProductId = 9,
                            Quantity = 100,
                            StoreId = 1
                        },
                        new
                        {
                            Id = 10,
                            ProductId = 10,
                            Quantity = 100,
                            StoreId = 2
                        },
                        new
                        {
                            Id = 11,
                            ProductId = 11,
                            Quantity = 100,
                            StoreId = 3
                        },
                        new
                        {
                            Id = 12,
                            ProductId = 12,
                            Quantity = 100,
                            StoreId = 4
                        },
                        new
                        {
                            Id = 13,
                            ProductId = 13,
                            Quantity = 100,
                            StoreId = 1
                        },
                        new
                        {
                            Id = 14,
                            ProductId = 14,
                            Quantity = 100,
                            StoreId = 2
                        },
                        new
                        {
                            Id = 15,
                            ProductId = 15,
                            Quantity = 100,
                            StoreId = 3
                        },
                        new
                        {
                            Id = 16,
                            ProductId = 16,
                            Quantity = 100,
                            StoreId = 4
                        },
                        new
                        {
                            Id = 17,
                            ProductId = 17,
                            Quantity = 100,
                            StoreId = 1
                        },
                        new
                        {
                            Id = 18,
                            ProductId = 18,
                            Quantity = 100,
                            StoreId = 2
                        },
                        new
                        {
                            Id = 19,
                            ProductId = 19,
                            Quantity = 100,
                            StoreId = 3
                        },
                        new
                        {
                            Id = 20,
                            ProductId = 20,
                            Quantity = 100,
                            StoreId = 4
                        });
                });

            modelBuilder.Entity("InventoryManagement.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.ToTable("Location");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressId = 1
                        },
                        new
                        {
                            Id = 2,
                            AddressId = 2
                        },
                        new
                        {
                            Id = 3,
                            AddressId = 3
                        },
                        new
                        {
                            Id = 4,
                            AddressId = 4
                        });
                });

            modelBuilder.Entity("InventoryManagement.Models.LocationAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("LocationAddress");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "London",
                            Country = "United Kingdom",
                            LocationId = 1
                        },
                        new
                        {
                            Id = 2,
                            City = "London",
                            Country = "United Kingdom",
                            LocationId = 2
                        },
                        new
                        {
                            Id = 3,
                            City = "London",
                            Country = "United Kingdom",
                            LocationId = 3
                        },
                        new
                        {
                            Id = 4,
                            City = "London",
                            Country = "United Kingdom",
                            LocationId = 4
                        });
                });

            modelBuilder.Entity("InventoryManagement.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("InventoryManagement.Models.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("InventoryManagement.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("InventoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("ProductPicture")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("InventoryId")
                        .IsUnique();

                    b.ToTable("products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 3,
                            InventoryId = 1,
                            Name = "Fjallraven - Foldsack No. 1 Backpack, Fits 15 Laptops",
                            Price = 109.95m,
                            ProductPicture = "https://fakestoreapi.com/img/81fPKd-2AYL._AC_SL1500_.jpg"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            InventoryId = 2,
                            Name = "Mens Casual Premium Slim Fit T-Shirts",
                            Price = 22.3m,
                            ProductPicture = "https://fakestoreapi.com/img/71-3HjGNDUL._AC_SY879._SX._UX._SY._UY_.jpg"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            InventoryId = 3,
                            Name = "Mens Cotton Jacket",
                            Price = 55.99m,
                            ProductPicture = "https://fakestoreapi.com/img/71li-ujtlUL._AC_UX679_.jpg"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            InventoryId = 4,
                            Name = "Mens Casual Slim Fit",
                            Price = 15.99m,
                            ProductPicture = "https://fakestoreapi.com/img/71YXzeOuslL._AC_UY879_.jpg"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            InventoryId = 5,
                            Name = "John Hardy Women's Legends Naga Gold & Silver Dragon Station Chain Bracelet",
                            Price = 695m,
                            ProductPicture = "https://fakestoreapi.com/img/71pWzhdJNwL._AC_UL640_QL65_ML3_.jpg"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            InventoryId = 6,
                            Name = "Solid Gold Petite Micropave",
                            Price = 168m,
                            ProductPicture = "https://fakestoreapi.com/img/61sbMiUnoGL._AC_UL640_QL65_ML3_.jpg"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            InventoryId = 7,
                            Name = "White Gold Plated Princess",
                            Price = 9.99m,
                            ProductPicture = "https://fakestoreapi.com/img/71YAIFU48IL._AC_UL640_QL65_ML3_.jpg"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            InventoryId = 8,
                            Name = "Pierced Owl Rose Gold Plated Stainless Steel Double",
                            Price = 10.99m,
                            ProductPicture = "https://fakestoreapi.com/img/51UDEzMJVpL._AC_UL640_QL65_ML3_.jpg"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 1,
                            InventoryId = 9,
                            Name = "WD 2TB Elements Portable External Hard Drive - USB 3.0",
                            Price = 64m,
                            ProductPicture = "https://fakestoreapi.com/img/61IBBVJvSDL._AC_SY879_.jpg"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 1,
                            InventoryId = 10,
                            Name = "SanDisk SSD PLUS 1TB Internal SSD - SATA III 6 Gb/s",
                            Price = 109m,
                            ProductPicture = "https://fakestoreapi.com/img/61U7T1koQqL._AC_SX679_.jpg"
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 1,
                            InventoryId = 11,
                            Name = "Silicon Power 256GB SSD 3D NAND A55 SLC Cache Performance Boost SATA III 2.5",
                            Price = 109m,
                            ProductPicture = "https://fakestoreapi.com/img/71kWymZ+c+L._AC_SX679_.jpg"
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 1,
                            InventoryId = 12,
                            Name = "WD 4TB Gaming Drive Works with Playstation 4 Portable External Hard Drive",
                            Price = 114m,
                            ProductPicture = "https://fakestoreapi.com/img/61mtL65D4cL._AC_SX679_.jpg"
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 1,
                            InventoryId = 13,
                            Name = "Acer SB220Q bi 21.5 inches Full HD (1920 x 1080) IPS Ultra-Thin",
                            Price = 599m,
                            ProductPicture = "https://fakestoreapi.com/img/81QpkIctqPL._AC_SX679_.jpg"
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 1,
                            InventoryId = 14,
                            Name = "Samsung 49-Inch CHG90 144Hz Curved Gaming Monitor (LC49HG90DMNXZA) – Super Ultrawide Screen QLED",
                            Price = 999.99m,
                            ProductPicture = "https://fakestoreapi.com/img/81Zt42ioCgL._AC_SX679_.jpg"
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 4,
                            InventoryId = 15,
                            Name = "BIYLACLESEN Women's 3-in-1 Snowboard Jacket Winter Coats",
                            Price = 56.99m,
                            ProductPicture = "https://fakestoreapi.com/img/51Y5NI-I5jL._AC_UX679_.jpg"
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 4,
                            InventoryId = 16,
                            Name = "Lock and Love Women's Removable Hooded Faux Leather Moto Biker Jacket",
                            Price = 29.95m,
                            ProductPicture = "https://fakestoreapi.com/img/81XH0e8fefL._AC_UY879_.jpg"
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 4,
                            InventoryId = 17,
                            Name = "Rain Jacket Women Windbreaker Striped Climbing Raincoats",
                            Price = 39.99m,
                            ProductPicture = "https://fakestoreapi.com/img/71HblAHs5xL._AC_UY879_-2.jpg"
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 4,
                            InventoryId = 18,
                            Name = "MBJ Women's Solid Short Sleeve Boat Neck V",
                            Price = 9.85m,
                            ProductPicture = "https://fakestoreapi.com/img/71z3kpMAYsL._AC_UY879_.jpg"
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 4,
                            InventoryId = 19,
                            Name = "Opna Women's Short Sleeve Moisture",
                            Price = 7.95m,
                            ProductPicture = "https://fakestoreapi.com/img/51eg55uWmdL._AC_UX679_.jpg"
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 4,
                            InventoryId = 20,
                            Name = "DANVOUY Womens T Shirt Casual Cotton Short",
                            Price = 12.99m,
                            ProductPicture = "https://fakestoreapi.com/img/61pHAEJ4NML._AC_UX679_.jpg"
                        });
                });

            modelBuilder.Entity("InventoryManagement.Models.Purchase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("purchases");
                });

            modelBuilder.Entity("InventoryManagement.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Type = "Customer"
                        });
                });

            modelBuilder.Entity("InventoryManagement.Models.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Store");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LocationId = 1,
                            Name = "DripGames"
                        },
                        new
                        {
                            Id = 2,
                            LocationId = 2,
                            Name = "DripGames"
                        },
                        new
                        {
                            Id = 3,
                            LocationId = 3,
                            Name = "DripGames"
                        },
                        new
                        {
                            Id = 4,
                            LocationId = 4,
                            Name = "DripGames"
                        });
                });

            modelBuilder.Entity("InventoryManagement.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users", (string)null);

                    b.HasDiscriminator<int>("UserType");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("InventoryManagement.Models.Admin", b =>
                {
                    b.HasBaseType("InventoryManagement.Models.User");

                    b.HasDiscriminator().HasValue(1);
                });

            modelBuilder.Entity("InventoryManagement.Models.Customer", b =>
                {
                    b.HasBaseType("InventoryManagement.Models.User");

                    b.HasDiscriminator().HasValue(2);
                });

            modelBuilder.Entity("InventoryManagement.Models.Inventory", b =>
                {
                    b.HasOne("InventoryManagement.Models.Store", "Store")
                        .WithMany("Inventories")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Store");
                });

            modelBuilder.Entity("InventoryManagement.Models.Location", b =>
                {
                    b.HasOne("InventoryManagement.Models.LocationAddress", "LocationAddress")
                        .WithOne("Location")
                        .HasForeignKey("InventoryManagement.Models.Location", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LocationAddress");
                });

            modelBuilder.Entity("InventoryManagement.Models.Order", b =>
                {
                    b.HasOne("InventoryManagement.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("InventoryManagement.Models.OrderDetail", b =>
                {
                    b.HasOne("InventoryManagement.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InventoryManagement.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("InventoryManagement.Models.Product", b =>
                {
                    b.HasOne("InventoryManagement.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InventoryManagement.Models.Customer", null)
                        .WithMany("Products")
                        .HasForeignKey("CustomerId");

                    b.HasOne("InventoryManagement.Models.Inventory", "Inventory")
                        .WithOne("Product")
                        .HasForeignKey("InventoryManagement.Models.Product", "InventoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Inventory");
                });

            modelBuilder.Entity("InventoryManagement.Models.Purchase", b =>
                {
                    b.HasOne("InventoryManagement.Models.Order", "order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("order");
                });

            modelBuilder.Entity("InventoryManagement.Models.Store", b =>
                {
                    b.HasOne("InventoryManagement.Models.Location", "Location")
                        .WithMany("Stores")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("InventoryManagement.Models.User", b =>
                {
                    b.HasOne("InventoryManagement.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("InventoryManagement.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("InventoryManagement.Models.Inventory", b =>
                {
                    b.Navigation("Product")
                        .IsRequired();
                });

            modelBuilder.Entity("InventoryManagement.Models.Location", b =>
                {
                    b.Navigation("Stores");
                });

            modelBuilder.Entity("InventoryManagement.Models.LocationAddress", b =>
                {
                    b.Navigation("Location")
                        .IsRequired();
                });

            modelBuilder.Entity("InventoryManagement.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("InventoryManagement.Models.Product", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("InventoryManagement.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("InventoryManagement.Models.Store", b =>
                {
                    b.Navigation("Inventories");
                });

            modelBuilder.Entity("InventoryManagement.Models.Customer", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
