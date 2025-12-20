using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoundBoxSG.Migrations
{
    /// <inheritdoc />
    public partial class BannedAppUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsBanned",
                table: "AppUser",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "IsBanned" },
                values: new object[] { new DateTime(2025, 12, 20, 18, 46, 40, 578, DateTimeKind.Local).AddTicks(8074), false });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "IsBanned" },
                values: new object[] { new DateTime(2025, 12, 20, 18, 46, 40, 578, DateTimeKind.Local).AddTicks(8085), false });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cd2bcf0c-20db-474f-8407-5a6b159518bb", null, "Banned", "BANNED" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e366b8c-ba2f-4dcf-87e3-603f7d584ab8", "AQAAAAIAAYagAAAAEK7XtY3StZJpg53y3KjK3uRekOltkxJ0s1aR3k1csd7NGRbsCZIYc6y2bQCIEyX5Rg==", "9f892323-43ac-4957-a62f-bbe5ec32a1e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b3a8d1e-2f5c-4e7a-9b0d-1f2g3h4i5j6k",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "338cfcc7-f677-42de-8220-8e066476e35d", "AQAAAAIAAYagAAAAEAksUwh95R6O4xqIldeENIRMVVjHXUjfaKOrEs/bZnbDb9h/GKyJlOPOYacr3wvrKQ==", "94657a06-7704-4e3c-9e2e-cc3f7d1139bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c5f2b8a-1d6e-3c9b-7a4f-0e1d2c3b4a59",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eba75a3f-3703-4c07-9d04-65526e9f24d6", "AQAAAAIAAYagAAAAEEakE0tlWRpOZD/IXUGmgVKskyuUSAr+J2itnO9OkLaigf6WayV3UcuwGazZVQqXlg==", "d425100b-866f-42ad-affd-4c9588d95149" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 20, 18, 46, 40, 578, DateTimeKind.Local).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 20, 18, 46, 40, 578, DateTimeKind.Local).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 20, 18, 46, 40, 578, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 20, 18, 46, 40, 578, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 20, 18, 46, 40, 578, DateTimeKind.Local).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 20, 18, 46, 40, 578, DateTimeKind.Local).AddTicks(7888));

            migrationBuilder.CreateIndex(
                name: "IX_Listings_UserId",
                table: "Listings",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Listings_AppUser_UserId",
                table: "Listings",
                column: "UserId",
                principalTable: "AppUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Listings_AppUser_UserId",
                table: "Listings");

            migrationBuilder.DropIndex(
                name: "IX_Listings_UserId",
                table: "Listings");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DropColumn(
                name: "IsBanned",
                table: "AppUser");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 19, 21, 23, 44, 52, DateTimeKind.Local).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 19, 21, 23, 44, 52, DateTimeKind.Local).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78cce82d-2ee8-47ce-b852-30d70405ad4a", "AQAAAAIAAYagAAAAECJ+bsmxlS1g/Ku7sUUkQBjdQ7XrGtAY4lhw6qkrcAqaCCMkvuJV3ZVQQirnEkSD9w==", "277cfb1d-4856-41c9-be00-2b0f83dd0c3a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b3a8d1e-2f5c-4e7a-9b0d-1f2g3h4i5j6k",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8210cc85-5f5e-49d2-9760-44922da17bab", "AQAAAAIAAYagAAAAEJIESqUuw82vRTNp3Eh9BgmXzSCmHIk7tk1FuOPilv5FaDOpLCaRKH4j0+mO2Hw2Pw==", "d5dc965e-54e3-4c24-8e59-b5edcec6901f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c5f2b8a-1d6e-3c9b-7a4f-0e1d2c3b4a59",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6f29862-25b7-4400-be06-0dc4fa7227c9", "AQAAAAIAAYagAAAAEKZfTZheHP9D4ayq3PIQYSGACBWVOiehC+urRsFcRSOQswt6CxeK0X7k3ywtvLIcBw==", "08bdc084-76d1-497e-97a6-185a8e70dbed" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 19, 21, 23, 44, 52, DateTimeKind.Local).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 19, 21, 23, 44, 52, DateTimeKind.Local).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 19, 21, 23, 44, 52, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 19, 21, 23, 44, 52, DateTimeKind.Local).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 19, 21, 23, 44, 52, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 19, 21, 23, 44, 52, DateTimeKind.Local).AddTicks(4344));
        }
    }
}
