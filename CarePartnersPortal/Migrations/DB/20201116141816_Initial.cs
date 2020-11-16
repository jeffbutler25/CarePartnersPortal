using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarePartnersPortal.Migrations.DB
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeHires",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    JobTitle = table.Column<string>(nullable: false),
                    Department = table.Column<string>(nullable: false),
                    Region = table.Column<string>(nullable: false),
                    HireType = table.Column<string>(nullable: false),
                    EmployeeNumber = table.Column<string>(nullable: true),
                    AdditonalRequirements = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeHires", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HireTypes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HireTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ITEquipmentOrders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDateTime = table.Column<DateTime>(nullable: false),
                    Requester = table.Column<string>(nullable: true),
                    RequestedFor = table.Column<string>(nullable: true),
                    OtherAddress = table.Column<bool>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Suite = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    AdditionalInformaiton = table.Column<string>(nullable: true),
                    Approved = table.Column<bool>(nullable: false),
                    ApprovalDateTime = table.Column<DateTime>(nullable: false),
                    Approver = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITEquipmentOrders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ITOutages",
                columns: table => new
                {
                    IncidentType = table.Column<string>(nullable: false),
                    CrationDate = table.Column<string>(nullable: true),
                    OutageStart = table.Column<string>(nullable: true),
                    OutageEnd = table.Column<string>(nullable: true),
                    ImpactedSystems = table.Column<string>(nullable: true),
                    ImpactedUsers = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITOutages", x => x.IncidentType);
                });

            migrationBuilder.CreateTable(
                name: "ITSystems",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ContactsInternal = table.Column<string>(nullable: true),
                    ContactsExternal = table.Column<string>(nullable: true),
                    NotificationGroup = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITSystems", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "JobTitles",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Approvers = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TempInfos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    Access = table.Column<string>(nullable: true),
                    System = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    DateTimeCreated = table.Column<DateTime>(nullable: false),
                    DateTimeExpiry = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempInfos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Approvers = table.Column<string>(nullable: true),
                    ITEquipmentOrderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Branches_ITEquipmentOrders_ITEquipmentOrderID",
                        column: x => x.ITEquipmentOrderID,
                        principalTable: "ITEquipmentOrders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Approvers = table.Column<string>(nullable: true),
                    ITEquipmentOrderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Departments_ITEquipmentOrders_ITEquipmentOrderID",
                        column: x => x.ITEquipmentOrderID,
                        principalTable: "ITEquipmentOrders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<float>(nullable: false),
                    ITEquipmentOrderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderItems_ITEquipmentOrders_ITEquipmentOrderID",
                        column: x => x.ITEquipmentOrderID,
                        principalTable: "ITEquipmentOrders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Branches_ITEquipmentOrderID",
                table: "Branches",
                column: "ITEquipmentOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ITEquipmentOrderID",
                table: "Departments",
                column: "ITEquipmentOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ITEquipmentOrderID",
                table: "OrderItems",
                column: "ITEquipmentOrderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "EmployeeHires");

            migrationBuilder.DropTable(
                name: "HireTypes");

            migrationBuilder.DropTable(
                name: "ITOutages");

            migrationBuilder.DropTable(
                name: "ITSystems");

            migrationBuilder.DropTable(
                name: "JobTitles");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "TempInfos");

            migrationBuilder.DropTable(
                name: "ITEquipmentOrders");
        }
    }
}
