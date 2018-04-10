﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SpecSelRepo.Models;
using System;

namespace SpecSelRepo.Migrations
{
    [DbContext(typeof(SpecSelResultContext))]
    [Migration("20180409094546_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SpecSelRepo.Models.SpecSelResult", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("AreaPrecisionThresholdY");

                    b.Property<string>("DataSet");

                    b.Property<int>("NumResources");

                    b.Property<int>("NumSpecies");

                    b.Property<string>("Option");

                    b.Property<string>("Output");

                    b.Property<decimal>("SdThresholdX");

                    b.Property<int>("SpeciesThresholdM");

                    b.HasKey("ID");

                    b.ToTable("SpecSelResult");
                });
#pragma warning restore 612, 618
        }
    }
}
