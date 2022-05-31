using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrywallDB.Migrations
{
    public partial class ChangedFloatToDoubleInWallType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Width",
                table: "WallTypes",
                type: "float(10)",
                precision: 10,
                scale: 2,
                nullable: false,
                defaultValue: 0.050000000000000003,
                oldClrType: typeof(float),
                oldType: "real",
                oldDefaultValue: 0.05f);

            migrationBuilder.AlterColumn<double>(
                name: "Height",
                table: "WallTypes",
                type: "float(10)",
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Width",
                table: "WallTypes",
                type: "real",
                nullable: false,
                defaultValue: 0.05f,
                oldClrType: typeof(double),
                oldType: "float(10)",
                oldPrecision: 10,
                oldScale: 2,
                oldDefaultValue: 0.050000000000000003);

            migrationBuilder.AlterColumn<float>(
                name: "Height",
                table: "WallTypes",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float(10)",
                oldPrecision: 10,
                oldScale: 2);
        }
    }
}
