using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace muhasebeprogrami.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "kasabas",
                columns: table => new
                {
                    Kasaba_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kasaba_Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sehir_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kasabas", x => x.Kasaba_Id);
                    table.ForeignKey(
                        name: "FK_kasabas_sehirs_Sehir_Id",
                        column: x => x.Sehir_Id,
                        principalTable: "sehirs",
                        principalColumn: "Sehir_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_kasabas_Sehir_Id",
                table: "kasabas",
                column: "Sehir_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "kasabas");
        }
    }
}
