using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace testExperis.Migrations
{
    public partial class firtsTestExperis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "alumnos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    documento = table.Column<string>(nullable: false),
                    nombres = table.Column<string>(nullable: false),
                    apellidos = table.Column<string>(nullable: false),
                    fechaIngreso = table.Column<DateTime>(nullable: false),
                    semestre = table.Column<int>(nullable: false),
                    edad = table.Column<int>(nullable: false),
                    telefonoMovil = table.Column<double>(nullable: false),
                    estado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alumnos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "materias",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreMateria = table.Column<string>(nullable: true),
                    descripcion = table.Column<string>(nullable: true),
                    estado = table.Column<int>(nullable: false),
                    Alumnosid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_materias", x => x.id);
                    table.ForeignKey(
                        name: "FK_materias_alumnos_Alumnosid",
                        column: x => x.Alumnosid,
                        principalTable: "alumnos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "notas",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nota = table.Column<int>(nullable: false),
                    documento = table.Column<double>(nullable: false),
                    estado = table.Column<int>(nullable: false),
                    Alumnosid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_notas", x => x.id);
                    table.ForeignKey(
                        name: "FK_notas_alumnos_Alumnosid",
                        column: x => x.Alumnosid,
                        principalTable: "alumnos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "salones",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sede = table.Column<string>(nullable: true),
                    letra = table.Column<string>(nullable: true),
                    numero = table.Column<int>(nullable: false),
                    estado = table.Column<int>(nullable: false),
                    Alumnosid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salones", x => x.id);
                    table.ForeignKey(
                        name: "FK_salones_alumnos_Alumnosid",
                        column: x => x.Alumnosid,
                        principalTable: "alumnos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_materias_Alumnosid",
                table: "materias",
                column: "Alumnosid");

            migrationBuilder.CreateIndex(
                name: "IX_notas_Alumnosid",
                table: "notas",
                column: "Alumnosid");

            migrationBuilder.CreateIndex(
                name: "IX_salones_Alumnosid",
                table: "salones",
                column: "Alumnosid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "materias");

            migrationBuilder.DropTable(
                name: "notas");

            migrationBuilder.DropTable(
                name: "salones");

            migrationBuilder.DropTable(
                name: "alumnos");
        }
    }
}
