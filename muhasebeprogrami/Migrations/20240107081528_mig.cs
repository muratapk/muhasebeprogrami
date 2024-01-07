using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace muhasebeprogrami.Migrations
{
    public partial class mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sehirs",
                columns: table => new
                {
                    Sehir_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sehir_Adi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sehirs", x => x.Sehir_Id);
                });

            migrationBuilder.CreateTable(
                name: "unvans",
                columns: table => new
                {
                    Unvan_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Unvan_Adi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_unvans", x => x.Unvan_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sehirs");

            migrationBuilder.DropTable(
                name: "unvans");
        }
    }
}
