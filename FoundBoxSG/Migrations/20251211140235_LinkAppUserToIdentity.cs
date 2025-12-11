using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoundBoxSG.Migrations
{
    /// <inheritdoc />
    public partial class LinkAppUserToIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AspNetUserId",
                table: "AppUser",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AspNetUserId", "DateCreated" },
                values: new object[] { null, new DateTime(2025, 12, 11, 22, 2, 33, 595, DateTimeKind.Local).AddTicks(4150) });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AspNetUserId", "DateCreated" },
                values: new object[] { null, new DateTime(2025, 12, 11, 22, 2, 33, 595, DateTimeKind.Local).AddTicks(4156) });

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
                column: "DateCreated",
                value: new DateTime(2025, 12, 11, 22, 2, 33, 595, DateTimeKind.Local).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 11, 22, 2, 33, 595, DateTimeKind.Local).AddTicks(3422));

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

            migrationBuilder.CreateIndex(
                name: "IX_AppUser_AspNetUserId",
                table: "AppUser",
                column: "AspNetUserId",
                unique: true,
                filter: "[AspNetUserId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUser_AspNetUsers_AspNetUserId",
                table: "AppUser",
                column: "AspNetUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUser_AspNetUsers_AspNetUserId",
                table: "AppUser");

            migrationBuilder.DropIndex(
                name: "IX_AppUser_AspNetUserId",
                table: "AppUser");

            migrationBuilder.DropColumn(
                name: "AspNetUserId",
                table: "AppUser");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 8, 20, 2, 12, 257, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 8, 20, 2, 12, 257, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d08e547-c94c-43ce-b646-72576f427039", "AQAAAAIAAYagAAAAEJKfbNQZoEGdqAhPCGn6OeL2oNjE/y1MJgNamkPrngqfaSXnx6Fr2lCYEEieCLdjNw==", "b83ec5ed-933a-4f31-a39d-4be0a43dab1d" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 8, 20, 2, 12, 257, DateTimeKind.Local).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 8, 20, 2, 12, 257, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 8, 20, 2, 12, 257, DateTimeKind.Local).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 8, 20, 2, 12, 257, DateTimeKind.Local).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 8, 20, 2, 12, 257, DateTimeKind.Local).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 8, 20, 2, 12, 257, DateTimeKind.Local).AddTicks(7097));
        }
    }
}
