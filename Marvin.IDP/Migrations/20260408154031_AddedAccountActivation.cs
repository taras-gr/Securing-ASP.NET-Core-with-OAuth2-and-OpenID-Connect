using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Marvin.IDP.Migrations
{
    /// <inheritdoc />
    public partial class AddedAccountActivation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("0676a688-d0c3-4b61-8eac-0481cd215c04"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("46f717ab-2476-4944-92f1-9f285f10d56c"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("4af418ef-96f8-4d56-9361-18ab84a7e71e"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("57eeb8bc-5ead-4caa-a8c2-8564b93358ff"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("6e455d2b-4397-4b25-8d8b-9ed0b117a92e"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("af34556f-33fb-471c-88b6-1710dd060e4c"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("b9b33e38-a07f-40bc-8eb1-de7171943dad"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("f31b1c8d-5817-48de-82b1-fc52e1c0d46c"));

            migrationBuilder.AddColumn<DateTime>(
                name: "SecurityCodeExpirationDate",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("0abe50ca-313f-47e8-a9da-63af2463c6ad"), "dba673e5-95ff-4616-8e6b-c13a05c80156", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" },
                    { new Guid("10f82685-a8b2-4568-a8d0-19d25d0de0c2"), "5dfe4a92-db5f-4e7e-9aa6-6eb504547841", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" },
                    { new Guid("3b1497b1-1dbc-442e-b056-9ab8ee962d4f"), "e0ea6b17-b921-4c25-bbb2-9d5684e5f89b", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" },
                    { new Guid("3bb2db0e-123b-4ea5-b7aa-c4745025d618"), "0e61db21-7f4a-4f1a-94ab-094665061630", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" },
                    { new Guid("76bb88d4-9140-405b-8613-830312da0198"), "35048afd-a894-4fdf-aee3-b5ba188736b8", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("86fcd35c-87e3-403a-9d19-c49f93ad83af"), "cd2a019e-8c07-4c50-b90b-d059e2c6a78d", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("9ce6293d-7a55-40d3-859a-ebd36864684d"), "6bd66ad3-9768-4f91-8d8a-23c545266818", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("e2bd78e3-5384-4895-ad34-ecec674d5e56"), "21e83541-d894-4860-8eac-43f84099d734", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                columns: new[] { "ConcurrencyStamp", "SecurityCodeExpirationDate" },
                values: new object[] { "24523458-b828-400a-bd1d-70dd41a1fe59", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                columns: new[] { "ConcurrencyStamp", "SecurityCodeExpirationDate" },
                values: new object[] { "a2e64360-3fec-4885-b59d-8197662177bb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("0abe50ca-313f-47e8-a9da-63af2463c6ad"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("10f82685-a8b2-4568-a8d0-19d25d0de0c2"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("3b1497b1-1dbc-442e-b056-9ab8ee962d4f"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("3bb2db0e-123b-4ea5-b7aa-c4745025d618"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("76bb88d4-9140-405b-8613-830312da0198"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("86fcd35c-87e3-403a-9d19-c49f93ad83af"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("9ce6293d-7a55-40d3-859a-ebd36864684d"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("e2bd78e3-5384-4895-ad34-ecec674d5e56"));

            migrationBuilder.DropColumn(
                name: "SecurityCodeExpirationDate",
                table: "Users");

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("0676a688-d0c3-4b61-8eac-0481cd215c04"), "5136602b-1657-4cad-944b-373d1e4abef8", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" },
                    { new Guid("46f717ab-2476-4944-92f1-9f285f10d56c"), "a43d8126-9365-4302-8ff4-e9eac0288422", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" },
                    { new Guid("4af418ef-96f8-4d56-9361-18ab84a7e71e"), "24997c82-89ac-441a-9771-0c6251ea3605", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("57eeb8bc-5ead-4caa-a8c2-8564b93358ff"), "6ec0c3b8-efdd-4f43-8029-abeb6f464156", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("6e455d2b-4397-4b25-8d8b-9ed0b117a92e"), "96f944c9-9182-4390-bb33-b40e7d3bb9a0", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("af34556f-33fb-471c-88b6-1710dd060e4c"), "7985cba2-aa5f-4394-9040-c51b7f1cf606", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" },
                    { new Guid("b9b33e38-a07f-40bc-8eb1-de7171943dad"), "8b8a18f2-2f31-4306-9a59-0ee2a09f2f44", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("f31b1c8d-5817-48de-82b1-fc52e1c0d46c"), "3c116a0b-578e-428a-b847-5f70285299a1", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "42805a30-f63a-4fab-9e1c-34feb0fb53c2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "d580638b-f46f-4d04-b51d-b07ffa002bb1");
        }
    }
}
