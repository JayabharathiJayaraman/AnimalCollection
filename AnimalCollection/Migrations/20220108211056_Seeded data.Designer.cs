﻿// <auto-generated />
using System;
using AnimalCollection.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalCollection.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220108211056_Seeded data")]
    partial class Seededdata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("AnimalCollection.Entities.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AnimalName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("AnimalTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("AnimalId");

                    b.HasIndex("AnimalTypeId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            AnimalName = "AnimalName 1",
                            AnimalTypeId = 1,
                            CreatedDate = new DateTime(2022, 1, 8, 22, 10, 56, 228, DateTimeKind.Local).AddTicks(7540)
                        },
                        new
                        {
                            AnimalId = 2,
                            AnimalName = "AnimalName 2",
                            AnimalTypeId = 2,
                            CreatedDate = new DateTime(2022, 1, 8, 22, 10, 56, 229, DateTimeKind.Local).AddTicks(70)
                        },
                        new
                        {
                            AnimalId = 3,
                            AnimalName = "AnimalName 3",
                            AnimalTypeId = 2,
                            CreatedDate = new DateTime(2022, 1, 8, 22, 10, 56, 229, DateTimeKind.Local).AddTicks(140)
                        },
                        new
                        {
                            AnimalId = 4,
                            AnimalName = "AnimalName 4",
                            AnimalTypeId = 3,
                            CreatedDate = new DateTime(2022, 1, 8, 22, 10, 56, 229, DateTimeKind.Local).AddTicks(140)
                        },
                        new
                        {
                            AnimalId = 5,
                            AnimalName = "AnimalName 5",
                            AnimalTypeId = 3,
                            CreatedDate = new DateTime(2022, 1, 8, 22, 10, 56, 229, DateTimeKind.Local).AddTicks(150)
                        },
                        new
                        {
                            AnimalId = 6,
                            AnimalName = "AnimalName 6",
                            AnimalTypeId = 3,
                            CreatedDate = new DateTime(2022, 1, 8, 22, 10, 56, 229, DateTimeKind.Local).AddTicks(150)
                        });
                });

            modelBuilder.Entity("AnimalCollection.Entities.AnimalType", b =>
                {
                    b.Property<int>("AnimalTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AnimalTypeName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("AnimalTypeId");

                    b.ToTable("AnimalTypes");

                    b.HasData(
                        new
                        {
                            AnimalTypeId = 1,
                            AnimalTypeName = "AnimalTypeName 1"
                        },
                        new
                        {
                            AnimalTypeId = 2,
                            AnimalTypeName = "AnimalTypeName 2"
                        },
                        new
                        {
                            AnimalTypeId = 3,
                            AnimalTypeName = "AnimalTypeName 3"
                        });
                });

            modelBuilder.Entity("AnimalCollection.Entities.Animal", b =>
                {
                    b.HasOne("AnimalCollection.Entities.AnimalType", "AnimalType")
                        .WithMany("Animals")
                        .HasForeignKey("AnimalTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AnimalType");
                });

            modelBuilder.Entity("AnimalCollection.Entities.AnimalType", b =>
                {
                    b.Navigation("Animals");
                });
#pragma warning restore 612, 618
        }
    }
}
