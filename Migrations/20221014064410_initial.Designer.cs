﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TE_CODEFIRST.Data;

#nullable disable

namespace TE_CODEFIRST.Migrations
{
    [DbContext(typeof(TraineeDbContext))]
    [Migration("20221014064410_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TE_CODEFIRST.Models.Trainee", b =>
                {
                    b.Property<int>("TraineeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TraineeID"), 1L, 1);

                    b.Property<int>("TraineeAge")
                        .HasColumnType("int");

                    b.Property<string>("TraineeConfirmPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TraineeDOB")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TraineeDOJ")
                        .HasColumnType("datetime2");

                    b.Property<string>("TraineeEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TraineeMobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TraineeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TraineePassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TraineeID");

                    b.ToTable("Trainees");
                });
#pragma warning restore 612, 618
        }
    }
}
