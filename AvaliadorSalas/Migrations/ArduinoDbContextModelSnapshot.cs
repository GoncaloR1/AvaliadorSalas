﻿// <auto-generated />
using System;
using AvaliadorSalas.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AvaliadorSalas.Migrations
{
    [DbContext(typeof(ArduinoDbContext))]
    partial class ArduinoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AvaliadorSalas.Models.Leitura", b =>
                {
                    b.Property<int>("LeituraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LeituraId"), 1L, 1);

                    b.Property<DateTime>("DataMedicao")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Medicao")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Sala")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SensorId")
                        .HasColumnType("int");

                    b.HasKey("LeituraId");

                    b.HasIndex("SensorId");

                    b.ToTable("Medicoes");
                });

            modelBuilder.Entity("AvaliadorSalas.Models.Sensor", b =>
                {
                    b.Property<int>("SensorId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SensorId");

                    b.ToTable("Sensores");
                });

            modelBuilder.Entity("AvaliadorSalas.Models.Leitura", b =>
                {
                    b.HasOne("AvaliadorSalas.Models.Sensor", "Sensor")
                        .WithMany("Leituras")
                        .HasForeignKey("SensorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Sensor");
                });

            modelBuilder.Entity("AvaliadorSalas.Models.Sensor", b =>
                {
                    b.Navigation("Leituras");
                });
#pragma warning restore 612, 618
        }
    }
}
