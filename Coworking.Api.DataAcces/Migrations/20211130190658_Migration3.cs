using Microsoft.EntityFrameworkCore.Migrations;

namespace Coworking.Api.DataAcces.Migrations
{
    public partial class Migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_Offices_OfficeId",
                table: "Admins");

            migrationBuilder.DropIndex(
                name: "IX_Admins_OfficeId",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "OfficeId",
                table: "Admins");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OfficeId",
                table: "Admins",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Admins_OfficeId",
                table: "Admins",
                column: "OfficeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_Offices_OfficeId",
                table: "Admins",
                column: "OfficeId",
                principalTable: "Offices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
