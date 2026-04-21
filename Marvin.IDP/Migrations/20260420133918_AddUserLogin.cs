using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Marvin.IDP.Migrations
{
    /// <inheritdoc />
    public partial class AddUserLogin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Provider = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    ProviderIdentityKey = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("140b981b-f865-4067-9eef-d5ec483cd9be"), "1c91d0ba-fa6a-48cd-9bc4-e1a278d918dd", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" },
                    { new Guid("2cbfa893-01af-4460-9a79-2c2025a5d7e2"), "8037eef4-d585-403d-9a83-469639060a29", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" },
                    { new Guid("61edc4f2-a3c6-4f35-80bf-173d691b929b"), "5ebf004d-d4f6-48b4-88fe-92eb5afeb3a5", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("6b46549b-69b4-4065-ba57-694c7502662c"), "875b701e-b6c1-4de7-9eb6-e38584558c05", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" },
                    { new Guid("6b5850f9-6937-4860-b09a-8b5046803daa"), "45ebeeda-daaf-46c8-8feb-bf08e5bfead1", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("d28d7968-6c96-4cb7-82b8-f772b3f1319d"), "0de4c2e6-f373-4b01-84f1-09f7dbaaca60", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" },
                    { new Guid("d2902dfa-9ed1-4b09-ad05-73d5448a218d"), "6b1de857-fa6b-4027-a6c9-3c5bda7f312f", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("f0083c3e-d883-4a37-8482-a0156bc74dfc"), "d07ab82d-b858-49e6-8b6e-c61841c22910", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "12735d5f-d71f-48e3-b9f6-d6900c71df95");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "684ed176-a9e7-4cdc-822a-684c970631c7");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("140b981b-f865-4067-9eef-d5ec483cd9be"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("2cbfa893-01af-4460-9a79-2c2025a5d7e2"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("61edc4f2-a3c6-4f35-80bf-173d691b929b"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("6b46549b-69b4-4065-ba57-694c7502662c"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("6b5850f9-6937-4860-b09a-8b5046803daa"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("d28d7968-6c96-4cb7-82b8-f772b3f1319d"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("d2902dfa-9ed1-4b09-ad05-73d5448a218d"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("f0083c3e-d883-4a37-8482-a0156bc74dfc"));

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
                column: "ConcurrencyStamp",
                value: "24523458-b828-400a-bd1d-70dd41a1fe59");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "a2e64360-3fec-4885-b59d-8197662177bb");
        }
    }
}
