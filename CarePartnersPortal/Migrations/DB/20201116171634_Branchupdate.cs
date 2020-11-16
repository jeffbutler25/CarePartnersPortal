using Microsoft.EntityFrameworkCore.Migrations;

namespace CarePartnersPortal.Migrations.DB
{
    public partial class Branchupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Region",
                table: "Branches",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Region",
                table: "Branches");
        }
    }
}
