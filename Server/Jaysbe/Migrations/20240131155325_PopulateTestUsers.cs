using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Jaysbe.Migrations
{
    /// <inheritdoc />
    public partial class PopulateTestUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "00000000-c98a-4ef1-8dd4-ede04831d1e7", "01d3c6f7-1e41-4d24-823c-77de32db1648" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "00000000-c98a-4ef1-8dd4-ede04831d1e7", "48e8f4c0-25da-402f-8f58-aef4b82b9e33" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "00000000-c98a-4ef1-8dd4-ede04831d1e7", "5d33a5b7-f284-42e2-b9fa-8347f6272fef" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "00000000-c98a-4ef1-8dd4-ede04831d1e7", "77b88517-e8eb-48a4-b458-71b2c15b46b1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "00000000-c98a-4ef1-8dd4-ede04831d1e7", "9d2da8ae-d748-46c3-8a8d-78a339905924" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "00000000-c98a-4ef1-8dd4-ede04831d1e7", "9ef8ed63-c822-4ae5-93d7-a71626cfca22" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "00000000-c98a-4ef1-8dd4-ede04831d1e7", "aa40b2e2-15cc-4b5b-9094-439178a8ab1c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "00000000-c98a-4ef1-8dd4-ede04831d1e7", "c3bb5c61-6e1a-4803-a1e2-0e6817929aa8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "00000000-c98a-4ef1-8dd4-ede04831d1e7", "c4202c1e-13d6-4605-8714-5f06fe8b7e8e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "00000000-c98a-4ef1-8dd4-ede04831d1e7", "edbd34f3-3fd5-47c4-9449-92ce03bcff38" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-c98a-4ef1-8dd4-ede04831d1e7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01d3c6f7-1e41-4d24-823c-77de32db1648");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48e8f4c0-25da-402f-8f58-aef4b82b9e33");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5d33a5b7-f284-42e2-b9fa-8347f6272fef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77b88517-e8eb-48a4-b458-71b2c15b46b1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d2da8ae-d748-46c3-8a8d-78a339905924");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ef8ed63-c822-4ae5-93d7-a71626cfca22");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa40b2e2-15cc-4b5b-9094-439178a8ab1c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3bb5c61-6e1a-4803-a1e2-0e6817929aa8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c4202c1e-13d6-4605-8714-5f06fe8b7e8e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edbd34f3-3fd5-47c4-9449-92ce03bcff38");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "00000000-c98a-4ef1-8dd4-ede04831d1e7", null, "TestUser", "TESTUSER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "01d3c6f7-1e41-4d24-823c-77de32db1648", 0, "40a04054-8b1a-4883-9ec9-4bc82e8a9b26", "user6@user.com", false, false, null, "USER6@USER.COM", "USER6", "AQAAAAIAAYagAAAAEIsyuQvMrn0DLbgLBUycQtLZLc06ZNqRrHjy8KRXCcZ7xRPQOma8riOFsMhxyaihhg==", null, false, "2187052b-6968-48e5-b4fa-0feebca1bd29", false, "user6" },
                    { "48e8f4c0-25da-402f-8f58-aef4b82b9e33", 0, "58cb1763-7fcd-4df0-a831-e6762dfd9bfd", "user5@user.com", false, false, null, "USER5@USER.COM", "USER5", "AQAAAAIAAYagAAAAEBrDUGRWaafJUv1aymQBKCtn3/6FnebqFGj5I+pm5yONqeORCvY15E2qZiKw69is6A==", null, false, "942e8eb9-c8d8-47fd-ba30-d48670e358f3", false, "user5" },
                    { "5d33a5b7-f284-42e2-b9fa-8347f6272fef", 0, "abda08ae-2d3a-4db5-99c5-df1c6ab54ae1", "user8@user.com", false, false, null, "USER8@USER.COM", "USER8", "AQAAAAIAAYagAAAAEAhL3YDkQRkRatxiVpupftp1t+9+xxn6wZ6kVPiy0jNgBsS2foWpVMKWuj7V4S2+0A==", null, false, "2c59d8da-44d1-4e94-b36d-c6007ede3aea", false, "user8" },
                    { "77b88517-e8eb-48a4-b458-71b2c15b46b1", 0, "45f5865d-cfbd-49e9-bfae-4180bc495db5", "user10@user.com", false, false, null, "USER10@USER.COM", "USER10", "AQAAAAIAAYagAAAAEM7vgHrjqzAIJUWbVm2c2OFMpwxGGyBYsuuRWFEO+IASNFp1MWL8NRYtEfRp9yPHaw==", null, false, "879201e1-11d7-4bda-ad9d-f53f4e73db21", false, "user10" },
                    { "9d2da8ae-d748-46c3-8a8d-78a339905924", 0, "6305f286-8672-4dec-9a3a-9ec35b56157b", "user2@user.com", false, false, null, "USER2@USER.COM", "USER2", "AQAAAAIAAYagAAAAEK0rCsE+udEdPJ8i1A571Ty+R6nM0gn+iMLsveeehoA9+NW0DtYpeB0DGbRyr+Nu9Q==", null, false, "f228e4e3-3e56-4fd1-a7f2-75dd855904ee", false, "user2" },
                    { "9ef8ed63-c822-4ae5-93d7-a71626cfca22", 0, "052b10e1-2286-4be0-80c0-1fc46e7bab79", "user7@user.com", false, false, null, "USER7@USER.COM", "USER7", "AQAAAAIAAYagAAAAEEC4lYkMsW87FVfAYVV58Cd3sf7J5LKH19unrf7oU2GFE+O/qULg/8367g2uSjuaBQ==", null, false, "e0887f4c-5553-47c6-a9de-883397b3eeb7", false, "user7" },
                    { "aa40b2e2-15cc-4b5b-9094-439178a8ab1c", 0, "d19670fb-92bf-47d8-ae10-3ceba256d45f", "user9@user.com", false, false, null, "USER9@USER.COM", "USER9", "AQAAAAIAAYagAAAAELerFHOBru3tDzZsfwmw2EymCsYMxc6mlS5VYhjTBDCaK/lGHV1zzPC6A/JUWS5YHA==", null, false, "c0989d9e-2636-447f-960d-290ca7d8190e", false, "user9" },
                    { "c3bb5c61-6e1a-4803-a1e2-0e6817929aa8", 0, "218bcd13-6b9d-4253-bded-6e38c4ccbceb", "user4@user.com", false, false, null, "USER4@USER.COM", "USER4", "AQAAAAIAAYagAAAAEEs45DOPxYQtYx4M5O9OUItfN7wwoU36smFvffrg3Stz3EFFSz4UpcXvC3dhcDAf6g==", null, false, "7d871496-838e-48aa-b74f-130f9a6b5da7", false, "user4" },
                    { "c4202c1e-13d6-4605-8714-5f06fe8b7e8e", 0, "2e87dae6-24f9-4338-8228-98ee7bc475df", "user3@user.com", false, false, null, "USER3@USER.COM", "USER3", "AQAAAAIAAYagAAAAEEV6yk+fOsaBvR0kRnqBybU5yXXHOUhNsJ1rh6bhCFgQakzKFC2S57vn3+bBVhq9mw==", null, false, "fa71438b-0253-40cd-81eb-97a5b3bc87b1", false, "user3" },
                    { "edbd34f3-3fd5-47c4-9449-92ce03bcff38", 0, "19d1318c-3042-4296-a241-bed20f0de0ce", "user1@user.com", false, false, null, "USER1@USER.COM", "USER1", "AQAAAAIAAYagAAAAEI4HFBn1szIEkPEOwMKRH0Y/76elrDc5WhW27YRBJrQP21Zd4lJO/6hlDBHssz1XLg==", null, false, "818d91df-963f-4d28-8240-15672e22eae3", false, "user1" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "00000000-c98a-4ef1-8dd4-ede04831d1e7", "01d3c6f7-1e41-4d24-823c-77de32db1648" },
                    { "00000000-c98a-4ef1-8dd4-ede04831d1e7", "48e8f4c0-25da-402f-8f58-aef4b82b9e33" },
                    { "00000000-c98a-4ef1-8dd4-ede04831d1e7", "5d33a5b7-f284-42e2-b9fa-8347f6272fef" },
                    { "00000000-c98a-4ef1-8dd4-ede04831d1e7", "77b88517-e8eb-48a4-b458-71b2c15b46b1" },
                    { "00000000-c98a-4ef1-8dd4-ede04831d1e7", "9d2da8ae-d748-46c3-8a8d-78a339905924" },
                    { "00000000-c98a-4ef1-8dd4-ede04831d1e7", "9ef8ed63-c822-4ae5-93d7-a71626cfca22" },
                    { "00000000-c98a-4ef1-8dd4-ede04831d1e7", "aa40b2e2-15cc-4b5b-9094-439178a8ab1c" },
                    { "00000000-c98a-4ef1-8dd4-ede04831d1e7", "c3bb5c61-6e1a-4803-a1e2-0e6817929aa8" },
                    { "00000000-c98a-4ef1-8dd4-ede04831d1e7", "c4202c1e-13d6-4605-8714-5f06fe8b7e8e" },
                    { "00000000-c98a-4ef1-8dd4-ede04831d1e7", "edbd34f3-3fd5-47c4-9449-92ce03bcff38" }
                });
        }
    }
}
