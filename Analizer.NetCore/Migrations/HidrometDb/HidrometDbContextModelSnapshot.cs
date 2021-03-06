﻿// <auto-generated />
using System;
using Analizer.NetCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Analizer.NetCore.Migrations.HidrometDb
{
    [DbContext(typeof(HidrometDbContext))]
    partial class HidrometDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Analizer.NetCore.Models.Hidromet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .IsUnicode(false);

                    b.Property<DateTime?>("Date")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(getdate())");

                    b.Property<double>("DewPoint");

                    b.Property<int>("MeterologicalPressure");

                    b.Property<int>("Precipitation");

                    b.Property<double>("Temperature");

                    b.Property<int>("Wind");

                    b.HasKey("Id");

                    b.ToTable("Hidromet");
                });
#pragma warning restore 612, 618
        }
    }
}
