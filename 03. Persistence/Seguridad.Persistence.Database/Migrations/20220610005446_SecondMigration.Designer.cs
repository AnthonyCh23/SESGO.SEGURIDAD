﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Seguridad.Persistence.Database;

namespace Seguridad.Persistence.Database.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220610005446_SecondMigration")]
    partial class SecondMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Seguridad")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Seguridad.Domain.Password", b =>
                {
                    b.Property<int>("nPassItem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fPassFecCre")
                        .HasColumnType("datetime2");

                    b.Property<int>("nPassActivo")
                        .HasColumnType("int");

                    b.Property<int>("nPassCnt")
                        .HasColumnType("int");

                    b.Property<int>("nUsuId")
                        .HasColumnType("int");

                    b.HasKey("nPassItem");

                    b.ToTable("Password");
                });

            modelBuilder.Entity("Seguridad.Domain.Usuario", b =>
                {
                    b.Property<int>("nUsuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("cEliminado")
                        .HasColumnType("bit");

                    b.Property<string>("cImgUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cUsuApeMat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cUsuApePat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cUsuCorreo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cUsuLogin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cUsuNombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cUsuPrgSecreta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cUsuRptSecreta")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("nUsuId");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}