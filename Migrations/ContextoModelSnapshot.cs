﻿// <auto-generated />
using System;
using ActividadesApostolica.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ActividadesApostolica.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("ActividadesApostolica.Entidades.Actividades", b =>
                {
                    b.Property<int>("ActividadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("TEXT");

                    b.HasKey("ActividadId");

                    b.ToTable("Actividades");
                });

            modelBuilder.Entity("ActividadesApostolica.Entidades.Aportes", b =>
                {
                    b.Property<int>("AportesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ColectaId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Contribucion")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("Persona")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Resta")
                        .HasColumnType("REAL");

                    b.HasKey("AportesId");

                    b.ToTable("Aportes");
                });

            modelBuilder.Entity("ActividadesApostolica.Entidades.Asistencias", b =>
                {
                    b.Property<int>("AsistenciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ActividadId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantidadAusentes")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantidadExcusas")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantidadPresentes")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("PersonaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AsistenciaId");

                    b.ToTable("Asistencias");
                });

            modelBuilder.Entity("ActividadesApostolica.Entidades.AsistenciasDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AsistenciaId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AsistenciasAsistenciaId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Ausente")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Excusa")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PersonaId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Presente")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AsistenciasAsistenciaId");

                    b.ToTable("AsistenciasDetalle");
                });

            modelBuilder.Entity("ActividadesApostolica.Entidades.Colectas", b =>
                {
                    b.Property<int>("ColectasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<double>("Logrado")
                        .HasColumnType("REAL");

                    b.Property<double>("Meta")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("Vence")
                        .HasColumnType("TEXT");

                    b.HasKey("ColectasId");

                    b.ToTable("Colectas");
                });

            modelBuilder.Entity("ActividadesApostolica.Entidades.Personas", b =>
                {
                    b.Property<int>("PersonaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellidos")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cedula")
                        .HasColumnType("TEXT");

                    b.Property<string>("Celular")
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PersonaId");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("ActividadesApostolica.Entidades.Usuarios", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellidos")
                        .HasColumnType("TEXT");

                    b.Property<string>("Celular")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaveConfirmada")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaveUsuario")
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreUsuario")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoUsuario")
                        .HasColumnType("TEXT");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            UsuarioId = 1,
                            Apellidos = "Admin",
                            Celular = "0123456789",
                            ClaveConfirmada = "admin",
                            ClaveUsuario = "admin",
                            Direccion = "Admin",
                            Email = "Admin@hotmail.com",
                            Fecha = new DateTime(2021, 4, 2, 15, 13, 30, 3, DateTimeKind.Local).AddTicks(9250),
                            NombreUsuario = "Admin",
                            Nombres = "Admin",
                            Telefono = "0123456789",
                            TipoUsuario = "Administrador"
                        });
                });

            modelBuilder.Entity("ActividadesApostolica.Entidades.AsistenciasDetalle", b =>
                {
                    b.HasOne("ActividadesApostolica.Entidades.Asistencias", null)
                        .WithMany("AsistenciasDetalle")
                        .HasForeignKey("AsistenciasAsistenciaId");
                });

            modelBuilder.Entity("ActividadesApostolica.Entidades.Asistencias", b =>
                {
                    b.Navigation("AsistenciasDetalle");
                });
#pragma warning restore 612, 618
        }
    }
}
