using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ActividadesApostolica.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actividades",
                columns: table => new
                {
                    ActividadId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actividades", x => x.ActividadId);
                });

            migrationBuilder.CreateTable(
                name: "Aportes",
                columns: table => new
                {
                    AportesId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ColectaId = table.Column<int>(type: "INTEGER", nullable: false),
                    Persona = table.Column<int>(type: "INTEGER", nullable: false),
                    Contribucion = table.Column<double>(type: "REAL", nullable: false),
                    Resta = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aportes", x => x.AportesId);
                });

            migrationBuilder.CreateTable(
                name: "Asistencias",
                columns: table => new
                {
                    AsistenciaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ActividadId = table.Column<int>(type: "INTEGER", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PersonaId = table.Column<int>(type: "INTEGER", nullable: false),
                    CantidadPresentes = table.Column<int>(type: "INTEGER", nullable: false),
                    CantidadAusentes = table.Column<int>(type: "INTEGER", nullable: false),
                    CantidadExcusas = table.Column<int>(type: "INTEGER", nullable: false),
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asistencias", x => x.AsistenciaId);
                });

            migrationBuilder.CreateTable(
                name: "Colectas",
                columns: table => new
                {
                    ColectasId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    Meta = table.Column<double>(type: "REAL", nullable: false),
                    Logrado = table.Column<double>(type: "REAL", nullable: false),
                    Vence = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colectas", x => x.ColectasId);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    PersonaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Nombres = table.Column<string>(type: "TEXT", nullable: true),
                    Apellidos = table.Column<string>(type: "TEXT", nullable: true),
                    Telefono = table.Column<string>(type: "TEXT", nullable: true),
                    Celular = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Direccion = table.Column<string>(type: "TEXT", nullable: true),
                    Cedula = table.Column<string>(type: "TEXT", nullable: true),
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.PersonaId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Nombres = table.Column<string>(type: "TEXT", nullable: true),
                    Apellidos = table.Column<string>(type: "TEXT", nullable: true),
                    Telefono = table.Column<string>(type: "TEXT", nullable: true),
                    Celular = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Direccion = table.Column<string>(type: "TEXT", nullable: true),
                    NombreUsuario = table.Column<string>(type: "TEXT", nullable: true),
                    ClaveUsuario = table.Column<string>(type: "TEXT", nullable: true),
                    ClaveConfirmada = table.Column<string>(type: "TEXT", nullable: true),
                    TipoUsuario = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "AsistenciasDetalle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AsistenciaId = table.Column<int>(type: "INTEGER", nullable: false),
                    PersonaId = table.Column<int>(type: "INTEGER", nullable: false),
                    Presente = table.Column<bool>(type: "INTEGER", nullable: false),
                    Ausente = table.Column<bool>(type: "INTEGER", nullable: false),
                    Excusa = table.Column<bool>(type: "INTEGER", nullable: false),
                    AsistenciasAsistenciaId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsistenciasDetalle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AsistenciasDetalle_Asistencias_AsistenciasAsistenciaId",
                        column: x => x.AsistenciasAsistenciaId,
                        principalTable: "Asistencias",
                        principalColumn: "AsistenciaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "Apellidos", "Celular", "ClaveConfirmada", "ClaveUsuario", "Direccion", "Email", "Fecha", "NombreUsuario", "Nombres", "Telefono", "TipoUsuario" },
                values: new object[] { 1, "Admin", "0123456789", "admin", "admin", "Admin", "Admin@hotmail.com", new DateTime(2021, 4, 2, 15, 13, 30, 3, DateTimeKind.Local).AddTicks(9250), "Admin", "Admin", "0123456789", "Administrador" });

            migrationBuilder.CreateIndex(
                name: "IX_AsistenciasDetalle_AsistenciasAsistenciaId",
                table: "AsistenciasDetalle",
                column: "AsistenciasAsistenciaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actividades");

            migrationBuilder.DropTable(
                name: "Aportes");

            migrationBuilder.DropTable(
                name: "AsistenciasDetalle");

            migrationBuilder.DropTable(
                name: "Colectas");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Asistencias");
        }
    }
}
