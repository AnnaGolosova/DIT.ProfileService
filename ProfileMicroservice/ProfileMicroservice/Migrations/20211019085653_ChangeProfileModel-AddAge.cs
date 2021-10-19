using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProfileMicroservice.Migrations
{
    public partial class ChangeProfileModelAddAge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: new Guid("3b045863-a3ed-47e6-bf31-f25149ab45e8"));

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Profiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "AccountId", "Age", "FirstName", "GenderId", "ImageId", "LastName" },
                values: new object[] { new Guid("00f5b63b-de3b-4f0c-9999-b923d851f440"), new Guid("00000000-0000-0000-0000-000000000000"), 0, "dsf", new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), new Guid("00000000-0000-0000-0000-000000000000"), "dsf" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: new Guid("00f5b63b-de3b-4f0c-9999-b923d851f440"));

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Profiles");

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "AccountId", "FirstName", "GenderId", "ImageId", "LastName" },
                values: new object[] { new Guid("3b045863-a3ed-47e6-bf31-f25149ab45e8"), new Guid("00000000-0000-0000-0000-000000000000"), "dsf", new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), new Guid("00000000-0000-0000-0000-000000000000"), "dsf" });
        }
    }
}
