using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Marvin.IDP.Migrations
{
    /// <inheritdoc />
    public partial class InitialMarvinIdentityMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Subject = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Password = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Active = table.Column<bool>(type: "INTEGER", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Value = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Active", "ConcurrencyStamp", "Password", "Subject", "UserName" },
                values: new object[,]
                {
                    { new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), true, "14803962-8d0f-4a43-bc49-e6f360a5ec52", "password", "d860efca-22d9-47fd-8249-791ba61b07c7", "David" },
                    { new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), true, "66e17954-92ec-4882-bd4b-26af639d923e", "password", "b7539694-97e7-4dfe-84da-b4256e1ff5c7", "Emma" }
                });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("2d2a79c7-3867-4d2a-bbd5-40d2780b16a6"), "a080ceeb-b434-492a-a2c9-586bd432813c", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("52e79850-a06c-43c9-9a2e-9f2f78761d3c"), "de950e8d-adf4-484b-841d-9c356bfb12b5", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" },
                    { new Guid("61225473-fefe-4ef6-8473-5a2860a4ae1d"), "650ca550-595b-4257-bee5-34a7f5a24370", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("8eb2d9df-6c4b-4ecb-abdc-c3b11eebb866"), "b18f6ab4-28c4-46d8-95d9-8d5b774138b8", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" },
                    { new Guid("e9ce74c9-83cc-4e37-9f84-559ecc58c635"), "acd26f5b-11df-444c-84a8-d2646946188c", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("ed7f91ca-cc94-4a39-adfc-35f79e6ffd51"), "ccdd314e-c702-4b4b-b3d1-e23367cae2af", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("fe2e01e9-8be5-4d1d-96d6-9b98dece57ec"), "aef28178-2673-4b28-b6c9-3d9495a2c0ed", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" },
                    { new Guid("ff11e829-df9d-4ded-8abf-d1d401aa578c"), "96837c94-482e-42e5-a103-c2a58144e920", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Subject",
                table: "Users",
                column: "Subject",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
