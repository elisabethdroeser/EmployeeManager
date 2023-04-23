using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManager.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDepartmentName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "IT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "It");
        }
    }
}
