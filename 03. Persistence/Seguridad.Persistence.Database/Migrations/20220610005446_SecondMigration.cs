using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Seguridad.Persistence.Database.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Password",
                schema: "Seguridad",
                columns: table => new
                {
                    nPassItem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nUsuId = table.Column<int>(type: "int", nullable: false),
                    cPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fPassFecCre = table.Column<DateTime>(type: "datetime2", nullable: false),
                    nPassActivo = table.Column<int>(type: "int", nullable: false),
                    nPassCnt = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Password", x => x.nPassItem);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Password",
                schema: "Seguridad");
        }
    }
}
