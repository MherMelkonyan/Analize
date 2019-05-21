﻿// <auto-generated />
using System;
using Analizer.NetCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Analizer.NetCore.Migrations
{
    [DbContext(typeof(FireRiskContext))]
    partial class FireRiskContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Analizer.NetCore.Models.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Analizer.NetCore.Models.FireRiskItam", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CityId");

                    b.Property<byte>("ClassOfFireRisk");

                    b.Property<double>("CompIndicator");

                    b.Property<double>("CompIndicatorDay");

                    b.Property<DateTime>("Day");

                    b.Property<double>("DewPoint");

                    b.Property<int>("Precipitation")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<double>("Temperature");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Itams");
                });

            modelBuilder.Entity("Analizer.NetCore.Models.FireRiskItam", b =>
                {
                    b.HasOne("Analizer.NetCore.Models.City", "City")
                        .WithMany("FireRiskItams")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
