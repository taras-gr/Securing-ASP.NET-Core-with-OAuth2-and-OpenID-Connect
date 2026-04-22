using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Marvin.IDP.Migrations
{
    /// <inheritdoc />
    public partial class AddUserSecret : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("14ec07b1-ece0-41ba-bd10-a5ce99d4fe02"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("3bd05dbd-5dea-4256-9bc1-60ab957a6a72"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("6c8ed320-bf00-451d-96f7-681a2784ded9"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("7bad5d1c-ab1e-41c9-9f3e-3130e71917ea"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("7c0c5343-7943-4902-ab2a-0d7ec5d0502b"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("9eddd6e4-38b3-4b13-b9d9-8ec48c9a1375"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("9f8ecd7e-7c88-410a-a85a-0e399da22b9e"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("ca26399c-03b6-4145-ab15-03a10e3aa8f9"));

            migrationBuilder.CreateTable(
                name: "UserSecrets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Secret = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSecrets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSecrets_Users_UserId",
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
                    { new Guid("010f0e45-aa33-4eda-91d3-8ccbc84ef53d"), "305f02f1-f033-47d8-8677-756a47dbd248", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("0cd52726-205a-4fc6-87a9-e6bd01f5c758"), "8cdac288-8f33-41c7-b66f-3ff26fa8e773", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("370ed002-f86c-408f-8f54-0307e867e787"), "1e82f516-d6a3-4e5f-bdcc-d8ed4f969a44", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("6eee2e46-9b41-469e-b9d0-8747c40fb3c4"), "77e500d0-f446-4c75-92d2-d3d444bcbf0d", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" },
                    { new Guid("75c2ac73-b164-42ab-8e29-09189127a2b2"), "efb20580-7364-42f2-bb7c-9c26bd0d6525", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" },
                    { new Guid("a10dcc45-798c-4dd6-8194-3a6a169009b7"), "4df3f624-e249-4160-87bb-90092b815cf0", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("aca1279e-0610-42c9-9a5d-db6bdaa9af0d"), "2583bb8f-751e-4cf2-badc-5cc1c241c6d6", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" },
                    { new Guid("e6358bd8-4d73-4fc6-ba28-0cbc3729624a"), "967f8fa4-2a42-47eb-bdfd-295ef596e9ca", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "570a3fce-306f-4a8c-8940-ab08c9c0adae");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "94af427c-df3a-40af-bfd4-e4838ef96ab0");

            migrationBuilder.CreateIndex(
                name: "IX_UserSecrets_UserId",
                table: "UserSecrets",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserSecrets");

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("010f0e45-aa33-4eda-91d3-8ccbc84ef53d"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("0cd52726-205a-4fc6-87a9-e6bd01f5c758"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("370ed002-f86c-408f-8f54-0307e867e787"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("6eee2e46-9b41-469e-b9d0-8747c40fb3c4"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("75c2ac73-b164-42ab-8e29-09189127a2b2"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("a10dcc45-798c-4dd6-8194-3a6a169009b7"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("aca1279e-0610-42c9-9a5d-db6bdaa9af0d"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("e6358bd8-4d73-4fc6-ba28-0cbc3729624a"));

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("14ec07b1-ece0-41ba-bd10-a5ce99d4fe02"), "658805f3-aa8a-410b-8d76-cfcab2fa99ee", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" },
                    { new Guid("3bd05dbd-5dea-4256-9bc1-60ab957a6a72"), "afdbf37c-4930-4f3e-ab2c-4ea21d28648a", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("6c8ed320-bf00-451d-96f7-681a2784ded9"), "0d7a01ec-f395-414f-ad0f-ea5ae523b1e9", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("7bad5d1c-ab1e-41c9-9f3e-3130e71917ea"), "1a436dde-ec7b-44cc-972d-cd29c0f89d49", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("7c0c5343-7943-4902-ab2a-0d7ec5d0502b"), "5a9e9121-2b2f-4e3a-ae08-ed5a3c9008e6", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("9eddd6e4-38b3-4b13-b9d9-8ec48c9a1375"), "fb1d0d98-2541-4155-ad2c-f6ceb335c53f", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" },
                    { new Guid("9f8ecd7e-7c88-410a-a85a-0e399da22b9e"), "5828a08b-67a6-4828-9c6a-27c3f8cd6187", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" },
                    { new Guid("ca26399c-03b6-4145-ab15-03a10e3aa8f9"), "9e8e2662-6c1e-48f8-ac7f-e1cd5e7866a4", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "91a84266-98b1-4ed5-b2aa-8f1d971b9ace");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "cd874b30-6797-4eaa-953f-e887be43a62c");
        }
    }
}
