﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using a;

#nullable disable

namespace MIS3033_002_LC_0918_BradenFisher.Migrations
{
    [DbContext(typeof(StudentGradeDB))]
    partial class StudentGradeDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("a.StudentGrade", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Grade")
                        .HasColumnType("REAL");

                    b.Property<char>("LetterGrade")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("StuGradeTable");
                });
#pragma warning restore 612, 618
        }
    }
}
