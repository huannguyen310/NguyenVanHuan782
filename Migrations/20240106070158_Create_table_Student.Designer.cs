﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NguyenVanHuan782.Data;

#nullable disable

namespace NguyenVanHuan782.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240106070158_Create_table_Student")]
    partial class Create_table_Student
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("NguyenVanHuan782.Models.Student", b =>
                {
                    b.Property<string>("StudentID")
                        .HasColumnType("TEXT");

                    b.Property<float>("SDT")
                        .HasColumnType("REAL");

                    b.Property<int>("SoDinhDanh")
                        .HasColumnType("INTEGER");

                    b.HasKey("StudentID");

                    b.ToTable("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
