using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Marvin.IDP.Migrations
{
    /// <inheritdoc />
    public partial class EnableNullabeLoginAndPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "UserName",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
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
        }
    }
}
