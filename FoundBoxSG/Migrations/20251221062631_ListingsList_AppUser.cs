using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoundBoxSG.Migrations
{
    /// <inheritdoc />
    public partial class ListingsList_AppUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalListings",
                table: "AppUser");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 21, 14, 26, 30, 450, DateTimeKind.Local).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 21, 14, 26, 30, 450, DateTimeKind.Local).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2025, 12, 21, 14, 26, 30, 450, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b496976-3b21-49a9-9324-85a7c27b5318", "AQAAAAIAAYagAAAAEDQHHRnMbBBA0uw0p9unuHz4f7v7dECN9mhirM33+bluvgNFX+A+fdOsBLUwr6koTQ==", "c9f30fb2-41d8-4831-8513-ef84c07fe037" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b3a8d1e-2f5c-4e7a-9b0d-1f2g3h4i5j6k",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fbef832-4a4b-4035-8a18-c16bcc2394d1", "AQAAAAIAAYagAAAAEP700Jz0u5q7WY8ALnf/zAeILdnwVsPcnWwyxXSh/mFpelD0CKJAkJTT3Mf+zMAEzQ==", "b86d0dd1-169f-4759-abec-41d3a6761a5a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c5f2b8a-1d6e-3c9b-7a4f-0e1d2c3b4a59",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd4af683-7991-4168-a77f-79c4b9fab23e", "AQAAAAIAAYagAAAAEEyqUogV8f5R6t1lSB856Ucq68QJZytG9aJO1ravZcPMCV6TCvfHyK+uDKAOLyw/zg==", "5896d004-9fd1-4d80-a8bd-605bf8186553" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 21, 14, 26, 30, 450, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 21, 14, 26, 30, 450, DateTimeKind.Local).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 21, 14, 26, 30, 450, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 21, 14, 26, 30, 450, DateTimeKind.Local).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 21, 14, 26, 30, 450, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 21, 14, 26, 30, 450, DateTimeKind.Local).AddTicks(2537));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalListings",
                table: "AppUser",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "TotalListings" },
                values: new object[] { new DateTime(2025, 12, 20, 19, 36, 43, 300, DateTimeKind.Local).AddTicks(8874), 1 });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "TotalListings" },
                values: new object[] { new DateTime(2025, 12, 20, 19, 36, 43, 300, DateTimeKind.Local).AddTicks(8946), 1 });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "TotalListings" },
                values: new object[] { new DateTime(2025, 12, 20, 19, 36, 43, 300, DateTimeKind.Local).AddTicks(8948), 0 });

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
    }
}
