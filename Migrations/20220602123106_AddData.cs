using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FirstApi.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SocialPlatforms",
                columns: new[] { "Id", "DateCreated", "Key", "Name" },
                values: new object[] { 2, new DateTime(2022, 6, 2, 14, 31, 5, 918, DateTimeKind.Local).AddTicks(8600), "Twitter", "Twitter" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SocialPlatforms",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
