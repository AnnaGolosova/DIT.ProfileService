using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProfileMicroservice.Migrations
{
    public partial class AddFriendTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: new Guid("00f5b63b-de3b-4f0c-9999-b923d851f440"));

            migrationBuilder.CreateTable(
                name: "Friends",
                columns: table => new
                {
                    FriendId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friends", x => x.FriendId);
                });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "FriendId", "ProfileId" },
                values: new object[,]
                {
                    { new Guid("dcf7036a-ab3d-4d14-8276-8dcb1f5e2965"), new Guid("07641816-9097-451e-8aef-9f24c5786c20") },
                    { new Guid("ab2356a6-702a-4372-9554-7bdd6d111a30"), new Guid("07641816-9097-451e-8aef-9f24c5786c20") }
                });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "AccountId", "Age", "FirstName", "GenderId", "ImageId", "LastName" },
                values: new object[,]
                {
                    { new Guid("07641816-9097-451e-8aef-9f24c5786c20"), new Guid("00000000-0000-0000-0000-000000000000"), 0, "asdasd", new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), new Guid("00000000-0000-0000-0000-000000000000"), "asdasd" },
                    { new Guid("dcf7036a-ab3d-4d14-8276-8dcb1f5e2965"), new Guid("00000000-0000-0000-0000-000000000000"), 0, "qweqwe", new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), new Guid("00000000-0000-0000-0000-000000000000"), "qweqwe" },
                    { new Guid("ab2356a6-702a-4372-9554-7bdd6d111a30"), new Guid("00000000-0000-0000-0000-000000000000"), 0, "dsfdsf", new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), new Guid("00000000-0000-0000-0000-000000000000"), "dsfdsf" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Friends");

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: new Guid("07641816-9097-451e-8aef-9f24c5786c20"));

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: new Guid("ab2356a6-702a-4372-9554-7bdd6d111a30"));

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: new Guid("dcf7036a-ab3d-4d14-8276-8dcb1f5e2965"));

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "AccountId", "Age", "FirstName", "GenderId", "ImageId", "LastName" },
                values: new object[] { new Guid("00f5b63b-de3b-4f0c-9999-b923d851f440"), new Guid("00000000-0000-0000-0000-000000000000"), 0, "dsf", new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), new Guid("00000000-0000-0000-0000-000000000000"), "dsf" });
        }
    }
}
