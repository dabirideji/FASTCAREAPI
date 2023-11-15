﻿// <auto-generated />
using System;
using FastCare.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FastCare.Api.Migrations
{
    [DbContext(typeof(FastCareDbContext))]
    [Migration("20231115190655_Added the Facility Model")]
    partial class AddedtheFacilityModel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FastCare.Domain.Models.Doctor", b =>
                {
                    b.Property<Guid>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Degree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Experience")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ratings")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("FastCare.Domain.Models.Drug", b =>
                {
                    b.Property<Guid>("DrugId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DrugDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DrugImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DrugManufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DrugName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DrugPrice")
                        .HasColumnType("float");

                    b.Property<int>("DrugVolume")
                        .HasColumnType("int");

                    b.Property<int>("DrugWeight")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("DrugId");

                    b.ToTable("Drugs");
                });

            modelBuilder.Entity("FastCare.Domain.Models.Facility", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Availability")
                        .HasColumnType("int");

                    b.Property<double>("BookingPrice")
                        .HasColumnType("float");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("FacilityType")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ratings")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Facilities");
                });
#pragma warning restore 612, 618
        }
    }
}