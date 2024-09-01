﻿// <auto-generated />
using System;
using HotelReservationSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelReservationSystem.Data.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240901101635_AddFeedbackTable")]
    partial class AddFeedbackTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HotelReservationSystem.Models.Facility", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.ToTable("Facilities");
                });

            modelBuilder.Entity("HotelReservationSystem.Models.Feedback", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("DateSubmitted")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("ReviewText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("HotelReservationSystem.Models.Picture", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("PictureURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("RoomId");

                    b.ToTable("Picture");
                });

            modelBuilder.Entity("HotelReservationSystem.Models.Reservation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ReservationStatus")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("HotelReservationSystem.Models.Room", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.Property<int>("RoomType")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("HotelReservationSystem.Models.RoomFacility", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("FacilityId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("FacilityId");

                    b.HasIndex("RoomId");

                    b.ToTable("RoomFacilities");
                });

            modelBuilder.Entity("HotelReservationSystem.Models.RoomReservation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ReservationId")
                        .HasColumnType("int");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ReservationId");

                    b.HasIndex("RoomId");

                    b.ToTable("RoomReservations");
                });

            modelBuilder.Entity("HotelReservationSystem.Models.Picture", b =>
                {
                    b.HasOne("HotelReservationSystem.Models.Room", "Room")
                        .WithMany("Pictures")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Room");
                });

            modelBuilder.Entity("HotelReservationSystem.Models.RoomFacility", b =>
                {
                    b.HasOne("HotelReservationSystem.Models.Facility", "Facility")
                        .WithMany("RoomFacilities")
                        .HasForeignKey("FacilityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HotelReservationSystem.Models.Room", "Room")
                        .WithMany("RoomFacilities")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Facility");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("HotelReservationSystem.Models.RoomReservation", b =>
                {
                    b.HasOne("HotelReservationSystem.Models.Reservation", "Reservation")
                        .WithMany("RoomReservations")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HotelReservationSystem.Models.Room", "Room")
                        .WithMany("RoomReservations")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Reservation");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("HotelReservationSystem.Models.Facility", b =>
                {
                    b.Navigation("RoomFacilities");
                });

            modelBuilder.Entity("HotelReservationSystem.Models.Reservation", b =>
                {
                    b.Navigation("RoomReservations");
                });

            modelBuilder.Entity("HotelReservationSystem.Models.Room", b =>
                {
                    b.Navigation("Pictures");

                    b.Navigation("RoomFacilities");

                    b.Navigation("RoomReservations");
                });
#pragma warning restore 612, 618
        }
    }
}
