using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FirstApi.Migrations
{
    public partial class AddData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SocialPlatforms",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 6, 2, 14, 33, 15, 565, DateTimeKind.Local).AddTicks(1579));

            migrationBuilder.InsertData(
                table: "SocialPlatforms",
                columns: new[] { "Id", "DateCreated", "Key", "Name" },
                values: new object[] { 4, new DateTime(2022, 6, 2, 14, 33, 15, 565, DateTimeKind.Local).AddTicks(8352), "Tiktok", "Tiktok" });

            migrationBuilder.InsertData(
                table: "SocialPlatforms",
                columns: new[] { "Id", "DateCreated", "Key", "Name" },
                values: new object[] { 3, new DateTime(2022, 6, 2, 14, 33, 15, 565, DateTimeKind.Local).AddTicks(8342), "Instagram", "Instagram" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SocialPlatforms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SocialPlatforms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "SocialPlatforms",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 6, 2, 14, 31, 5, 918, DateTimeKind.Local).AddTicks(8600));
        }
    }
}
