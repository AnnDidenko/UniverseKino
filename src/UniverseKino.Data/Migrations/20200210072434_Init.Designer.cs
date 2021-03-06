﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UniverseKino.Data.EF;

namespace UniverseKino.Data.Migrations
{
    [DbContext(typeof(UniverseKinoContext))]
    [Migration("20200210072434_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UniverseKino.Data.Entities.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ApplicationUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DOB = new DateTime(2000, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "vampir@gmail.com",
                            FirstName = "Dima",
                            LastName = "Ozimai",
                            Password = "10000.YtluDYCFuMVvIfbGlph5wQ==.ScjIgCaNq6qA5oNP0AbcKK/LsREaE9uJHL4QAxVIUJk=",
                            PhoneNumber = "+380992413442",
                            Role = "Admin",
                            Username = "Ozzmos"
                        });
                });

            modelBuilder.Entity("UniverseKino.Data.Entities.CinemaHall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CinemaHalls");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Number = 1
                        },
                        new
                        {
                            Id = 2,
                            Number = 2
                        },
                        new
                        {
                            Id = 3,
                            Number = 3
                        },
                        new
                        {
                            Id = 4,
                            Number = 4
                        });
                });

            modelBuilder.Entity("UniverseKino.Data.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Duration = 182,
                            Genre = "Action, superhero, adventure, science fiction, fantasy",
                            Name = "Avengers"
                        },
                        new
                        {
                            Id = 2,
                            Duration = 131,
                            Genre = "Crime, drama, mysticism",
                            Name = "Knives"
                        },
                        new
                        {
                            Id = 3,
                            Duration = 124,
                            Genre = "Action, comedy, crime",
                            Name = "Bad boys"
                        });
                });

            modelBuilder.Entity("UniverseKino.Data.Entities.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Paid")
                        .HasColumnType("bit");

                    b.Property<int>("SeatId")
                        .HasColumnType("int");

                    b.Property<int>("SessionId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("UserNameId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SeatId");

                    b.HasIndex("SessionId");

                    b.HasIndex("UserNameId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("UniverseKino.Data.Entities.Seat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CinemaHallId")
                        .HasColumnType("int");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("IdCinemaHall")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("Row")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CinemaHallId");

                    b.ToTable("Seats");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cost = 100m,
                            IdCinemaHall = 1,
                            Number = 1,
                            Row = 1
                        },
                        new
                        {
                            Id = 2,
                            Cost = 100m,
                            IdCinemaHall = 1,
                            Number = 1,
                            Row = 2
                        },
                        new
                        {
                            Id = 3,
                            Cost = 100m,
                            IdCinemaHall = 1,
                            Number = 1,
                            Row = 3
                        },
                        new
                        {
                            Id = 4,
                            Cost = 100m,
                            IdCinemaHall = 1,
                            Number = 1,
                            Row = 4
                        },
                        new
                        {
                            Id = 5,
                            Cost = 100m,
                            IdCinemaHall = 1,
                            Number = 1,
                            Row = 5
                        },
                        new
                        {
                            Id = 6,
                            Cost = 100m,
                            IdCinemaHall = 1,
                            Number = 1,
                            Row = 6
                        },
                        new
                        {
                            Id = 7,
                            Cost = 100m,
                            IdCinemaHall = 1,
                            Number = 1,
                            Row = 7
                        },
                        new
                        {
                            Id = 8,
                            Cost = 100m,
                            IdCinemaHall = 1,
                            Number = 1,
                            Row = 1
                        },
                        new
                        {
                            Id = 9,
                            Cost = 100m,
                            IdCinemaHall = 1,
                            Number = 1,
                            Row = 2
                        },
                        new
                        {
                            Id = 10,
                            Cost = 100m,
                            IdCinemaHall = 1,
                            Number = 1,
                            Row = 3
                        },
                        new
                        {
                            Id = 11,
                            Cost = 100m,
                            IdCinemaHall = 1,
                            Number = 1,
                            Row = 4
                        },
                        new
                        {
                            Id = 12,
                            Cost = 100m,
                            IdCinemaHall = 1,
                            Number = 1,
                            Row = 5
                        },
                        new
                        {
                            Id = 13,
                            Cost = 150m,
                            IdCinemaHall = 1,
                            Number = 1,
                            Row = 1
                        },
                        new
                        {
                            Id = 14,
                            Cost = 150m,
                            IdCinemaHall = 1,
                            Number = 1,
                            Row = 2
                        },
                        new
                        {
                            Id = 15,
                            Cost = 150m,
                            IdCinemaHall = 1,
                            Number = 1,
                            Row = 3
                        },
                        new
                        {
                            Id = 16,
                            Cost = 150m,
                            IdCinemaHall = 1,
                            Number = 1,
                            Row = 4
                        },
                        new
                        {
                            Id = 17,
                            Cost = 150m,
                            IdCinemaHall = 1,
                            Number = 1,
                            Row = 5
                        },
                        new
                        {
                            Id = 18,
                            Cost = 150m,
                            IdCinemaHall = 1,
                            Number = 1,
                            Row = 6
                        },
                        new
                        {
                            Id = 19,
                            Cost = 150m,
                            IdCinemaHall = 1,
                            Number = 1,
                            Row = 7
                        },
                        new
                        {
                            Id = 20,
                            Cost = 150m,
                            IdCinemaHall = 1,
                            Number = 1,
                            Row = 8
                        },
                        new
                        {
                            Id = 21,
                            Cost = 150m,
                            IdCinemaHall = 1,
                            Number = 1,
                            Row = 9
                        },
                        new
                        {
                            Id = 22,
                            Cost = 150m,
                            IdCinemaHall = 1,
                            Number = 1,
                            Row = 10
                        },
                        new
                        {
                            Id = 23,
                            Cost = 200m,
                            IdCinemaHall = 1,
                            Number = 1,
                            Row = 1
                        },
                        new
                        {
                            Id = 24,
                            Cost = 200m,
                            IdCinemaHall = 1,
                            Number = 1,
                            Row = 2
                        },
                        new
                        {
                            Id = 25,
                            Cost = 200m,
                            IdCinemaHall = 1,
                            Number = 1,
                            Row = 3
                        },
                        new
                        {
                            Id = 26,
                            Cost = 200m,
                            IdCinemaHall = 1,
                            Number = 1,
                            Row = 4
                        },
                        new
                        {
                            Id = 27,
                            Cost = 200m,
                            IdCinemaHall = 1,
                            Number = 1,
                            Row = 5
                        },
                        new
                        {
                            Id = 28,
                            Cost = 200m,
                            IdCinemaHall = 1,
                            Number = 1,
                            Row = 6
                        },
                        new
                        {
                            Id = 29,
                            Cost = 200m,
                            IdCinemaHall = 1,
                            Number = 1,
                            Row = 7
                        },
                        new
                        {
                            Id = 30,
                            Cost = 200m,
                            IdCinemaHall = 1,
                            Number = 1,
                            Row = 8
                        },
                        new
                        {
                            Id = 31,
                            Cost = 200m,
                            IdCinemaHall = 1,
                            Number = 1,
                            Row = 9
                        });
                });

            modelBuilder.Entity("UniverseKino.Data.Entities.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CinemaHallId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CinemaHallId");

                    b.HasIndex("MovieId");

                    b.ToTable("Sessions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CinemaHallId = 1,
                            Date = new DateTime(2020, 2, 11, 18, 24, 34, 24, DateTimeKind.Local).AddTicks(7909),
                            MovieId = 1
                        },
                        new
                        {
                            Id = 2,
                            CinemaHallId = 3,
                            Date = new DateTime(2020, 2, 13, 18, 24, 34, 27, DateTimeKind.Local).AddTicks(4217),
                            MovieId = 1
                        },
                        new
                        {
                            Id = 3,
                            CinemaHallId = 3,
                            Date = new DateTime(2020, 2, 15, 18, 24, 34, 27, DateTimeKind.Local).AddTicks(4274),
                            MovieId = 1
                        },
                        new
                        {
                            Id = 4,
                            CinemaHallId = 1,
                            Date = new DateTime(2020, 2, 11, 21, 24, 34, 27, DateTimeKind.Local).AddTicks(4280),
                            MovieId = 2
                        });
                });

            modelBuilder.Entity("UniverseKino.Data.Entities.Reservation", b =>
                {
                    b.HasOne("UniverseKino.Data.Entities.Seat", "Seat")
                        .WithMany()
                        .HasForeignKey("SeatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniverseKino.Data.Entities.Session", "Session")
                        .WithMany("Reservations")
                        .HasForeignKey("SessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniverseKino.Data.Entities.ApplicationUser", "UserName")
                        .WithMany("Reservations")
                        .HasForeignKey("UserNameId");
                });

            modelBuilder.Entity("UniverseKino.Data.Entities.Seat", b =>
                {
                    b.HasOne("UniverseKino.Data.Entities.CinemaHall", "CinemaHall")
                        .WithMany("Seats")
                        .HasForeignKey("CinemaHallId");
                });

            modelBuilder.Entity("UniverseKino.Data.Entities.Session", b =>
                {
                    b.HasOne("UniverseKino.Data.Entities.CinemaHall", "CinemaHall")
                        .WithMany("Sessions")
                        .HasForeignKey("CinemaHallId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniverseKino.Data.Entities.Movie", "Movie")
                        .WithMany("Sessions")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
