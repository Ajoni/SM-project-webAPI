using Microsoft.EntityFrameworkCore.Migrations;

namespace SMprojectWebAPI.Migrations
{
    public partial class InitialCreateasd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Shoes",
                nullable: false,
                oldClrType: typeof(double));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Shoes",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
