﻿// <auto-generated />
using System;
using ApiTenStore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiTenStore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210124190125_UpdateModelProductDb")]
    partial class UpdateModelProductDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("ApiTenStore.Models.CabezaFactura", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("consecutivo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idTercero")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("CabezaFacturas");
                });

            modelBuilder.Entity("ApiTenStore.Models.CuerpoFactura", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("fechaEmision")
                        .HasColumnType("datetime2");

                    b.Property<int>("idCabeza")
                        .HasColumnType("int");

                    b.Property<int>("idProducto")
                        .HasColumnType("int");

                    b.Property<float>("valorIva")
                        .HasColumnType("real");

                    b.Property<float>("valorNet")
                        .HasColumnType("real");

                    b.Property<float>("valorTotal")
                        .HasColumnType("real");

                    b.Property<float>("valorUni")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.ToTable("CuerpoFacturas");
                });

            modelBuilder.Entity("ApiTenStore.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("iva")
                        .HasColumnType("real");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("precio")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ApiTenStore.Models.Tercero", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numeroDoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipoDoc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Terceros");
                });
#pragma warning restore 612, 618
        }
    }
}