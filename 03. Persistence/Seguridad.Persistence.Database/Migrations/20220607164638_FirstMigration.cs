using Microsoft.EntityFrameworkCore.Migrations;

namespace Seguridad.Persistence.Database.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Seguridad");

            migrationBuilder.CreateTable(
                name: "Usuario",
                schema: "Seguridad",
                columns: table => new
                {
                    nUsuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cUsuLogin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cUsuNombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cUsuApePat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cUsuApeMat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cUsuCorreo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cUsuPrgSecreta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cUsuRptSecreta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cEliminado = table.Column<bool>(type: "bit", nullable: false),
                    cImgUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.nUsuId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario",
                schema: "Seguridad");
        }
    }
}
