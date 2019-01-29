﻿// <auto-generated />
using System;
using CitiesApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CitiesApp.Migrations
{
    [DbContext(typeof(CitiesAppContext))]
    [Migration("20190129134641_PhotoInfo")]
    partial class PhotoInfo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CitiesApp.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<double>("Rating");

                    b.Property<int>("YearOfCreation");

                    b.HasKey("Id");

                    b.ToTable("City");
                });

            modelBuilder.Entity("CitiesApp.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId");

                    b.Property<byte[]>("Image");

                    b.Property<string>("ImageType");

                    b.Property<string>("PhotoInfo");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("CitiesApp.Models.Photo", b =>
                {
                    b.HasOne("CitiesApp.Models.City", "City")
                        .WithMany("Photos")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}