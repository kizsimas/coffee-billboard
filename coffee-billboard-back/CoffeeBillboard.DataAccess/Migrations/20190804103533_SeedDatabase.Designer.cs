﻿// <auto-generated />
using CoffeeBillboard.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoffeeBillboard.DataAccess.Migrations
{
    [DbContext(typeof(CoffeeContext))]
    [Migration("20190804103533_SeedDatabase")]
    partial class SeedDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("CoffeeBillboard.DataAccess.Models.Coffee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImageUrl");

                    b.Property<decimal>("Price");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Coffees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR2XVhqR71ON8Aky8YazLE9TqApKaawKzw-GLn2udgLuRbfxoCSFw",
                            Price = 25.34m,
                            Title = "Great coffee"
                        },
                        new
                        {
                            Id = 2,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/c/c5/Roasted_coffee_beans.jpg",
                            Price = 11.87m,
                            Title = "OK coffee"
                        },
                        new
                        {
                            Id = 3,
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTzvlvuDTx5uXTByWriTSObNuJN4JJfTW61KzYEf-ZvKhpbMhL3",
                            Price = 7.11m,
                            Title = "Subpar coffee"
                        },
                        new
                        {
                            Id = 4,
                            ImageUrl = "https://cdn.shopify.com/s/files/1/2243/9531/products/Coffee_Beans.jpg?v=1518057952",
                            Price = 78.34m,
                            Title = "Amazing coffee"
                        },
                        new
                        {
                            Id = 5,
                            ImageUrl = "http://plantinfo.co.za/admin/ckeditor/kcfinder/upload/images/spent%20coffy%20grounds.jpg",
                            Price = 3.44m,
                            Title = "Second hand coffee"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
