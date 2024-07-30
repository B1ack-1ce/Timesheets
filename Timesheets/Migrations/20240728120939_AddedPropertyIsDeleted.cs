using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timesheets.Migrations
{
    /// <inheritdoc />
    public partial class AddedPropertyIsDeleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "sheets",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "employees",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "contracts",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "clients",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "sheets");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "contracts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "clients");
        }
    }
}
