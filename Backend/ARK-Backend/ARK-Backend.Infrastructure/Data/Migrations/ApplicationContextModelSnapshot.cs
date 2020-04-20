﻿// <auto-generated />
using System;
using ARK_Backend.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ARK_Backend.Infrastructure.Data.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ARK_Backend.Domain.Entities.BusinessUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsEmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BusinessUsers");
                });

            modelBuilder.Entity("ARK_Backend.Domain.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmployeesRoleId")
                        .HasColumnType("int");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("WorkingDayEndTime")
                        .HasColumnType("time(0)");

                    b.Property<TimeSpan>("WorkingDayStartTime")
                        .HasColumnType("time(0)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeesRoleId");

                    b.HasIndex("PersonId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ARK_Backend.Domain.Entities.EmployeesRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BusinessUserId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BusinessUserId");

                    b.ToTable("EmployeesRoles");
                });

            modelBuilder.Entity("ARK_Backend.Domain.Entities.Observation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<int?>("ReaderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("ReaderId");

                    b.ToTable("Observations");
                });

            modelBuilder.Entity("ARK_Backend.Domain.Entities.PersonCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RFIDNumber")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("ARK_Backend.Domain.Entities.Reader", b =>
                {
                    b.Property<int>("ReaderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BusinessUserId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsEntrance")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("SecretHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("SecretSalt")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("ReaderId");

                    b.HasIndex("BusinessUserId");

                    b.ToTable("Readers");
                });

            modelBuilder.Entity("ARK_Backend.Domain.Entities.RestrictedRoleReader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmployeesRoleId")
                        .HasColumnType("int");

                    b.Property<int?>("ReaderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeesRoleId");

                    b.HasIndex("ReaderId");

                    b.ToTable("RestrictedRoleReaders");
                });

            modelBuilder.Entity("ARK_Backend.Domain.Entities.Employee", b =>
                {
                    b.HasOne("ARK_Backend.Domain.Entities.EmployeesRole", "EmployeesRole")
                        .WithMany()
                        .HasForeignKey("EmployeesRoleId");

                    b.HasOne("ARK_Backend.Domain.Entities.PersonCard", "Person")
                        .WithMany("Employees")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("ARK_Backend.Domain.Entities.EmployeesRole", b =>
                {
                    b.HasOne("ARK_Backend.Domain.Entities.BusinessUser", "BusinessUser")
                        .WithMany("EmployeesRoles")
                        .HasForeignKey("BusinessUserId");
                });

            modelBuilder.Entity("ARK_Backend.Domain.Entities.Observation", b =>
                {
                    b.HasOne("ARK_Backend.Domain.Entities.PersonCard", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId");

                    b.HasOne("ARK_Backend.Domain.Entities.Reader", "Reader")
                        .WithMany()
                        .HasForeignKey("ReaderId");
                });

            modelBuilder.Entity("ARK_Backend.Domain.Entities.Reader", b =>
                {
                    b.HasOne("ARK_Backend.Domain.Entities.BusinessUser", "BusinessUser")
                        .WithMany("Readers")
                        .HasForeignKey("BusinessUserId");
                });

            modelBuilder.Entity("ARK_Backend.Domain.Entities.RestrictedRoleReader", b =>
                {
                    b.HasOne("ARK_Backend.Domain.Entities.EmployeesRole", "EmployeesRole")
                        .WithMany("RestrictedRoleReaders")
                        .HasForeignKey("EmployeesRoleId");

                    b.HasOne("ARK_Backend.Domain.Entities.Reader", "Reader")
                        .WithMany("RestrictedRoleReaders")
                        .HasForeignKey("ReaderId");
                });
#pragma warning restore 612, 618
        }
    }
}
