using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leke_Kelmendi_Rroga_CRUD_API.Migrations
{
    public partial class CreateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rrogat",
                columns: table => new
                {
                    ID_Puntori = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emri_Puntorit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mbiemri_Puntorit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kompania = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pozita_Punes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rroga_Puntorit = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rrogat", x => x.ID_Puntori);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rrogat");
        }
    }
}
