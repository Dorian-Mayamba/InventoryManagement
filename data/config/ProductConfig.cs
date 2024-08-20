using System.Diagnostics;
using InventoryManagement.Dtos.Products;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using AutoMapper;
using System.Diagnostics.Contracts;

namespace InventoryManagement.Data.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {


        public void Configure(EntityTypeBuilder<Product> builder)
        {

            builder.HasMany(p => p.Sales)
            .WithOne(s => s.product)
            .HasForeignKey(s => s.ProductId);

            builder.HasOne(p => p.Inventory)
            .WithOne(i => i.Product)
            .HasForeignKey<Product>("InventoryId");

            builder.HasOne(p => p.Category)
            .WithMany(c => c.Products)
            .HasForeignKey(p => p.CategoryId);

            builder.HasData(
                new Product() { Id = 1, Name = "Fjallraven - Foldsack No. 1 Backpack, Fits 15 Laptops", Price = 109.95m, CategoryId = 3, ProductPicture = "https://fakestoreapi.com/img/81fPKd-2AYL._AC_SL1500_.jpg", InventoryId = 1 },
                new Product() { Id = 2, Name = "Mens Casual Premium Slim Fit T-Shirts", Price = 22.3m, CategoryId = 3, ProductPicture = "https://fakestoreapi.com/img/71-3HjGNDUL._AC_SY879._SX._UX._SY._UY_.jpg", InventoryId = 2 },
                new Product() { Id = 3, Name = "Mens Cotton Jacket", Price = 55.99m, CategoryId = 3, ProductPicture = "https://fakestoreapi.com/img/71li-ujtlUL._AC_UX679_.jpg", InventoryId = 3 },
                new Product() { Id = 4, Name = "Mens Casual Slim Fit", Price = 15.99m, CategoryId = 3, ProductPicture = "https://fakestoreapi.com/img/71YXzeOuslL._AC_UY879_.jpg", InventoryId = 4 },
                new Product() { Id = 5, Name = "John Hardy Women's Legends Naga Gold & Silver Dragon Station Chain Bracelet", Price = 695, CategoryId = 2, ProductPicture = "https://fakestoreapi.com/img/71pWzhdJNwL._AC_UL640_QL65_ML3_.jpg", InventoryId = 5 },
                new Product() { Id = 6, Name = "Solid Gold Petite Micropave", Price = 168, CategoryId = 2, ProductPicture = "https://fakestoreapi.com/img/61sbMiUnoGL._AC_UL640_QL65_ML3_.jpg", InventoryId = 6 },
                new Product() { Id = 7, Name = "White Gold Plated Princess", Price = 9.99m, CategoryId = 2, ProductPicture = "https://fakestoreapi.com/img/71YAIFU48IL._AC_UL640_QL65_ML3_.jpg", InventoryId = 7 },
                new Product() { Id = 8, Name = "Pierced Owl Rose Gold Plated Stainless Steel Double", Price = 10.99m, CategoryId = 2, ProductPicture = "https://fakestoreapi.com/img/51UDEzMJVpL._AC_UL640_QL65_ML3_.jpg", InventoryId = 8 },
                new Product() { Id = 9, Name = "WD 2TB Elements Portable External Hard Drive - USB 3.0", Price = 64, CategoryId = 1, ProductPicture = "https://fakestoreapi.com/img/61IBBVJvSDL._AC_SY879_.jpg", InventoryId = 9 },
                new Product() { Id = 10, Name = "SanDisk SSD PLUS 1TB Internal SSD - SATA III 6 Gb/s", Price = 109, CategoryId = 1, ProductPicture = "https://fakestoreapi.com/img/61U7T1koQqL._AC_SX679_.jpg", InventoryId = 10 },
                new Product() { Id = 11, Name = "Silicon Power 256GB SSD 3D NAND A55 SLC Cache Performance Boost SATA III 2.5", Price = 109, CategoryId = 1, ProductPicture = "https://fakestoreapi.com/img/71kWymZ+c+L._AC_SX679_.jpg", InventoryId = 11 },
                new Product() { Id = 12, Name = "WD 4TB Gaming Drive Works with Playstation 4 Portable External Hard Drive", Price = 114, CategoryId = 1, ProductPicture = "https://fakestoreapi.com/img/61mtL65D4cL._AC_SX679_.jpg", InventoryId = 12 },
                new Product() { Id = 13, Name = "Acer SB220Q bi 21.5 inches Full HD (1920 x 1080) IPS Ultra-Thin", Price = 599, CategoryId = 1, ProductPicture = "https://fakestoreapi.com/img/81QpkIctqPL._AC_SX679_.jpg", InventoryId = 13 },
                new Product() { Id = 14, Name = "Samsung 49-Inch CHG90 144Hz Curved Gaming Monitor (LC49HG90DMNXZA) – Super Ultrawide Screen QLED", Price = 999.99m, CategoryId = 1, ProductPicture = "https://fakestoreapi.com/img/81Zt42ioCgL._AC_SX679_.jpg", InventoryId = 14 },
                new Product() { Id = 15, Name = "BIYLACLESEN Women's 3-in-1 Snowboard Jacket Winter Coats", Price = 56.99m, CategoryId = 4, ProductPicture = "https://fakestoreapi.com/img/51Y5NI-I5jL._AC_UX679_.jpg", InventoryId = 15 },
                new Product() { Id = 16, Name = "Lock and Love Women's Removable Hooded Faux Leather Moto Biker Jacket", Price = 29.95m, CategoryId = 4, ProductPicture = "https://fakestoreapi.com/img/81XH0e8fefL._AC_UY879_.jpg", InventoryId = 16 },
                new Product() { Id = 17, Name = "Rain Jacket Women Windbreaker Striped Climbing Raincoats", Price = 39.99m, CategoryId = 4, ProductPicture = "https://fakestoreapi.com/img/71HblAHs5xL._AC_UY879_-2.jpg", InventoryId = 17 },
                new Product() { Id = 18, Name = "MBJ Women's Solid Short Sleeve Boat Neck V", Price = 9.85m, CategoryId = 4, ProductPicture = "https://fakestoreapi.com/img/71z3kpMAYsL._AC_UY879_.jpg", InventoryId = 18 },
                new Product() { Id = 19, Name = "Opna Women's Short Sleeve Moisture", Price = 7.95m, CategoryId = 4, ProductPicture = "https://fakestoreapi.com/img/51eg55uWmdL._AC_UX679_.jpg", InventoryId = 19 },
                new Product() { Id = 20, Name = "DANVOUY Womens T Shirt Casual Cotton Short", Price = 12.99m, CategoryId = 4, ProductPicture = "https://fakestoreapi.com/img/61pHAEJ4NML._AC_UX679_.jpg", InventoryId = 20 }
            );
        }
    }
}