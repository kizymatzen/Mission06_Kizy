﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06_Kizy.Models;

namespace Mission06_Kizy.Migrations
{
    [DbContext(typeof(MovieApplicationContext))]
    partial class MovieApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission06_Kizy.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("ApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("ApplicationId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            ApplicationId = 1,
                            CategoryId = 1,
                            Director = "Joss Whedon",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Avengers, The",
                            Year = 2011
                        },
                        new
                        {
                            ApplicationId = 2,
                            CategoryId = 2,
                            Director = "Joel Schumacher",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Batman & Robin",
                            Year = 1989
                        },
                        new
                        {
                            ApplicationId = 3,
                            CategoryId = 3,
                            Director = "Christopher Nolan",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Batman Begins",
                            Year = 1997
                        });
                });

            modelBuilder.Entity("Mission06_Kizy.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Action"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Adventure"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Animation"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Biography"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Crime"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Documentary"
                        },
                        new
                        {
                            CategoryId = 8,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryId = 9,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryId = 10,
                            CategoryName = "Fantasy"
                        },
                        new
                        {
                            CategoryId = 11,
                            CategoryName = "Film Noir"
                        },
                        new
                        {
                            CategoryId = 12,
                            CategoryName = "History"
                        },
                        new
                        {
                            CategoryId = 13,
                            CategoryName = "Horror"
                        },
                        new
                        {
                            CategoryId = 14,
                            CategoryName = "Music"
                        },
                        new
                        {
                            CategoryId = 15,
                            CategoryName = "Musical"
                        },
                        new
                        {
                            CategoryId = 16,
                            CategoryName = "Mystery"
                        },
                        new
                        {
                            CategoryId = 17,
                            CategoryName = "Miscellaneous"
                        },
                        new
                        {
                            CategoryId = 18,
                            CategoryName = "Romance"
                        },
                        new
                        {
                            CategoryId = 19,
                            CategoryName = "Sci-Fi"
                        },
                        new
                        {
                            CategoryId = 20,
                            CategoryName = "Sport"
                        },
                        new
                        {
                            CategoryId = 21,
                            CategoryName = "Superhero"
                        },
                        new
                        {
                            CategoryId = 22,
                            CategoryName = "Television"
                        },
                        new
                        {
                            CategoryId = 23,
                            CategoryName = "Thriller"
                        },
                        new
                        {
                            CategoryId = 24,
                            CategoryName = "VHS"
                        },
                        new
                        {
                            CategoryId = 25,
                            CategoryName = "War"
                        },
                        new
                        {
                            CategoryId = 26,
                            CategoryName = "Western"
                        },
                        new
                        {
                            CategoryId = 27,
                            CategoryName = "Action/Adventure"
                        });
                });

            modelBuilder.Entity("Mission06_Kizy.Models.ApplicationResponse", b =>
                {
                    b.HasOne("Mission06_Kizy.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
