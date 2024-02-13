using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Jaysbe.Migrations
{
    /// <inheritdoc />
    public partial class OnModelCreatingOptimization : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7c73f719-3c15-4b03-90a5-b0cacbaaa6e4", "091bbb3f-99db-49c3-9b1b-452737d43d2d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7c73f719-3c15-4b03-90a5-b0cacbaaa6e4", "29c7f25f-2729-462e-840d-fce256f7308c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7c73f719-3c15-4b03-90a5-b0cacbaaa6e4", "331b9943-8fa5-42c4-aef9-ecaf64e21cbe" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7c73f719-3c15-4b03-90a5-b0cacbaaa6e4", "3cbcd49e-ecca-4e33-8cdf-687ea64b4a61" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7c73f719-3c15-4b03-90a5-b0cacbaaa6e4", "488121c5-7972-47a9-9f52-25cb3cfbad82" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7c73f719-3c15-4b03-90a5-b0cacbaaa6e4", "53e6592a-18c1-4c30-ac95-b5c990aa2f3d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7c73f719-3c15-4b03-90a5-b0cacbaaa6e4", "5aba5ad5-f240-4d8d-a570-2967960dd644" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7c73f719-3c15-4b03-90a5-b0cacbaaa6e4", "7b7ec45d-0828-475d-bf0f-5a6449a36d8e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7c73f719-3c15-4b03-90a5-b0cacbaaa6e4", "900ff97a-5684-4fee-b024-6e1346f0f81a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7c73f719-3c15-4b03-90a5-b0cacbaaa6e4", "fa6b6278-5bf3-42a5-835d-c0f44e591214" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c73f719-3c15-4b03-90a5-b0cacbaaa6e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "091bbb3f-99db-49c3-9b1b-452737d43d2d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29c7f25f-2729-462e-840d-fce256f7308c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "331b9943-8fa5-42c4-aef9-ecaf64e21cbe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3cbcd49e-ecca-4e33-8cdf-687ea64b4a61");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "488121c5-7972-47a9-9f52-25cb3cfbad82");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53e6592a-18c1-4c30-ac95-b5c990aa2f3d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5aba5ad5-f240-4d8d-a570-2967960dd644");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7b7ec45d-0828-475d-bf0f-5a6449a36d8e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "900ff97a-5684-4fee-b024-6e1346f0f81a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa6b6278-5bf3-42a5-835d-c0f44e591214");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "7c73f719-3c15-4b03-90a5-b0cacbaaa6e4", null, "TestUser", "TESTUSER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "091bbb3f-99db-49c3-9b1b-452737d43d2d", 0, "70f897ae-c18e-4b89-aab2-812fe8a38f1a", "user7@user.com", false, false, null, "USER7@USER.COM", "USER7", "AQAAAAIAAYagAAAAEL2Es0K4vYod8YSA9suSLbrK9/y1kfQ9pWqKn2F72ZbqlX1vw6T7dHENX6N7RO4JLg==", null, false, "c9ed5018-ee40-44f8-aede-e491f79dd1d8", false, "user7" },
                    { "29c7f25f-2729-462e-840d-fce256f7308c", 0, "382e57a9-d40a-40ef-b991-0ad30a1b35f4", "user2@user.com", false, false, null, "USER2@USER.COM", "USER2", "AQAAAAIAAYagAAAAEMTNERi546M/36CBkK3yaQngb72AJJ1ALz4NOlivySjDfZPDEB2FeZf0JrvJSN194w==", null, false, "bbbbae55-d9c2-4344-a75d-7bf57dfbd1b4", false, "user2" },
                    { "331b9943-8fa5-42c4-aef9-ecaf64e21cbe", 0, "35737870-6fd4-4a54-847b-5c403405eda1", "user5@user.com", false, false, null, "USER5@USER.COM", "USER5", "AQAAAAIAAYagAAAAECZJYP0iVQrmcBN9NZiq6QECT6F+eDuC2B0P7eudg+GNNVm0rQdz5D3Y8rFcU4Tv8Q==", null, false, "ca7744aa-00d1-4fc1-86c0-c8dfa90d7d68", false, "user5" },
                    { "3cbcd49e-ecca-4e33-8cdf-687ea64b4a61", 0, "17a621b2-8886-4d80-89f8-2798bb66b9d2", "user8@user.com", false, false, null, "USER8@USER.COM", "USER8", "AQAAAAIAAYagAAAAEJ/cALEpxzwOfN4WCNdBPByTqsjQ6omPqdDkK0af8+57vhtpB/uXTxIEmjUpYCjnNA==", null, false, "7f16d6ea-65ca-426d-aafb-9928266ba11f", false, "user8" },
                    { "488121c5-7972-47a9-9f52-25cb3cfbad82", 0, "dc07b2d3-cb3b-4708-996f-5b1ccbfd1ec0", "user3@user.com", false, false, null, "USER3@USER.COM", "USER3", "AQAAAAIAAYagAAAAEMDs2zYL3dDFEdhy1yL0Oo9HohVEhB7Qysd+63+ST/Aa+RA8JPvqYLgqEn1QEg6uaw==", null, false, "66c4f1d8-85be-4f69-903f-617f6fde792f", false, "user3" },
                    { "53e6592a-18c1-4c30-ac95-b5c990aa2f3d", 0, "1fd6e910-3cf9-4e7e-907a-18b90f5856fd", "user9@user.com", false, false, null, "USER9@USER.COM", "USER9", "AQAAAAIAAYagAAAAEEJjRm4I36tE5wHjiE17Tkw/BQJ9h9+71HhcFRe/VQT7wAXzT1x4JBuUeveM+1rXqw==", null, false, "e2f710f5-f226-4405-88bc-86a202eebde5", false, "user9" },
                    { "5aba5ad5-f240-4d8d-a570-2967960dd644", 0, "01f178f4-afae-4676-8678-62cb98fe7f2c", "user6@user.com", false, false, null, "USER6@USER.COM", "USER6", "AQAAAAIAAYagAAAAEIuoRg+KettyJEhGsjHpF6eW5NquFfbMIacaO/K3yXHxswH1oAgfIZoGb68l3OxV6Q==", null, false, "bef99070-eb1f-4eb6-ba20-f5072af0b47e", false, "user6" },
                    { "7b7ec45d-0828-475d-bf0f-5a6449a36d8e", 0, "bb31ebcd-7503-4b54-afc5-263635d873d6", "user10@user.com", false, false, null, "USER10@USER.COM", "USER10", "AQAAAAIAAYagAAAAEMHm8u0XmTJvi4pxNQ/s3TXTYXF44M6tneP0wtiUIhi/0Rj859xZpGpE82EH7tv0ew==", null, false, "ac883cc6-0d90-4918-a658-157a0e9e80ee", false, "user10" },
                    { "900ff97a-5684-4fee-b024-6e1346f0f81a", 0, "cce663e2-8a7f-451c-94d5-1e0ad21d5db7", "user1@user.com", false, false, null, "USER1@USER.COM", "USER1", "AQAAAAIAAYagAAAAELyt/sWxruTEGDTVk8zrq9BCRSkKYUywbMDEFw1UCCiUzbkUqonUwW0xiTY5Oxo9tQ==", null, false, "148b30a1-67ed-4c0d-b296-82cc080aada4", false, "user1" },
                    { "fa6b6278-5bf3-42a5-835d-c0f44e591214", 0, "d45b9471-a6d1-4d37-b4e4-420f561726f3", "user4@user.com", false, false, null, "USER4@USER.COM", "USER4", "AQAAAAIAAYagAAAAEPS8SBLYpzUXLYUCAicI07ID+B1BQ0GyOGA1ktk03lXhfmOpD8NaCxV1DRqZe7ExGg==", null, false, "bc516504-8c31-4e8b-a8e4-c66d9ff7701f", false, "user4" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "7c73f719-3c15-4b03-90a5-b0cacbaaa6e4", "091bbb3f-99db-49c3-9b1b-452737d43d2d" },
                    { "7c73f719-3c15-4b03-90a5-b0cacbaaa6e4", "29c7f25f-2729-462e-840d-fce256f7308c" },
                    { "7c73f719-3c15-4b03-90a5-b0cacbaaa6e4", "331b9943-8fa5-42c4-aef9-ecaf64e21cbe" },
                    { "7c73f719-3c15-4b03-90a5-b0cacbaaa6e4", "3cbcd49e-ecca-4e33-8cdf-687ea64b4a61" },
                    { "7c73f719-3c15-4b03-90a5-b0cacbaaa6e4", "488121c5-7972-47a9-9f52-25cb3cfbad82" },
                    { "7c73f719-3c15-4b03-90a5-b0cacbaaa6e4", "53e6592a-18c1-4c30-ac95-b5c990aa2f3d" },
                    { "7c73f719-3c15-4b03-90a5-b0cacbaaa6e4", "5aba5ad5-f240-4d8d-a570-2967960dd644" },
                    { "7c73f719-3c15-4b03-90a5-b0cacbaaa6e4", "7b7ec45d-0828-475d-bf0f-5a6449a36d8e" },
                    { "7c73f719-3c15-4b03-90a5-b0cacbaaa6e4", "900ff97a-5684-4fee-b024-6e1346f0f81a" },
                    { "7c73f719-3c15-4b03-90a5-b0cacbaaa6e4", "fa6b6278-5bf3-42a5-835d-c0f44e591214" }
                });
        }
    }
}
