using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timesheets.Migrations
{
    /// <inheritdoc />
    public partial class ConfiguringSheetKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_services_contracts_ContractId",
                table: "services");

            migrationBuilder.DropPrimaryKey(
                name: "PK_sheets",
                table: "sheets");

            migrationBuilder.DropIndex(
                name: "IX_services_ContractId",
                table: "services");

            migrationBuilder.DropColumn(
                name: "ContractId",
                table: "services");

            migrationBuilder.RenameTable(
                name: "sheets",
                newName: "Sheets");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sheets",
                table: "Sheets",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Sheets_ContractId",
                table: "Sheets",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_Sheets_EmployeeId",
                table: "Sheets",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Sheets_ServiceId",
                table: "Sheets",
                column: "ServiceId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_Sheets_ContractId",
                table: "Sheets");

            migrationBuilder.DropIndex(
                name: "IX_Sheets_EmployeeId",
                table: "Sheets");

            migrationBuilder.DropIndex(
                name: "IX_Sheets_ServiceId",
                table: "Sheets");

            migrationBuilder.RenameTable(
                name: "Sheets",
                newName: "sheets");

            migrationBuilder.AddColumn<Guid>(
                name: "ContractId",
                table: "services",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_sheets",
                table: "sheets",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_services_ContractId",
                table: "services",
                column: "ContractId");

            migrationBuilder.AddForeignKey(
                name: "FK_services_contracts_ContractId",
                table: "services",
                column: "ContractId",
                principalTable: "contracts",
                principalColumn: "Id");
        }
    }
}
