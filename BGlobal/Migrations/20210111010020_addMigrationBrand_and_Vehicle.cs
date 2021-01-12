using Microsoft.EntityFrameworkCore.Migrations;

namespace BGlobal.Migrations
{
    public partial class addMigrationBrand_and_Vehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Model",
                table: "Brands");

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Vehicles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Brands",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Model",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Brands");

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
