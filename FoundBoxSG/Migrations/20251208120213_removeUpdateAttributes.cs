using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoundBoxSG.Migrations
{
    /// <inheritdoc />
    public partial class removeUpdateAttributes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DropColumn(
                name: "ReceiverUserId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "AppUser");

            migrationBuilder.RenameColumn(
                name: "LostListingId",
                table: "Matches",
                newName: "MatcherUserId");

            migrationBuilder.RenameColumn(
                name: "FoundListingId",
                table: "Matches",
                newName: "ListingId");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Listings",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                values: new object[] { new DateTime(2025, 12, 8, 20, 2, 12, 257, DateTimeKind.Local).AddTicks(7152), 1 });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "TotalListings" },
                values: new object[] { new DateTime(2025, 12, 8, 20, 2, 12, 257, DateTimeKind.Local).AddTicks(7154), 1 });

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
                columns: new[] { "DateCreated", "UserId" },
                values: new object[] { new DateTime(2025, 12, 8, 20, 2, 12, 257, DateTimeKind.Local).AddTicks(6884), 1 });

            migrationBuilder.InsertData(
                table: "Listings",
                columns: new[] { "Id", "Brand", "Color", "CreatedBy", "DateCreated", "DateModified", "Description", "Image", "ItemCategory", "ListingType", "Location", "ModifiedBy", "Title", "UniqueFeatures", "UserId" },
                values: new object[] { 2, "Gucci", "Black", "Jane", new DateTime(2025, 12, 8, 20, 2, 12, 257, DateTimeKind.Local).AddTicks(6900), null, "Black leather wallet", null, "Wallet", "Lost", "Orchard Road", null, "Lost Wallet", "Gold emblem", 2 });

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
                columns: new[] { "DateCreated", "ListingId", "MatcherUserId" },
                values: new object[] { new DateTime(2025, 12, 8, 20, 2, 12, 257, DateTimeKind.Local).AddTicks(7042), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "SenderUserId" },
                values: new object[] { new DateTime(2025, 12, 8, 20, 2, 12, 257, DateTimeKind.Local).AddTicks(7095), 2 });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "MatchId", "SenderUserId" },
                values: new object[] { new DateTime(2025, 12, 8, 20, 2, 12, 257, DateTimeKind.Local).AddTicks(7097), 2, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Listings");

            migrationBuilder.DropColumn(
                name: "TotalListings",
                table: "AppUser");

            migrationBuilder.RenameColumn(
                name: "MatcherUserId",
                table: "Matches",
                newName: "LostListingId");

            migrationBuilder.RenameColumn(
                name: "ListingId",
                table: "Matches",
                newName: "FoundListingId");

            migrationBuilder.AddColumn<int>(
                name: "ReceiverUserId",
                table: "Messages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "AppUser",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Gender" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 51, 33, 337, DateTimeKind.Local).AddTicks(9788), "Male" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Gender" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 51, 33, 337, DateTimeKind.Local).AddTicks(9792), "Female" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8928f35-6c4e-4cf5-ae35-763360265fbf", "AQAAAAIAAYagAAAAEF8GpPbbl9YZO/Z/P9ugJkNpYPmELPinCYXxF03LyE0RKt4TDw5SOIdLxYPeOVlGXQ==", "eb2aa4a5-37b8-42f3-a0e9-7ec161d7d329" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 3, 15, 51, 33, 337, DateTimeKind.Local).AddTicks(9474));

            migrationBuilder.InsertData(
                table: "Listings",
                columns: new[] { "Id", "Brand", "Color", "CreatedBy", "DateCreated", "DateModified", "Description", "Image", "ItemCategory", "ListingType", "Location", "ModifiedBy", "Title", "UniqueFeatures" },
                values: new object[] { 24, "Gucci", "Black", "Jane", new DateTime(2025, 12, 3, 15, 51, 33, 337, DateTimeKind.Local).AddTicks(9488), null, "Black leather wallet", null, "Wallet", "Lost", "Orchard Road", null, "Lost Wallet", "Gold emblem" });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 3, 15, 51, 33, 337, DateTimeKind.Local).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "FoundListingId", "LostListingId" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 51, 33, 337, DateTimeKind.Local).AddTicks(9621), 3, 4 });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "ReceiverUserId", "SenderUserId" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 51, 33, 337, DateTimeKind.Local).AddTicks(9676), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "MatchId", "ReceiverUserId", "SenderUserId" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 51, 33, 337, DateTimeKind.Local).AddTicks(9678), 1, 1, 2 });
        }
    }
}
