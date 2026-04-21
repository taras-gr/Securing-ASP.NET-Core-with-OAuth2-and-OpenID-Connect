using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Marvin.IDP.Migrations
{
    /// <inheritdoc />
    public partial class EnableNullabeEmail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("23c41ec2-481d-4bbd-9efb-b36796674a55"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("2de237a7-8572-4a87-8bc1-b37d22e8793c"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("809b1d17-8551-4831-b531-b67f17461363"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("909daac3-8619-4dac-942e-ea2809302fc2"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("95a5ce0a-8a05-4edf-bd95-acb42426b8d3"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("a3bc6e85-0781-4519-8de6-36fc5d49b759"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("e712b2cb-531f-4f1a-8a97-4e14b41f554b"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("eacb03e1-33eb-4cca-ada2-bdfd87b6d0ad"));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("23c41ec2-481d-4bbd-9efb-b36796674a55"), "4e9ed006-798f-4fde-9b4c-3ee780b80c16", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" },
                    { new Guid("2de237a7-8572-4a87-8bc1-b37d22e8793c"), "8eda1877-4f49-4c06-b45a-7bdad99fdc2f", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("809b1d17-8551-4831-b531-b67f17461363"), "c757c4d9-091a-4bce-a269-82dc9d854cb6", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" },
                    { new Guid("909daac3-8619-4dac-942e-ea2809302fc2"), "0d2d2fee-984c-422a-90cc-98fd3df9561d", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" },
                    { new Guid("95a5ce0a-8a05-4edf-bd95-acb42426b8d3"), "2d0506ce-6d44-4e7b-89e1-2cdab6479002", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("a3bc6e85-0781-4519-8de6-36fc5d49b759"), "d6f84b79-9de3-4c96-9e7b-b8b3891c465f", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("e712b2cb-531f-4f1a-8a97-4e14b41f554b"), "be2c8357-d64c-40d4-9c92-48ebdf39078f", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("eacb03e1-33eb-4cca-ada2-bdfd87b6d0ad"), "6dd80f25-bfc8-4b5a-95b9-48807588dc09", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "4bd24361-6ee0-44e5-8f20-eab5d0bcc9e0");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "2f4e694c-a2b5-48b1-a2fa-515f625f7a97");
        }
    }
}
