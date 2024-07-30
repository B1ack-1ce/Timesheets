using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timesheets.Migrations
{
    /// <inheritdoc />
    public partial class ConfiguringDateProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sheets_contracts_ContractId",
                table: "Sheets");

            migrationBuilder.DropForeignKey(
                name: "FK_Sheets_employees_EmployeeId",
                table: "Sheets");

            migrationBuilder.DropForeignKey(
                name: "FK_Sheets_services_ServiceId",
                table: "Sheets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sheets",
                table: "Sheets");

            migrationBuilder.RenameTable(
                name: "Sheets",
                newName: "sheets");

            migrationBuilder.RenameIndex(
                name: "IX_Sheets_ServiceId",
                table: "sheets",
                newName: "IX_sheets_ServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_Sheets_EmployeeId",
                table: "sheets",
                newName: "IX_sheets_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Sheets_ContractId",
                table: "sheets",
                newName: "IX_sheets_ContractId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "sheets",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateStart",
                table: "contracts",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateEnd",
                table: "contracts",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddPrimaryKey(
                name: "PK_sheets",
                table: "sheets",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_sheets_contracts_ContractId",
                table: "sheets",
                column: "ContractId",
                principalTable: "contracts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_sheets_employees_EmployeeId",
                table: "sheets",
                column: "EmployeeId",
                principalTable: "employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_sheets_services_ServiceId",
                table: "sheets",
                column: "ServiceId",
                principalTable: "services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sheets_contracts_ContractId",
                table: "sheets");

            migrationBuilder.DropForeignKey(
                name: "FK_sheets_employees_EmployeeId",
                table: "sheets");

            migrationBuilder.DropForeignKey(
                name: "FK_sheets_services_ServiceId",
                table: "sheets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_sheets",
                table: "sheets");

            migrationBuilder.RenameTable(
                name: "sheets",
                newName: "Sheets");

            migrationBuilder.RenameIndex(
                name: "IX_sheets_ServiceId",
                table: "Sheets",
                newName: "IX_Sheets_ServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_sheets_EmployeeId",
                table: "Sheets",
                newName: "IX_Sheets_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_sheets_ContractId",
                table: "Sheets",
                newName: "IX_Sheets_ContractId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Sheets",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateStart",
                table: "contracts",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateEnd",
                table: "contracts",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sheets",
                table: "Sheets",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sheets_contracts_ContractId",
                table: "Sheets",
                column: "ContractId",
                principalTable: "contracts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sheets_employees_EmployeeId",
                table: "Sheets",
                column: "EmployeeId",
                principalTable: "employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sheets_services_ServiceId",
                table: "Sheets",
                column: "ServiceId",
                principalTable: "services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
