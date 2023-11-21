﻿// <auto-generated />
using System;
using BoatRental.ef;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BoatRental.ef.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BoatRental.core.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("BoatRental.core.Models.Offer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("offers");
                });

            modelBuilder.Entity("BoatRental.core.Models.Package", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OfferId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OfferId");

                    b.ToTable("packages");
                });

            modelBuilder.Entity("BoatRental.core.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("User")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("User");

                    b.ToTable("reservations");
                });

            modelBuilder.Entity("BoatRental.core.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("services");
                });

            modelBuilder.Entity("BoatRental.core.Models.ServicePackage", b =>
                {
                    b.Property<int>("serviceId")
                        .HasColumnType("int");

                    b.Property<int>("packageId")
                        .HasColumnType("int");

                    b.HasKey("serviceId", "packageId");

                    b.HasIndex("packageId");

                    b.ToTable("ServicePackage");
                });

            modelBuilder.Entity("BoatRental.core.Models.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VehicleId")
                        .IsUnique();

                    b.ToTable("staffs");
                });

            modelBuilder.Entity("BoatRental.core.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("BoatRental.core.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("ReservationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Year")
                        .HasColumnType("datetime2");

                    b.Property<int>("ownerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ReservationId");

                    b.HasIndex("ownerId");

                    b.ToTable("vehicles");
                });

            modelBuilder.Entity("BoatRental.core.Models.VehicleService", b =>
                {
                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<int>("vechicleId")
                        .HasColumnType("int");

                    b.Property<double>("Cost")
                        .HasColumnType("float");

                    b.Property<DateTime>("ServiceDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("vehicleId")
                        .HasColumnType("int");

                    b.HasKey("ServiceId", "vechicleId");

                    b.HasIndex("vehicleId");

                    b.ToTable("vehicleServices");
                });

            modelBuilder.Entity("BoatRental.core.Models.Owner", b =>
                {
                    b.HasBaseType("BoatRental.core.Models.User");

                    b.HasDiscriminator().HasValue("Owner");
                });

            modelBuilder.Entity("BoatRental.core.Models.Offer", b =>
                {
                    b.HasOne("BoatRental.core.Models.Owner", null)
                        .WithMany("Offers")
                        .HasForeignKey("OwnerId");
                });

            modelBuilder.Entity("BoatRental.core.Models.Package", b =>
                {
                    b.HasOne("BoatRental.core.Models.Offer", null)
                        .WithMany("Packages")
                        .HasForeignKey("OfferId");
                });

            modelBuilder.Entity("BoatRental.core.Models.Reservation", b =>
                {
                    b.HasOne("BoatRental.core.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("User")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("BoatRental.core.Models.ServicePackage", b =>
                {
                    b.HasOne("BoatRental.core.Models.Package", "package")
                        .WithMany("servicePackages")
                        .HasForeignKey("packageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BoatRental.core.Models.Service", "service")
                        .WithMany("servicePackages")
                        .HasForeignKey("serviceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("package");

                    b.Navigation("service");
                });

            modelBuilder.Entity("BoatRental.core.Models.Staff", b =>
                {
                    b.HasOne("BoatRental.core.Models.Vehicle", "vehicle")
                        .WithOne("staff")
                        .HasForeignKey("BoatRental.core.Models.Staff", "VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("vehicle");
                });

            modelBuilder.Entity("BoatRental.core.Models.Vehicle", b =>
                {
                    b.HasOne("BoatRental.core.Models.Category", "category")
                        .WithMany("Vehicles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BoatRental.core.Models.Reservation", null)
                        .WithMany("Vehicles")
                        .HasForeignKey("ReservationId");

                    b.HasOne("BoatRental.core.Models.Owner", "owner")
                        .WithMany("Vehicles")
                        .HasForeignKey("ownerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");

                    b.Navigation("owner");
                });

            modelBuilder.Entity("BoatRental.core.Models.VehicleService", b =>
                {
                    b.HasOne("BoatRental.core.Models.Service", "service")
                        .WithMany("VehicleServices")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BoatRental.core.Models.Vehicle", "vehicle")
                        .WithMany("VehicleServices")
                        .HasForeignKey("vehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("service");

                    b.Navigation("vehicle");
                });

            modelBuilder.Entity("BoatRental.core.Models.Category", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("BoatRental.core.Models.Offer", b =>
                {
                    b.Navigation("Packages");
                });

            modelBuilder.Entity("BoatRental.core.Models.Package", b =>
                {
                    b.Navigation("servicePackages");
                });

            modelBuilder.Entity("BoatRental.core.Models.Reservation", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("BoatRental.core.Models.Service", b =>
                {
                    b.Navigation("VehicleServices");

                    b.Navigation("servicePackages");
                });

            modelBuilder.Entity("BoatRental.core.Models.Vehicle", b =>
                {
                    b.Navigation("VehicleServices");

                    b.Navigation("staff")
                        .IsRequired();
                });

            modelBuilder.Entity("BoatRental.core.Models.Owner", b =>
                {
                    b.Navigation("Offers");

                    b.Navigation("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
