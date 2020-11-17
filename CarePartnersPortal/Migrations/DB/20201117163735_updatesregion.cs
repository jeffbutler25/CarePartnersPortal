using Microsoft.EntityFrameworkCore.Migrations;

namespace CarePartnersPortal.Migrations.DB
{
    public partial class updatesregion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DistributionGroup",
                table: "Regions");

            migrationBuilder.AddColumn<string>(
                name: "FrontlineStaffDL",
                table: "Regions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OfficeStaffDL",
                table: "Regions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FrontlineStaffDL",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "OfficeStaffDL",
                table: "Regions");

            migrationBuilder.AddColumn<string>(
                name: "DistributionGroup",
                table: "Regions",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
