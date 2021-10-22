using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProfileMicroservice.Migrations
{
    public partial class FriendshipRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FriendshipRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FriendshipRequests", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FriendshipRequests",
                columns: new[] { "Id", "Date", "ReceverId", "SenderId", "Status" },
                values: new object[] { new Guid("ec0b51f1-ed70-407c-b778-90bd968ebbda"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("dcf7036a-ab3d-4d14-8276-8dcb1f5e2965"), new Guid("ab2356a6-702a-4372-9554-7bdd6d111a30"), "Unread" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FriendshipRequests");
        }
    }
}
