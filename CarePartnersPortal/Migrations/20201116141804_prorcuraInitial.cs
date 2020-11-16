using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarePartnersPortal.Migrations
{
    public partial class prorcuraInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProcuraFiles",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Source_DB_Name = table.Column<string>(nullable: true),
                    client_number = table.Column<decimal>(nullable: false),
                    File_Name = table.Column<string>(nullable: true),
                    File_Date = table.Column<DateTime>(nullable: false),
                    File_Type = table.Column<string>(nullable: true),
                    DEF_SUBJECT = table.Column<string>(nullable: true),
                    File_Path = table.Column<string>(nullable: true),
                    ZIP_File_Size = table.Column<long>(nullable: false),
                    ZIP_File_Image = table.Column<byte[]>(nullable: true),
                    File_Size = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcuraFiles", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProcuraFiles");
        }
    }
}
