using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrywallDB.Migrations
{
    public partial class AddedDrywallToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drywalls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Length = table.Column<float>(type: "real", maxLength: 1000, nullable: false),
                    WallTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drywalls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Drywalls_WallTypes_WallTypeId",
                        column: x => x.WallTypeId,
                        principalTable: "WallTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Drywalls_WallTypeId",
                table: "Drywalls",
                column: "WallTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drywalls");
        }
    }
}
