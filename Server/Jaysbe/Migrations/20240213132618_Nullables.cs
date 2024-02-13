using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Jaysbe.Migrations
{
    /// <inheritdoc />
    public partial class Nullables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b42ab474-1b3e-4167-8963-4503dd2422c7", "610026bf-2fd1-48b2-b0a0-e0500b7a5e7d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b42ab474-1b3e-4167-8963-4503dd2422c7", "6d5b5bd2-30c8-4c05-b7e2-d606f998436b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b42ab474-1b3e-4167-8963-4503dd2422c7", "73f146e4-b5a7-4253-a845-990d2a86509a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b42ab474-1b3e-4167-8963-4503dd2422c7", "8aac8893-c4a7-456d-8d71-adcfb237835c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b42ab474-1b3e-4167-8963-4503dd2422c7", "a90cb0da-1ae6-475b-9f93-cfe2abbf4e77" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b42ab474-1b3e-4167-8963-4503dd2422c7", "b4b73e25-624b-4903-aade-e5603262e766" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b42ab474-1b3e-4167-8963-4503dd2422c7", "baf34ac9-b8f2-4cf3-842d-08ca719e4179" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b42ab474-1b3e-4167-8963-4503dd2422c7", "d465ffc3-c504-4f71-b01d-8c92a99d9c1f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b42ab474-1b3e-4167-8963-4503dd2422c7", "d7b2e4dd-7a94-4fd2-8f65-da9e1a5c7d30" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b42ab474-1b3e-4167-8963-4503dd2422c7", "fc671021-4d92-452e-8b6f-26124dd24de1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b42ab474-1b3e-4167-8963-4503dd2422c7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "610026bf-2fd1-48b2-b0a0-e0500b7a5e7d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5b5bd2-30c8-4c05-b7e2-d606f998436b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73f146e4-b5a7-4253-a845-990d2a86509a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aac8893-c4a7-456d-8d71-adcfb237835c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a90cb0da-1ae6-475b-9f93-cfe2abbf4e77");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4b73e25-624b-4903-aade-e5603262e766");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "baf34ac9-b8f2-4cf3-842d-08ca719e4179");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d465ffc3-c504-4f71-b01d-8c92a99d9c1f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d7b2e4dd-7a94-4fd2-8f65-da9e1a5c7d30");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc671021-4d92-452e-8b6f-26124dd24de1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5aa88b9c-a8de-482d-a802-d1d2bf4075fa", null, "TestUser", "TESTUSER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0a137398-bcc4-4c66-b425-76347c03f64b", 0, "1e0ddc1d-74d6-4b87-8f8f-ba7a7e33bd42", "user2@user.com", false, false, null, "USER2@USER.COM", "USER2", "AQAAAAIAAYagAAAAELvuhlJ2VzRaNTlGIyLOKFwe8Jjz0vi2XZqJc35Edx4SJh2IkjwnWUjc0aytI5diqQ==", null, false, "190e7178-4166-494e-b7e3-1ba1082fdb57", false, "user2" },
                    { "118ae8c4-0854-437b-ad9c-ccd218d1c287", 0, "e2ce68d3-0aea-4ac6-bbc0-cbdbc25a4bfa", "user6@user.com", false, false, null, "USER6@USER.COM", "USER6", "AQAAAAIAAYagAAAAELvuhlJ2VzRaNTlGIyLOKFwe8Jjz0vi2XZqJc35Edx4SJh2IkjwnWUjc0aytI5diqQ==", null, false, "c2eafb68-3016-4c76-9e44-00c08bdad020", false, "user6" },
                    { "463bdd5c-ca52-44ff-8060-f8914b55bb54", 0, "9e19e0a1-ae4d-478d-9c75-a13bd18c164e", "user1@user.com", false, false, null, "USER1@USER.COM", "USER1", "AQAAAAIAAYagAAAAELvuhlJ2VzRaNTlGIyLOKFwe8Jjz0vi2XZqJc35Edx4SJh2IkjwnWUjc0aytI5diqQ==", null, false, "08e35301-21b3-4116-a14a-e45574d5d2d2", false, "user1" },
                    { "51de2c9e-54d1-4b51-b727-7b31e58ad2c8", 0, "bcf55bed-ee91-4ccb-a761-f0ee4e7abb86", "user9@user.com", false, false, null, "USER9@USER.COM", "USER9", "AQAAAAIAAYagAAAAELvuhlJ2VzRaNTlGIyLOKFwe8Jjz0vi2XZqJc35Edx4SJh2IkjwnWUjc0aytI5diqQ==", null, false, "047caf99-e7b4-4fba-aa4d-9bfd72da350b", false, "user9" },
                    { "86cfb1ff-d836-4b09-ab82-f0d1e9ff0b6e", 0, "2ce05687-2479-4d31-ac2a-a17f51c31e6f", "user8@user.com", false, false, null, "USER8@USER.COM", "USER8", "AQAAAAIAAYagAAAAELvuhlJ2VzRaNTlGIyLOKFwe8Jjz0vi2XZqJc35Edx4SJh2IkjwnWUjc0aytI5diqQ==", null, false, "4ad17675-acb3-403d-ae58-abb56ba4a7a4", false, "user8" },
                    { "b1586079-78c0-46de-9a7a-b8a96feda5b2", 0, "276e1565-a79a-419a-b807-2b21362d6255", "user4@user.com", false, false, null, "USER4@USER.COM", "USER4", "AQAAAAIAAYagAAAAELvuhlJ2VzRaNTlGIyLOKFwe8Jjz0vi2XZqJc35Edx4SJh2IkjwnWUjc0aytI5diqQ==", null, false, "df9f5ff5-1dd0-40e1-a932-2a2a79128087", false, "user4" },
                    { "bac23f98-2305-408b-bb06-2990203cc051", 0, "4846f69f-b34f-4ebd-9bb5-7091da3102ab", "user10@user.com", false, false, null, "USER10@USER.COM", "USER10", "AQAAAAIAAYagAAAAELvuhlJ2VzRaNTlGIyLOKFwe8Jjz0vi2XZqJc35Edx4SJh2IkjwnWUjc0aytI5diqQ==", null, false, "cef4f155-e831-4dd1-bcd6-a378bc7b7f17", false, "user10" },
                    { "e18d2c84-057a-4b08-8a1f-98eb1c61d8fa", 0, "98c090b9-9e04-4c7a-84fa-1ea931453319", "user3@user.com", false, false, null, "USER3@USER.COM", "USER3", "AQAAAAIAAYagAAAAELvuhlJ2VzRaNTlGIyLOKFwe8Jjz0vi2XZqJc35Edx4SJh2IkjwnWUjc0aytI5diqQ==", null, false, "7d97d950-c2d0-4670-9f8d-0c39e13d61b8", false, "user3" },
                    { "edf0b68c-b259-460d-8580-cbaa1b559cb4", 0, "1f3d7282-090e-4c16-b500-1eea2b28b3a4", "user7@user.com", false, false, null, "USER7@USER.COM", "USER7", "AQAAAAIAAYagAAAAELvuhlJ2VzRaNTlGIyLOKFwe8Jjz0vi2XZqJc35Edx4SJh2IkjwnWUjc0aytI5diqQ==", null, false, "1dc9f5a5-c483-42f2-be25-a9777c25e618", false, "user7" },
                    { "fe1ea75e-f9f8-48ce-b6c9-99800ee6077d", 0, "00f8a617-91ad-4460-9e48-cffe6b0142c2", "user5@user.com", false, false, null, "USER5@USER.COM", "USER5", "AQAAAAIAAYagAAAAELvuhlJ2VzRaNTlGIyLOKFwe8Jjz0vi2XZqJc35Edx4SJh2IkjwnWUjc0aytI5diqQ==", null, false, "8c8fc676-4ddb-4f8c-b04d-dc7bd39a5869", false, "user5" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5aa88b9c-a8de-482d-a802-d1d2bf4075fa", "0a137398-bcc4-4c66-b425-76347c03f64b" },
                    { "5aa88b9c-a8de-482d-a802-d1d2bf4075fa", "118ae8c4-0854-437b-ad9c-ccd218d1c287" },
                    { "5aa88b9c-a8de-482d-a802-d1d2bf4075fa", "463bdd5c-ca52-44ff-8060-f8914b55bb54" },
                    { "5aa88b9c-a8de-482d-a802-d1d2bf4075fa", "51de2c9e-54d1-4b51-b727-7b31e58ad2c8" },
                    { "5aa88b9c-a8de-482d-a802-d1d2bf4075fa", "86cfb1ff-d836-4b09-ab82-f0d1e9ff0b6e" },
                    { "5aa88b9c-a8de-482d-a802-d1d2bf4075fa", "b1586079-78c0-46de-9a7a-b8a96feda5b2" },
                    { "5aa88b9c-a8de-482d-a802-d1d2bf4075fa", "bac23f98-2305-408b-bb06-2990203cc051" },
                    { "5aa88b9c-a8de-482d-a802-d1d2bf4075fa", "e18d2c84-057a-4b08-8a1f-98eb1c61d8fa" },
                    { "5aa88b9c-a8de-482d-a802-d1d2bf4075fa", "edf0b68c-b259-460d-8580-cbaa1b559cb4" },
                    { "5aa88b9c-a8de-482d-a802-d1d2bf4075fa", "fe1ea75e-f9f8-48ce-b6c9-99800ee6077d" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5aa88b9c-a8de-482d-a802-d1d2bf4075fa", "0a137398-bcc4-4c66-b425-76347c03f64b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5aa88b9c-a8de-482d-a802-d1d2bf4075fa", "118ae8c4-0854-437b-ad9c-ccd218d1c287" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5aa88b9c-a8de-482d-a802-d1d2bf4075fa", "463bdd5c-ca52-44ff-8060-f8914b55bb54" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5aa88b9c-a8de-482d-a802-d1d2bf4075fa", "51de2c9e-54d1-4b51-b727-7b31e58ad2c8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5aa88b9c-a8de-482d-a802-d1d2bf4075fa", "86cfb1ff-d836-4b09-ab82-f0d1e9ff0b6e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5aa88b9c-a8de-482d-a802-d1d2bf4075fa", "b1586079-78c0-46de-9a7a-b8a96feda5b2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5aa88b9c-a8de-482d-a802-d1d2bf4075fa", "bac23f98-2305-408b-bb06-2990203cc051" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5aa88b9c-a8de-482d-a802-d1d2bf4075fa", "e18d2c84-057a-4b08-8a1f-98eb1c61d8fa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5aa88b9c-a8de-482d-a802-d1d2bf4075fa", "edf0b68c-b259-460d-8580-cbaa1b559cb4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5aa88b9c-a8de-482d-a802-d1d2bf4075fa", "fe1ea75e-f9f8-48ce-b6c9-99800ee6077d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5aa88b9c-a8de-482d-a802-d1d2bf4075fa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a137398-bcc4-4c66-b425-76347c03f64b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "118ae8c4-0854-437b-ad9c-ccd218d1c287");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "463bdd5c-ca52-44ff-8060-f8914b55bb54");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51de2c9e-54d1-4b51-b727-7b31e58ad2c8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86cfb1ff-d836-4b09-ab82-f0d1e9ff0b6e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1586079-78c0-46de-9a7a-b8a96feda5b2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bac23f98-2305-408b-bb06-2990203cc051");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18d2c84-057a-4b08-8a1f-98eb1c61d8fa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edf0b68c-b259-460d-8580-cbaa1b559cb4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe1ea75e-f9f8-48ce-b6c9-99800ee6077d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b42ab474-1b3e-4167-8963-4503dd2422c7", null, "TestUser", "TESTUSER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "610026bf-2fd1-48b2-b0a0-e0500b7a5e7d", 0, "180c6abd-15ad-4b94-ac0d-35fbf35cc060", "user6@user.com", false, false, null, "USER6@USER.COM", "USER6", "AQAAAAIAAYagAAAAEHCIgwEAEAjqCRHpVkd5Un6Bp+vymMkpeTCdpwRDKe7A62cc6e1O8P8k0IuyXSMAAw==", null, false, "a3dba566-78b7-47cf-91e0-4a377c08c674", false, "user6" },
                    { "6d5b5bd2-30c8-4c05-b7e2-d606f998436b", 0, "c56db349-700f-4128-9e2f-d8d237381753", "user5@user.com", false, false, null, "USER5@USER.COM", "USER5", "AQAAAAIAAYagAAAAEHCIgwEAEAjqCRHpVkd5Un6Bp+vymMkpeTCdpwRDKe7A62cc6e1O8P8k0IuyXSMAAw==", null, false, "f44ce10e-007b-4cb1-b233-0f6444185661", false, "user5" },
                    { "73f146e4-b5a7-4253-a845-990d2a86509a", 0, "b5df3ea3-8512-441d-aabc-8ae19b9f47a3", "user9@user.com", false, false, null, "USER9@USER.COM", "USER9", "AQAAAAIAAYagAAAAEHCIgwEAEAjqCRHpVkd5Un6Bp+vymMkpeTCdpwRDKe7A62cc6e1O8P8k0IuyXSMAAw==", null, false, "92cd5418-a7c0-45bc-8746-7df1e4e740a5", false, "user9" },
                    { "8aac8893-c4a7-456d-8d71-adcfb237835c", 0, "d65bf25e-145f-4ca4-a98a-9c3d0bebc0d5", "user10@user.com", false, false, null, "USER10@USER.COM", "USER10", "AQAAAAIAAYagAAAAEHCIgwEAEAjqCRHpVkd5Un6Bp+vymMkpeTCdpwRDKe7A62cc6e1O8P8k0IuyXSMAAw==", null, false, "39552002-234d-4ee3-aae9-697e08c189f9", false, "user10" },
                    { "a90cb0da-1ae6-475b-9f93-cfe2abbf4e77", 0, "1b216b7c-c1fc-4b34-b0f6-bf6c89af27e4", "user8@user.com", false, false, null, "USER8@USER.COM", "USER8", "AQAAAAIAAYagAAAAEHCIgwEAEAjqCRHpVkd5Un6Bp+vymMkpeTCdpwRDKe7A62cc6e1O8P8k0IuyXSMAAw==", null, false, "373e23cd-6c5d-4dee-9e93-fdc5c098dfc1", false, "user8" },
                    { "b4b73e25-624b-4903-aade-e5603262e766", 0, "743b6d02-9ecc-417f-946a-0a2f20f211f9", "user4@user.com", false, false, null, "USER4@USER.COM", "USER4", "AQAAAAIAAYagAAAAEHCIgwEAEAjqCRHpVkd5Un6Bp+vymMkpeTCdpwRDKe7A62cc6e1O8P8k0IuyXSMAAw==", null, false, "6e2ab1dd-7dfa-4e3d-9556-40a2daa839f3", false, "user4" },
                    { "baf34ac9-b8f2-4cf3-842d-08ca719e4179", 0, "f9da4800-e263-49b4-a6a2-afd960170100", "user7@user.com", false, false, null, "USER7@USER.COM", "USER7", "AQAAAAIAAYagAAAAEHCIgwEAEAjqCRHpVkd5Un6Bp+vymMkpeTCdpwRDKe7A62cc6e1O8P8k0IuyXSMAAw==", null, false, "fcb8b604-db64-4996-ab63-b2bf511f3ef4", false, "user7" },
                    { "d465ffc3-c504-4f71-b01d-8c92a99d9c1f", 0, "38daf96f-cb71-4bd1-90c0-9762f4d4fa50", "user3@user.com", false, false, null, "USER3@USER.COM", "USER3", "AQAAAAIAAYagAAAAEHCIgwEAEAjqCRHpVkd5Un6Bp+vymMkpeTCdpwRDKe7A62cc6e1O8P8k0IuyXSMAAw==", null, false, "b32aa459-e10e-41cb-87e2-1274bb7672ba", false, "user3" },
                    { "d7b2e4dd-7a94-4fd2-8f65-da9e1a5c7d30", 0, "9531d03c-536b-4627-a23d-1519e461b8f6", "user1@user.com", false, false, null, "USER1@USER.COM", "USER1", "AQAAAAIAAYagAAAAEHCIgwEAEAjqCRHpVkd5Un6Bp+vymMkpeTCdpwRDKe7A62cc6e1O8P8k0IuyXSMAAw==", null, false, "631ca327-55a4-4f97-8d1f-4ffb41ea9bea", false, "user1" },
                    { "fc671021-4d92-452e-8b6f-26124dd24de1", 0, "ca12ebdc-978d-4384-acfd-06a348754be7", "user2@user.com", false, false, null, "USER2@USER.COM", "USER2", "AQAAAAIAAYagAAAAEHCIgwEAEAjqCRHpVkd5Un6Bp+vymMkpeTCdpwRDKe7A62cc6e1O8P8k0IuyXSMAAw==", null, false, "f1a88463-8655-42ef-947a-48a27b6f131f", false, "user2" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b42ab474-1b3e-4167-8963-4503dd2422c7", "610026bf-2fd1-48b2-b0a0-e0500b7a5e7d" },
                    { "b42ab474-1b3e-4167-8963-4503dd2422c7", "6d5b5bd2-30c8-4c05-b7e2-d606f998436b" },
                    { "b42ab474-1b3e-4167-8963-4503dd2422c7", "73f146e4-b5a7-4253-a845-990d2a86509a" },
                    { "b42ab474-1b3e-4167-8963-4503dd2422c7", "8aac8893-c4a7-456d-8d71-adcfb237835c" },
                    { "b42ab474-1b3e-4167-8963-4503dd2422c7", "a90cb0da-1ae6-475b-9f93-cfe2abbf4e77" },
                    { "b42ab474-1b3e-4167-8963-4503dd2422c7", "b4b73e25-624b-4903-aade-e5603262e766" },
                    { "b42ab474-1b3e-4167-8963-4503dd2422c7", "baf34ac9-b8f2-4cf3-842d-08ca719e4179" },
                    { "b42ab474-1b3e-4167-8963-4503dd2422c7", "d465ffc3-c504-4f71-b01d-8c92a99d9c1f" },
                    { "b42ab474-1b3e-4167-8963-4503dd2422c7", "d7b2e4dd-7a94-4fd2-8f65-da9e1a5c7d30" },
                    { "b42ab474-1b3e-4167-8963-4503dd2422c7", "fc671021-4d92-452e-8b6f-26124dd24de1" }
                });
        }
    }
}
