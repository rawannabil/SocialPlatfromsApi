using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FirstApi.Migrations
{
    public partial class NewUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "SocialPlatforms");

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialPlatformTranslations",
                columns: table => new
                {
                    SocialPlatformKey = table.Column<int>(type: "int", nullable: false),
                    LanguageKey = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialPlatformTranslations", x => new { x.SocialPlatformKey, x.LanguageKey });
                    table.ForeignKey(
                        name: "FK_SocialPlatformTranslations_Languages_LanguageKey",
                        column: x => x.LanguageKey,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SocialPlatformTranslations_SocialPlatforms_SocialPlatformKey",
                        column: x => x.SocialPlatformKey,
                        principalTable: "SocialPlatforms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "SocialPlatforms",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 6, 5, 12, 53, 45, 153, DateTimeKind.Local).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "SocialPlatforms",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 6, 5, 12, 53, 45, 154, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "SocialPlatforms",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 6, 5, 12, 53, 45, 154, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.CreateIndex(
                name: "IX_SocialPlatformTranslations_LanguageKey",
                table: "SocialPlatformTranslations",
                column: "LanguageKey");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SocialPlatformTranslations");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "SocialPlatforms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "SocialPlatforms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Name" },
                values: new object[] { new DateTime(2022, 6, 2, 14, 33, 15, 565, DateTimeKind.Local).AddTicks(1579), "Twitter" });

            migrationBuilder.UpdateData(
                table: "SocialPlatforms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Name" },
                values: new object[] { new DateTime(2022, 6, 2, 14, 33, 15, 565, DateTimeKind.Local).AddTicks(8342), "Instagram" });

            migrationBuilder.UpdateData(
                table: "SocialPlatforms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "Name" },
                values: new object[] { new DateTime(2022, 6, 2, 14, 33, 15, 565, DateTimeKind.Local).AddTicks(8352), "Tiktok" });
        }
    }
}
