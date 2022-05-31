using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrywallDB.Migrations
{
    public partial class changedHasPrecisionToHasColumnType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Width",
                table: "WallTypes",
                type: "decimal(10,3)",
                nullable: false,
                defaultValue: 0.05m,
                oldClrType: typeof(double),
                oldType: "float(10)",
                oldPrecision: 10,
                oldScale: 2,
                oldDefaultValue: 0.050000000000000003);

            migrationBuilder.AlterColumn<decimal>(
                name: "Height",
                table: "WallTypes",
                type: "decimal(10,3)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float(10)",
                oldPrecision: 10,
                oldScale: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Width",
                table: "WallTypes",
                type: "float(10)",
                precision: 10,
                scale: 2,
                nullable: false,
                defaultValue: 0.050000000000000003,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,3)",
                oldDefaultValue: 0.05m);

            migrationBuilder.AlterColumn<double>(
                name: "Height",
                table: "WallTypes",
                type: "float(10)",
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,3)");
        }
    }
}
