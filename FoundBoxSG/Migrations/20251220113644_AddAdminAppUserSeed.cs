using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoundBoxSG.Migrations
{
    /// <inheritdoc />
    public partial class AddAdminAppUserSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 20, 19, 36, 43, 300, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 20, 19, 36, 43, 300, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AspNetUserId", "CreatedBy", "DateCreated", "DateModified", "IsBanned", "ModifiedBy", "Nationality", "ProfileImageUrl", "Region", "TotalListings" },
                values: new object[] { 3, "3781efa7-66dc-47f0-860f-e506d04102e4", "Admin", new DateTime(2025, 12, 20, 19, 36, 43, 300, DateTimeKind.Local).AddTicks(8948), null, false, null, "Singaporean", "/user.png", "Singapore", 0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf8fb073-4a0f-4950-8336-1be9b6b64275", "AQAAAAIAAYagAAAAEBN8NZNJld0LHKUdx2njB+XgnTQa01ul80miMBdsmzS6RnpPAl7YBXoSoyVUO9n7Ew==", "d6997951-7918-41b7-aebe-a2bcc127341f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b3a8d1e-2f5c-4e7a-9b0d-1f2g3h4i5j6k",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3bd1ef3c-a49e-43b8-baa8-98fe971cb741", "AQAAAAIAAYagAAAAEKWzPDUsIECSwYjXzpQkX+/hBQPCGSXQrGsNm1HADmA3uzyICx6zNDOBXhMs6Zv6xA==", "0a8cfe7a-aab8-4313-9e03-47290ce86cbe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c5f2b8a-1d6e-3c9b-7a4f-0e1d2c3b4a59",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9bf9606-dbb6-46a6-ae8f-b7e1db9cb379", "AQAAAAIAAYagAAAAEGf1nSp3OgmLvwrCoIid9X4oIFEoX3QRk1CYKj6lzMFcqQUSu759190wR6MFlC/93Q==", "9b8257fe-0bb8-4243-b9b2-be3c03220eda" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 20, 19, 36, 43, 300, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 20, 19, 36, 43, 300, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 20, 19, 36, 43, 300, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 20, 19, 36, 43, 300, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 20, 19, 36, 43, 300, DateTimeKind.Local).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 20, 19, 36, 43, 300, DateTimeKind.Local).AddTicks(8713));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 20, 18, 46, 40, 578, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 20, 18, 46, 40, 578, DateTimeKind.Local).AddTicks(8085));

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
        }
    }
}
