﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace WishList.Migrations.WishListDB
{
    [DbContext(typeof(WishListDBContext))]
    [Migration("20201224175917_UserIDcolumn")]
    partial class UserIDcolumn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("WishList.Data.Wish", b =>
                {
                    b.Property<int>("WishID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Plot")
                        .HasColumnType("TEXT");

                    b.Property<string>("PosterURL")
                        .HasColumnType("TEXT");

                    b.Property<string>("Season")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Year")
                        .HasColumnType("TEXT");

                    b.Property<string>("imdbID")
                        .HasColumnType("TEXT");

                    b.Property<string>("totalSeasons")
                        .HasColumnType("TEXT");

                    b.HasKey("WishID");

                    b.ToTable("Wish");

                    b.HasData(
                        new
                        {
                            WishID = 1,
                            Title = "The Grinch",
                            Type = "movie",
                            UserID = "5aa802fc-acbf-478f-9935-b7c1259dc6cf",
                            Year = "2018",
                            imdbID = "tt2709692"
                        },
                        new
                        {
                            WishID = 2,
                            Season = "4",
                            Title = "Mr. Robot",
                            Type = "series",
                            UserID = "732bc22c-8c1a-4cc2-a59e-0a1b20a335d3",
                            Year = "2015-2019",
                            imdbID = "tt4158110"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
