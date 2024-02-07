using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Jaysbe.Migrations
{
    /// <inheritdoc />
    public partial class ProductThumbnailToNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c95956e6-acc7-436b-895b-e57def9e86fc", "0dccfd3d-3507-4fa9-a492-1e3a20bb17f6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c95956e6-acc7-436b-895b-e57def9e86fc", "12ebacc1-4978-44bf-be4e-46f0e4b8eeaf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c95956e6-acc7-436b-895b-e57def9e86fc", "23e68034-ad75-45c0-bffc-7c1bdc998eb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c95956e6-acc7-436b-895b-e57def9e86fc", "7c9480c7-ac8d-4467-918c-d2c59de80105" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c95956e6-acc7-436b-895b-e57def9e86fc", "a8e200e5-1df0-4ed2-bf0f-d6d6bf69b26b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c95956e6-acc7-436b-895b-e57def9e86fc", "b611ef74-3e7c-4662-9727-e60f00d8fc45" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c95956e6-acc7-436b-895b-e57def9e86fc", "d6d0026a-a576-4c87-94f7-129db1cc99cf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c95956e6-acc7-436b-895b-e57def9e86fc", "d9763a5c-7c96-4587-a00b-4568e26fe336" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c95956e6-acc7-436b-895b-e57def9e86fc", "e774cd2e-fb97-4476-8768-42a0aeedf058" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c95956e6-acc7-436b-895b-e57def9e86fc", "ed292b3c-7339-4e11-a5ee-030a1e3cf6c6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c95956e6-acc7-436b-895b-e57def9e86fc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0dccfd3d-3507-4fa9-a492-1e3a20bb17f6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12ebacc1-4978-44bf-be4e-46f0e4b8eeaf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23e68034-ad75-45c0-bffc-7c1bdc998eb9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c9480c7-ac8d-4467-918c-d2c59de80105");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8e200e5-1df0-4ed2-bf0f-d6d6bf69b26b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b611ef74-3e7c-4662-9727-e60f00d8fc45");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6d0026a-a576-4c87-94f7-129db1cc99cf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d9763a5c-7c96-4587-a00b-4568e26fe336");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e774cd2e-fb97-4476-8768-42a0aeedf058");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed292b3c-7339-4e11-a5ee-030a1e3cf6c6");

            migrationBuilder.AlterColumn<string>(
                name: "ThumbnailUrl",
                table: "Products",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "ThumbnailUrl",
                table: "Products",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c95956e6-acc7-436b-895b-e57def9e86fc", null, "TestUser", "TESTUSER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0dccfd3d-3507-4fa9-a492-1e3a20bb17f6", 0, "269eced9-1737-41ba-b6a6-735bf713a555", "user5@user.com", false, false, null, "USER5@USER.COM", "USER5", "AQAAAAIAAYagAAAAEIWF/3oUezPriVbbFS2fTuCQCPP6eMgrB6vw1cmksdt/Ir15czs3m26DdD8XCD8LBw==", null, false, "ed3e401b-d0f0-4cb7-ae9c-abf7adbdb188", false, "user5" },
                    { "12ebacc1-4978-44bf-be4e-46f0e4b8eeaf", 0, "06097a27-8e3a-47a5-9bf1-84c596b11ab9", "user9@user.com", false, false, null, "USER9@USER.COM", "USER9", "AQAAAAIAAYagAAAAEILcElQXXFho4lNII2660g+swTO0gowwrrvL3Np9A0TZEBcZe82RqY1nEtFRt4zDTQ==", null, false, "fe7288ee-2a37-431e-9bc4-c57e72d02995", false, "user9" },
                    { "23e68034-ad75-45c0-bffc-7c1bdc998eb9", 0, "a89a947a-0874-4390-aeb8-a7c8a022a09f", "user10@user.com", false, false, null, "USER10@USER.COM", "USER10", "AQAAAAIAAYagAAAAEAlHFe2QEN/+5zXCD4G2rq0bzWIx+dWNDgx4RGlauoPJXg1mgynyLZ410XqfK/p59w==", null, false, "ff8a8b0b-6ef5-4f07-8f3d-f21b4e813147", false, "user10" },
                    { "7c9480c7-ac8d-4467-918c-d2c59de80105", 0, "32ed4966-128a-45af-913a-80717ebdaf58", "user7@user.com", false, false, null, "USER7@USER.COM", "USER7", "AQAAAAIAAYagAAAAELFMd9CFyZTlOjWt6eLIC2H39wkCMBUQC25SJ2OQeu+yIZ35+GTFZg/vt8n6BpP6Ug==", null, false, "34d85b12-20ef-486b-ad69-d34e9bb25611", false, "user7" },
                    { "a8e200e5-1df0-4ed2-bf0f-d6d6bf69b26b", 0, "3bc3fd59-7f2a-4689-ac0f-9affda39fc84", "user6@user.com", false, false, null, "USER6@USER.COM", "USER6", "AQAAAAIAAYagAAAAEJGlvb0PN9kIITrQijtaDl1n0BDrZi7gA7uDII+QDPw3YSAasnVbwwopmFhGT3x99g==", null, false, "f36bb3f8-1aad-4498-b4dd-18207931049e", false, "user6" },
                    { "b611ef74-3e7c-4662-9727-e60f00d8fc45", 0, "67541eab-22c2-4996-a339-8dc2232b9daf", "user8@user.com", false, false, null, "USER8@USER.COM", "USER8", "AQAAAAIAAYagAAAAEP6G/nJWag8A6H0orGCE9DKli3pe+QdNjME3MrLJ8nLtWykVr+KyNjQh+Z+ANEXRQg==", null, false, "33d566a6-9929-456a-b683-23324269ccbc", false, "user8" },
                    { "d6d0026a-a576-4c87-94f7-129db1cc99cf", 0, "a3f411c6-9b5d-4482-b4bf-9a9fb3cc47a4", "user4@user.com", false, false, null, "USER4@USER.COM", "USER4", "AQAAAAIAAYagAAAAEE8k1xttaU8jAR8aoHwg2t1nR7wr5m/fy/SR9fHOJX0tN+/3g472W3ZoU78pT90pBQ==", null, false, "c31e187d-fbfa-4639-91b6-bfcb6a352884", false, "user4" },
                    { "d9763a5c-7c96-4587-a00b-4568e26fe336", 0, "5a44faac-1dce-4992-a342-27f087d054c6", "user1@user.com", false, false, null, "USER1@USER.COM", "USER1", "AQAAAAIAAYagAAAAEPV0qkIKfTa20PWNLmklj9KrDsLV1lVbY5f9CaBYnqvxHfgpHwPmaX8fhYuzRG7PTQ==", null, false, "31d86ca9-4045-46c8-b292-a076f84bb10b", false, "user1" },
                    { "e774cd2e-fb97-4476-8768-42a0aeedf058", 0, "494a9f5c-2fb8-402e-9d8d-b33f0374e532", "user3@user.com", false, false, null, "USER3@USER.COM", "USER3", "AQAAAAIAAYagAAAAENAgLe0ZbfgjebXLu7OSmMNUzsUWgkvnxdPQWcaACuKQ9ftVePphG8x8tPvGExWFJA==", null, false, "6b34ab95-7f3f-4335-b452-73cf19c37c42", false, "user3" },
                    { "ed292b3c-7339-4e11-a5ee-030a1e3cf6c6", 0, "78093144-969f-498c-afc3-1c44acb5651b", "user2@user.com", false, false, null, "USER2@USER.COM", "USER2", "AQAAAAIAAYagAAAAECInyFGzTyuJAB707Cj5Rjyp6+yFI7NpZxLHnMAbKE5uWMmC4EowFyWZrjT9JRMetA==", null, false, "7675ebdb-492b-42c3-a1b0-dfed92ce84d3", false, "user2" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c95956e6-acc7-436b-895b-e57def9e86fc", "0dccfd3d-3507-4fa9-a492-1e3a20bb17f6" },
                    { "c95956e6-acc7-436b-895b-e57def9e86fc", "12ebacc1-4978-44bf-be4e-46f0e4b8eeaf" },
                    { "c95956e6-acc7-436b-895b-e57def9e86fc", "23e68034-ad75-45c0-bffc-7c1bdc998eb9" },
                    { "c95956e6-acc7-436b-895b-e57def9e86fc", "7c9480c7-ac8d-4467-918c-d2c59de80105" },
                    { "c95956e6-acc7-436b-895b-e57def9e86fc", "a8e200e5-1df0-4ed2-bf0f-d6d6bf69b26b" },
                    { "c95956e6-acc7-436b-895b-e57def9e86fc", "b611ef74-3e7c-4662-9727-e60f00d8fc45" },
                    { "c95956e6-acc7-436b-895b-e57def9e86fc", "d6d0026a-a576-4c87-94f7-129db1cc99cf" },
                    { "c95956e6-acc7-436b-895b-e57def9e86fc", "d9763a5c-7c96-4587-a00b-4568e26fe336" },
                    { "c95956e6-acc7-436b-895b-e57def9e86fc", "e774cd2e-fb97-4476-8768-42a0aeedf058" },
                    { "c95956e6-acc7-436b-895b-e57def9e86fc", "ed292b3c-7339-4e11-a5ee-030a1e3cf6c6" }
                });
        }
    }
}
