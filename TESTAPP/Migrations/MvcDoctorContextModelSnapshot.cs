﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TESTAPP.Data;

namespace TESTAPP.Migrations
{
    [DbContext(typeof(MvcDoctorContext))]
    partial class MvcDoctorContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TESTAPP.Models.Doctor", b =>
                {
                    b.Property<int>("doctor_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("doctorFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("doctorLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("doctorMidName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("internship")
                        .HasColumnType("int");

                    b.Property<string>("speciality")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("doctor_id");

                    b.ToTable("Doctor");
                });
#pragma warning restore 612, 618
        }
    }
}
