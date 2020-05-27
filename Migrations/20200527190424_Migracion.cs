using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoErrorBlazor.Migrations
{
    public partial class Migracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Errores",
                columns: table => new
                {
                    errorId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    fecha = table.Column<DateTime>(nullable: false),
                    hallazgo = table.Column<string>(nullable: false),
                    ruta = table.Column<string>(nullable: false),
                    importancia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Errores", x => x.errorId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Errores");
        }
    }
}
