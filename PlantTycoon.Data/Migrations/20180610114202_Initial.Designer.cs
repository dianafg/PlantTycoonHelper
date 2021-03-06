﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using PlantTycoon.Data;
using PlantTycoon.Domain;
using System;

namespace PlantTycoon.Data.Migrations
{
    [DbContext(typeof(PlantTycoonContext))]
    [Migration("20180610114202_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PlantTycoon.Domain.FlowerFormula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FlowerA");

                    b.Property<int>("FlowerB");

                    b.Property<bool>("InProgress");

                    b.Property<int?>("Result");

                    b.HasKey("Id");

                    b.ToTable("FlowerFormulas");
                });

            modelBuilder.Entity("PlantTycoon.Domain.StemFormula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("InProgress");

                    b.Property<int>("StemA");

                    b.Property<int>("StemB");

                    b.Property<int?>("Result");

                    b.HasKey("Id");

                    b.ToTable("StemFormulas");
                });
#pragma warning restore 612, 618
        }
    }
}
