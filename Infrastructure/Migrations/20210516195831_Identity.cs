using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class Identity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("c4806faa-1e3e-432e-91d9-84610e261230"));

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "AddressId", "Avatar", "FullName", "Profile" },
                values: new object[] { new Guid("a1c503f7-c291-43c2-a6e9-f87b7c733649"), null, "avatar.jpg", "Mahmoud Ashraf Mohamed", "Full Stack Developer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("a1c503f7-c291-43c2-a6e9-f87b7c733649"));

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "AddressId", "Avatar", "FullName", "Profile" },
                values: new object[] { new Guid("c4806faa-1e3e-432e-91d9-84610e261230"), null, "avatar.jpg", "Mahmoud Ashraf Mohamed", "Full Stack Developer" });
        }
    }
}
