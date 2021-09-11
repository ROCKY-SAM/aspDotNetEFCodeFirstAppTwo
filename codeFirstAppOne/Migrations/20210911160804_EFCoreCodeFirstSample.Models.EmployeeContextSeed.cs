using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace codeFirstAppOne.Migrations
{
    public partial class EFCoreCodeFirstSampleModelsEmployeeContextSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 1L, new DateTime(2000, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "udithLiyanage@gmail.com", "Udith", "Liyanage", "999-888-7777" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 2L, new DateTime(2012, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "himashiranaviraja@gmail.com", "Himashi", "Ranaviraja", "999-888-7777" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2L);
        }
    }
}
