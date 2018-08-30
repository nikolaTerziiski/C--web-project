using Microsoft.EntityFrameworkCore.Migrations;

namespace Gameplace.Web.Data.Migrations
{
    public partial class changedPropertyCarModeltoCarCarModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Model",
                table: "Cars",
                newName: "CarModel");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CarModel",
                table: "Cars",
                newName: "Model");
        }
    }
}
