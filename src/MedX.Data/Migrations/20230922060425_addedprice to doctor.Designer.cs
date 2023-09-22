﻿// <auto-generated />
using System;
using MedX.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MedX.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230922060425_addedprice to doctor")]
    partial class addedpricetodoctor
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MedX.Domain.Enitities.Appointment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Disease")
                        .HasColumnType("text");

                    b.Property<long>("DoctorId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<long>("PatientId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("MedX.Domain.Enitities.Doctor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("Professional")
                        .HasColumnType("text");

                    b.Property<long>("RoomId")
                        .HasColumnType("bigint");

                    b.Property<string>("SurName")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("MedX.Domain.Enitities.Patient", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("DoctorId")
                        .HasColumnType("bigint");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<int>("Gender")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<string>("Pinfl")
                        .HasColumnType("text");

                    b.Property<long?>("RoomId")
                        .HasColumnType("bigint");

                    b.Property<string>("SurName")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("RoomId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("MedX.Domain.Enitities.Payment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<long>("AppointmentId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("boolean");

                    b.Property<string>("PaymentFor")
                        .HasColumnType("text");

                    b.Property<int>("TypeOfPayment")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("MedX.Domain.Enitities.Room", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("MedX.Domain.Enitities.Transaction", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("DoctorId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<long>("PatientId")
                        .HasColumnType("bigint");

                    b.Property<long>("PaymentId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.HasIndex("PaymentId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("MedX.Domain.Enitities.Treatment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("DoctorId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<long>("PatientId")
                        .HasColumnType("bigint");

                    b.Property<long>("RoomId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.HasIndex("RoomId");

                    b.ToTable("Treatments");
                });

            modelBuilder.Entity("MedX.Domain.Enitities.Appointment", b =>
                {
                    b.HasOne("MedX.Domain.Enitities.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MedX.Domain.Enitities.Patient", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("MedX.Domain.Enitities.Doctor", b =>
                {
                    b.HasOne("MedX.Domain.Enitities.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("MedX.Domain.Enitities.Patient", b =>
                {
                    b.HasOne("MedX.Domain.Enitities.Doctor", null)
                        .WithMany("Patients")
                        .HasForeignKey("DoctorId");

                    b.HasOne("MedX.Domain.Enitities.Room", null)
                        .WithMany("Patients")
                        .HasForeignKey("RoomId");
                });

            modelBuilder.Entity("MedX.Domain.Enitities.Payment", b =>
                {
                    b.HasOne("MedX.Domain.Enitities.Appointment", "Appointment")
                        .WithMany()
                        .HasForeignKey("AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Appointment");
                });

            modelBuilder.Entity("MedX.Domain.Enitities.Transaction", b =>
                {
                    b.HasOne("MedX.Domain.Enitities.Doctor", "Doctor")
                        .WithMany("Transactions")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MedX.Domain.Enitities.Patient", "Patient")
                        .WithMany("Transactions")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MedX.Domain.Enitities.Payment", "Payment")
                        .WithMany("Transactions")
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("MedX.Domain.Enitities.Treatment", b =>
                {
                    b.HasOne("MedX.Domain.Enitities.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MedX.Domain.Enitities.Patient", "Patient")
                        .WithMany("Treatments")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MedX.Domain.Enitities.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("MedX.Domain.Enitities.Doctor", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Patients");

                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("MedX.Domain.Enitities.Patient", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Transactions");

                    b.Navigation("Treatments");
                });

            modelBuilder.Entity("MedX.Domain.Enitities.Payment", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("MedX.Domain.Enitities.Room", b =>
                {
                    b.Navigation("Patients");
                });
#pragma warning restore 612, 618
        }
    }
}