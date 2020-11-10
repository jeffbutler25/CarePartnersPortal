using Microsoft.EntityFrameworkCore.Migrations;

namespace CarePartnersPortal.Migrations
{
    public partial class procurafix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "ZIP_File_Size",
                table: "ProcuraFiles",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "File_Size",
                table: "ProcuraFiles",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ZIP_File_Size",
                table: "ProcuraFiles",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<int>(
                name: "File_Size",
                table: "ProcuraFiles",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));
        }
    }
}
