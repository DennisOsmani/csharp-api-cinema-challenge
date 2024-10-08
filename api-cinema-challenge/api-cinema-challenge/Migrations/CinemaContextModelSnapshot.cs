﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using api_cinema_challenge.Data;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    [DbContext(typeof(CinemaContext))]
    partial class CinemaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("api_cinema_challenge.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("createdat");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("phone");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updatedat");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(8936),
                            Email = "John@mail.no",
                            Name = "John Bravo",
                            Phone = "99887766",
                            UpdatedAt = new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(8940)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(8941),
                            Email = "Fly@mail.no",
                            Name = "Thomas Fly",
                            Phone = "98765432",
                            UpdatedAt = new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(8942)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(8943),
                            Email = "Ibb@live.no",
                            Name = "Ibby Secka",
                            Phone = "45094509",
                            UpdatedAt = new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(8944)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("createdat");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("rating");

                    b.Property<int>("RuntimeMins")
                        .HasColumnType("integer")
                        .HasColumnName("runtimeMins");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updatedat");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9249),
                            Description = "Leo in Hollywood",
                            Rating = "9.3",
                            RuntimeMins = 220,
                            Title = "Once Upon A Time In Hollywood",
                            UpdatedAt = new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9250)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9252),
                            Description = "Iron suit man kills enemies.",
                            Rating = "7.3",
                            RuntimeMins = 180,
                            Title = "Iron Man",
                            UpdatedAt = new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9253)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9254),
                            Description = "Man in space",
                            Rating = "8",
                            RuntimeMins = 90,
                            Title = "Interstellar",
                            UpdatedAt = new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9255)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("integer")
                        .HasColumnName("capacity");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("createdat");

                    b.Property<int>("MovieId")
                        .HasColumnType("integer")
                        .HasColumnName("movieid");

                    b.Property<int>("ScreenNumber")
                        .HasColumnType("integer")
                        .HasColumnName("screennumber");

                    b.Property<DateTime>("StartsAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("startsat");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updatedat");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Screenings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 50,
                            CreatedAt = new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9313),
                            MovieId = 1,
                            ScreenNumber = 1,
                            StartsAt = new DateTime(2024, 9, 15, 22, 29, 51, 738, DateTimeKind.Utc).AddTicks(9304),
                            UpdatedAt = new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9314)
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 30,
                            CreatedAt = new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9317),
                            MovieId = 1,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2024, 9, 15, 23, 29, 51, 738, DateTimeKind.Utc).AddTicks(9315),
                            UpdatedAt = new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9317)
                        },
                        new
                        {
                            Id = 3,
                            Capacity = 50,
                            CreatedAt = new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9319),
                            MovieId = 2,
                            ScreenNumber = 3,
                            StartsAt = new DateTime(2024, 9, 15, 23, 29, 51, 738, DateTimeKind.Utc).AddTicks(9318),
                            UpdatedAt = new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9320)
                        },
                        new
                        {
                            Id = 4,
                            Capacity = 25,
                            CreatedAt = new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9322),
                            MovieId = 3,
                            ScreenNumber = 4,
                            StartsAt = new DateTime(2024, 9, 16, 1, 29, 51, 738, DateTimeKind.Utc).AddTicks(9321),
                            UpdatedAt = new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9322)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("createdat");

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer")
                        .HasColumnName("customerid");

                    b.Property<int>("NumSeats")
                        .HasColumnType("integer")
                        .HasColumnName("numseats");

                    b.Property<int>("ScreeningId")
                        .HasColumnType("integer")
                        .HasColumnName("screeningId");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updatedat");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ScreeningId");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9392),
                            CustomerId = 1,
                            NumSeats = 4,
                            ScreeningId = 1,
                            UpdatedAt = new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9401)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9402),
                            CustomerId = 2,
                            NumSeats = 27,
                            ScreeningId = 3,
                            UpdatedAt = new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9403)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9404),
                            CustomerId = 3,
                            NumSeats = 12,
                            ScreeningId = 2,
                            UpdatedAt = new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9405)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.HasOne("api_cinema_challenge.Models.Movie", "Movie")
                        .WithMany("Screenings")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Ticket", b =>
                {
                    b.HasOne("api_cinema_challenge.Models.Customer", "Customer")
                        .WithMany("Tickets")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api_cinema_challenge.Models.Screening", "Screening")
                        .WithMany("Tickets")
                        .HasForeignKey("ScreeningId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Screening");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Customer", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Movie", b =>
                {
                    b.Navigation("Screenings");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
