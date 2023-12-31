﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorPagesCitizenship.Data;

#nullable disable

namespace crm.Migrations
{
    [DbContext(typeof(RazorPagesCitizenshipContext))]
    partial class RazorPagesCitizenshipContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("CRM.Models.Citizenship", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Birthplace")
                        .HasColumnType("TEXT");

                    b.Property<int>("CitizenshipNumber")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CitizenshipRegisterDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("District")
                        .HasColumnType("TEXT");

                    b.Property<string>("FatherName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("PermanentAddrress")
                        .HasColumnType("TEXT");

                    b.Property<int>("Ward")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Citizenship");
                });
#pragma warning restore 612, 618
        }
    }
}
