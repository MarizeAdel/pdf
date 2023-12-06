using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pdf.Migrations
{
    /// <inheritdoc />
    public partial class two : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_groups_admins_AdminId",
                table: "groups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_admins",
                table: "admins");

            migrationBuilder.DropColumn(
                name: "GID",
                table: "admins");

            migrationBuilder.RenameTable(
                name: "admins",
                newName: "admin");

            migrationBuilder.AddPrimaryKey(
                name: "PK_admin",
                table: "admin",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_groups_admin_AdminId",
                table: "groups",
                column: "AdminId",
                principalTable: "admin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_groups_admin_AdminId",
                table: "groups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_admin",
                table: "admin");

            migrationBuilder.RenameTable(
                name: "admin",
                newName: "admins");

            migrationBuilder.AddColumn<int>(
                name: "GID",
                table: "admins",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_admins",
                table: "admins",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_groups_admins_AdminId",
                table: "groups",
                column: "AdminId",
                principalTable: "admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
