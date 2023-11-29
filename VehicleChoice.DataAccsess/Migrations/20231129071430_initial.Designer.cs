﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VehicleChoice.DataAccsess;

#nullable disable

namespace VehicleChoice.DataAccsess.Migrations
{
    [DbContext(typeof(VehicleDbContext))]
    [Migration("20231129071430_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.HasSequence("VehicleSequence");

            modelBuilder.Entity("VehicleChoice.Entity.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR [VehicleSequence]");

                    SqlServerPropertyBuilderExtensions.UseSequence(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable((string)null);

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("VehicleChoice.Entity.Car", b =>
                {
                    b.HasBaseType("VehicleChoice.Entity.Vehicle");

                    b.Property<bool>("Headlight")
                        .HasColumnType("bit");

                    b.Property<string>("Wheel")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.ToTable("Cars", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}