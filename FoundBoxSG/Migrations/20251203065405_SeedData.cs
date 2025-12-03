using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoundBoxSG.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Listings");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Messages",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Matches",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Listings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "AppUser",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateModified", "FullName", "Gender", "ModifiedBy", "Nationality", "ProfileImageUrl", "Region", "UserName" },
                values: new object[,]
                {
                    { 1, "John", new DateTime(2025, 12, 3, 14, 54, 4, 391, DateTimeKind.Local).AddTicks(5310), null, "John Doe", "Male", null, "Singaporean", null, "Tampines", "johndoe123" },
                    { 2, "Jane", new DateTime(2025, 12, 3, 14, 54, 4, 391, DateTimeKind.Local).AddTicks(5316), null, "Jane Gun", "Female", null, "Singaporean", null, "Bedok", "janegun987" }
                });

            migrationBuilder.InsertData(
                table: "Listings",
                columns: new[] { "Id", "Brand", "Color", "CreatedBy", "DateCreated", "DateModified", "Description", "Image", "ItemCategory", "ListingType", "Location", "ModifiedBy", "Title", "UniqueFeatures" },
                values: new object[,]
                {
                    { 1, "N/A", "Silver and Red", "John", new DateTime(2025, 12, 3, 14, 54, 4, 391, DateTimeKind.Local).AddTicks(4835), null, "Set of car keys with a red keychain", null, "Keys", "Found", "Marina Bay Sands", null, "Found Keys", "Red keychain with a smiley face" },
                    { 24, "Gucci", "Black", "Jane", new DateTime(2025, 12, 3, 14, 54, 4, 391, DateTimeKind.Local).AddTicks(4860), null, "Black leather wallet", null, "Wallet", "Lost", "Orchard Road", null, "Lost Wallet", "Gold emblem" }
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateModified", "FoundListingId", "LostListingId", "ModifiedBy" },
                values: new object[,]
                {
                    { 1, "John", new DateTime(2025, 12, 3, 14, 54, 4, 391, DateTimeKind.Local).AddTicks(5095), null, 1, 2, null },
                    { 2, "Jane", new DateTime(2025, 12, 3, 14, 54, 4, 391, DateTimeKind.Local).AddTicks(5098), null, 3, 4, null }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "CreatedBy", "DateCreated", "DateModified", "MatchId", "ModifiedBy", "ReceiverUserId", "SenderUserId" },
                values: new object[,]
                {
                    { 1, "Hello! Is this item still available?", "John", new DateTime(2025, 12, 3, 14, 54, 4, 391, DateTimeKind.Local).AddTicks(5217), null, 1, null, 2, 1 },
                    { 2, "Yes, it is still available. Would you like to arrange a pickup?", "Jane", new DateTime(2025, 12, 3, 14, 54, 4, 391, DateTimeKind.Local).AddTicks(5221), null, 1, null, 1, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Matches",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Listings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Listings",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "AppUser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
