using Microsoft.EntityFrameworkCore.Migrations;

namespace CarePartnersPortal.Migrations.DB
{
    public partial class updates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Branches_ITEquipmentOrders_ITEquipmentOrderID",
                table: "Branches");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_ITEquipmentOrders_ITEquipmentOrderID",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_ITEquipmentOrders_ITEquipmentOrderID",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_ITEquipmentOrderID",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_Departments_ITEquipmentOrderID",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Branches_ITEquipmentOrderID",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "ITEquipmentOrderID",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "ITEquipmentOrderID",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "ITEquipmentOrderID",
                table: "Branches");

            migrationBuilder.AddColumn<string>(
                name: "DistributionGroup",
                table: "Regions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DistributionGroup",
                table: "Regions");

            migrationBuilder.AddColumn<int>(
                name: "ITEquipmentOrderID",
                table: "OrderItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ITEquipmentOrderID",
                table: "Departments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ITEquipmentOrderID",
                table: "Branches",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ITEquipmentOrderID",
                table: "OrderItems",
                column: "ITEquipmentOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ITEquipmentOrderID",
                table: "Departments",
                column: "ITEquipmentOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Branches_ITEquipmentOrderID",
                table: "Branches",
                column: "ITEquipmentOrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Branches_ITEquipmentOrders_ITEquipmentOrderID",
                table: "Branches",
                column: "ITEquipmentOrderID",
                principalTable: "ITEquipmentOrders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_ITEquipmentOrders_ITEquipmentOrderID",
                table: "Departments",
                column: "ITEquipmentOrderID",
                principalTable: "ITEquipmentOrders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_ITEquipmentOrders_ITEquipmentOrderID",
                table: "OrderItems",
                column: "ITEquipmentOrderID",
                principalTable: "ITEquipmentOrders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
