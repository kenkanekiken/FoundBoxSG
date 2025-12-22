using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoundBoxSG.Migrations
{
    /// <inheritdoc />
    public partial class AddIsReadToMessages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsRead",
                table: "Messages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 21, 16, 52, 9, 569, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 21, 16, 52, 9, 569, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2025, 12, 21, 16, 52, 9, 569, DateTimeKind.Local).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8634c423-44a2-4660-992d-6323e79fd881", "AQAAAAIAAYagAAAAEHavnjH2++y0SDKsPVBLZh/LKFs3806VFhK3Imt4acuW12ICduHkC24KQi2w/8eCHw==", "0d37c0ee-4807-45f3-b732-b7d14934ff64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b3a8d1e-2f5c-4e7a-9b0d-1f2g3h4i5j6k",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a45ad46a-ca4e-4118-900c-44d928bc9a62", "AQAAAAIAAYagAAAAEDbhKVUm4cidw5njL6Prc2UMpd99oJp528ViY4ewqKQJzUrbi3FM0Q8pOeMqwMmf7g==", "c4eb9084-ae7c-499b-b9f7-a503bf168c07" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c5f2b8a-1d6e-3c9b-7a4f-0e1d2c3b4a59",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fca479a0-5685-4c6d-8cb4-5201e83eb8a0", "AQAAAAIAAYagAAAAEFj+SG3BznwmJgUzX6bCBY9eS9aUKdZiRA1Pd4+7RG/3m9TKKYzMBnRaXgGvdFGRNQ==", "a19d4734-ddfa-4187-a1c1-56a71310e5be" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 21, 16, 52, 9, 569, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 21, 16, 52, 9, 569, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 21, 16, 52, 9, 569, DateTimeKind.Local).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 21, 16, 52, 9, 569, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "IsRead" },
                values: new object[] { new DateTime(2025, 12, 21, 16, 52, 9, 569, DateTimeKind.Local).AddTicks(6689), false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "IsRead" },
                values: new object[] { new DateTime(2025, 12, 21, 16, 52, 9, 569, DateTimeKind.Local).AddTicks(6691), false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRead",
                table: "Messages");

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    MatchId = table.Column<int>(type: "int", nullable: true),
                    MessageId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 21, 16, 20, 26, 503, DateTimeKind.Local).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 21, 16, 20, 26, 503, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2025, 12, 21, 16, 20, 26, 503, DateTimeKind.Local).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b9a4e8e-4da9-43a4-954f-7a767c21efb1", "AQAAAAIAAYagAAAAEBmr7XE/WYJmaDRXAJoMG/5MYri8AqpZIcfFYlVN0AlSzgDXub6pY7zpy6xHZiawoQ==", "60364fb1-b6b0-4c4c-be58-a3a329128b43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b3a8d1e-2f5c-4e7a-9b0d-1f2g3h4i5j6k",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a15a870-7bb8-4ccd-aa03-d417b2d8456c", "AQAAAAIAAYagAAAAEJRP8/iWI6OsOjcOLZOvO0prwd4bNKKtkHutsLAMPZihC0TmD9+zhEiYLnWbJxYQqA==", "6ee3aea0-aa56-407a-af0d-0c6e904def1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c5f2b8a-1d6e-3c9b-7a4f-0e1d2c3b4a59",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e984688-d15f-4ed7-be76-c95c40cecca9", "AQAAAAIAAYagAAAAEDFyJK9+GLEGx1gOHSC6vRPgo4ukBUaWwGzIFauHzG3CnjJ+G2b6fymrsHU1DVpl1w==", "1ab0f04b-1f7f-4c4a-af1c-d21c9a3898ea" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 21, 16, 20, 26, 503, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 21, 16, 20, 26, 503, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 21, 16, 20, 26, 503, DateTimeKind.Local).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 21, 16, 20, 26, 503, DateTimeKind.Local).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 21, 16, 20, 26, 503, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 21, 16, 20, 26, 503, DateTimeKind.Local).AddTicks(4566));
        }
    }
}
