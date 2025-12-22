using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoundBoxSG.Migrations
{
    /// <inheritdoc />
    public partial class AddIsCloseToListings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsClose",
                table: "Listings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 21, 23, 16, 10, 446, DateTimeKind.Local).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 21, 23, 16, 10, 446, DateTimeKind.Local).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2025, 12, 21, 23, 16, 10, 446, DateTimeKind.Local).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6596a2a6-d94f-4724-9cb2-f2263be28924", "AQAAAAIAAYagAAAAEK9LgZYGe93WE3UskRsvokPSPp4nSs0zgpfde9OceleZtTT9P33ieTSZ2XmYdgSlUA==", "a1f096cb-0da2-4c65-bdd7-d6d5680055ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b3a8d1e-2f5c-4e7a-9b0d-1f2g3h4i5j6k",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d1125ab-4c4d-44bc-a03a-cce21d9ec29a", "AQAAAAIAAYagAAAAEMIGoCvexJSoe4l6d1cIbLrhOpoWGGchlZTzy+5iyGjK8SwTH5a/XoyfN9czerapHw==", "a5197e04-7c96-4c44-8289-031d9e990a24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c5f2b8a-1d6e-3c9b-7a4f-0e1d2c3b4a59",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9714b423-ac5d-47d2-a267-95529e64aa9a", "AQAAAAIAAYagAAAAEC4MhD/xmpvPtbzkSN7sg0Tlpb1FH2lxGfeU1nSshehuUycGo8G5RoiFJlteqPYvyg==", "c21d645d-8252-486e-9634-8569d55a5c0f" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "IsClose" },
                values: new object[] { new DateTime(2025, 12, 21, 23, 16, 10, 446, DateTimeKind.Local).AddTicks(525), false });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "IsClose" },
                values: new object[] { new DateTime(2025, 12, 21, 23, 16, 10, 446, DateTimeKind.Local).AddTicks(547), false });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 21, 23, 16, 10, 446, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 21, 23, 16, 10, 446, DateTimeKind.Local).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 21, 23, 16, 10, 446, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 21, 23, 16, 10, 446, DateTimeKind.Local).AddTicks(876));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsClose",
                table: "Listings");

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
                column: "DateCreated",
                value: new DateTime(2025, 12, 21, 16, 52, 9, 569, DateTimeKind.Local).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 21, 16, 52, 9, 569, DateTimeKind.Local).AddTicks(6691));
        }
    }
}
