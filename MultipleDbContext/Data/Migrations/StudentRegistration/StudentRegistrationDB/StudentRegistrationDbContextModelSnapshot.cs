﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MultipleDbContext.Models;

namespace MultipleDbContext.Data.Migrations.StudentRegistration.StudentRegistrationDB
{
    [DbContext(typeof(StudentRegistrationDbContext))]
    partial class StudentRegistrationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MultipleDbContext.Models.RegistrationSchool.Employees", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<int>("Age");

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("Email");

                    b.Property<string>("EmployeeName");

                    b.Property<string>("MotherName");

                    b.Property<int>("PhoneNumber");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("MultipleDbContext.Models.RegistrationSchool.Students", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<int>("Age");

                    b.Property<DateTime>("BirthDate");

                    b.Property<int>("ClassName");

                    b.Property<string>("Email");

                    b.Property<string>("MotherName");

                    b.Property<int>("PhoneNumber");

                    b.Property<int>("Rangking");

                    b.Property<string>("StudentName");

                    b.HasKey("StudentID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("MultipleDbContext.Models.RegistrationSchool.Teachers", b =>
                {
                    b.Property<int>("TeachersID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<int>("Age");

                    b.Property<DateTime>("BirthDate");

                    b.Property<int>("ClassName");

                    b.Property<int>("ClassSubject");

                    b.Property<string>("Email");

                    b.Property<string>("MotherName");

                    b.Property<int>("PhoneNumber");

                    b.Property<int>("Rangking");

                    b.Property<string>("TeachersName");

                    b.HasKey("TeachersID");

                    b.ToTable("Teachers");
                });
#pragma warning restore 612, 618
        }
    }
}
