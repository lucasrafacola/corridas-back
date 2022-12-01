﻿// <auto-generated />
using System;
using ApiCorridas.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiCorridas.Migrations
{
    [DbContext(typeof(APIDbContext))]
    [Migration("20221201000656_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ApiCorridas.Models.Competidor", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Altura")
                        .HasColumnType("double");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Peso")
                        .HasColumnType("double");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("varchar(1)");

                    b.Property<double>("TempMedCorpo")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Competidores");
                });

            modelBuilder.Entity("ApiCorridas.Models.HistoricoCorrida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CompetidorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCorrida")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("PistaId")
                        .HasColumnType("int");

                    b.Property<decimal>("TempoGasto")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("CompetidorId");

                    b.HasIndex("PistaId");

                    b.ToTable("HistoricoCorridas");
                });

            modelBuilder.Entity("ApiCorridas.Models.Pista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Pistas");
                });

            modelBuilder.Entity("ApiCorridas.Models.HistoricoCorrida", b =>
                {
                    b.HasOne("ApiCorridas.Models.Competidor", "Competidor")
                        .WithMany("Historico")
                        .HasForeignKey("CompetidorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiCorridas.Models.Pista", "Pista")
                        .WithMany("Historico")
                        .HasForeignKey("PistaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Competidor");

                    b.Navigation("Pista");
                });

            modelBuilder.Entity("ApiCorridas.Models.Competidor", b =>
                {
                    b.Navigation("Historico");
                });

            modelBuilder.Entity("ApiCorridas.Models.Pista", b =>
                {
                    b.Navigation("Historico");
                });
#pragma warning restore 612, 618
        }
    }
}