using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoundBoxSG.Migrations
{
    /// <inheritdoc />
    public partial class Multiple_Images_For_Listings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Listings");

            migrationBuilder.AddColumn<string>(
                name: "Images",
                table: "Listings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 14, 22, 24, 59, 145, DateTimeKind.Local).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 14, 22, 24, 59, 145, DateTimeKind.Local).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e41c766-5762-4993-989f-c9ad2c6eb8c3", "AQAAAAIAAYagAAAAECPtxOrBZMK8knJL79F5fmhtjOIO4PMKVg9rABogXVReCp22JApznRrG8U8hCf+N8A==", "91251314-ce7f-4e5e-a286-bbdf84ef622f" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Images" },
                values: new object[] { new DateTime(2025, 12, 14, 22, 24, 59, 145, DateTimeKind.Local).AddTicks(8471), "[]" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Images" },
                values: new object[] { new DateTime(2025, 12, 14, 22, 24, 59, 145, DateTimeKind.Local).AddTicks(8505), "[]" });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 14, 22, 24, 59, 145, DateTimeKind.Local).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 14, 22, 24, 59, 145, DateTimeKind.Local).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 14, 22, 24, 59, 145, DateTimeKind.Local).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 14, 22, 24, 59, 145, DateTimeKind.Local).AddTicks(9317));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Images",
                table: "Listings");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Listings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 11, 22, 2, 33, 595, DateTimeKind.Local).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 11, 22, 2, 33, 595, DateTimeKind.Local).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "923b908b-6c28-4011-9ecc-5e596935e4bc", "AQAAAAIAAYagAAAAEP9Yu+X90wRxe6NZewB7ZN9pjD/wurFDnwMO4lAJlih2+0bnO7sYFpuXPZnwY3ccMQ==", "4d04cd74-a700-486b-aff1-e2f21f41d786" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Image" },
                values: new object[] { new DateTime(2025, 12, 11, 22, 2, 33, 595, DateTimeKind.Local).AddTicks(3393), null });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Image" },
                values: new object[] { new DateTime(2025, 12, 11, 22, 2, 33, 595, DateTimeKind.Local).AddTicks(3422), null });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 11, 22, 2, 33, 595, DateTimeKind.Local).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 11, 22, 2, 33, 595, DateTimeKind.Local).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 11, 22, 2, 33, 595, DateTimeKind.Local).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 11, 22, 2, 33, 595, DateTimeKind.Local).AddTicks(3897));
        }
    }
}
