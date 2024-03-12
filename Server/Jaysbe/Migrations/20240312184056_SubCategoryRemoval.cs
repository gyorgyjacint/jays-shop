using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Jaysbe.Migrations
{
    /// <inheritdoc />
    public partial class SubCategoryRemoval : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "91dbc13b-74a8-4534-b5fc-c6d722d105a0", "19e88f67-b954-44f8-9642-3fd7b260328c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "91dbc13b-74a8-4534-b5fc-c6d722d105a0", "5e379750-3656-4d78-baa2-d4df9ae71339" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "91dbc13b-74a8-4534-b5fc-c6d722d105a0", "63ae5ef3-48ce-4242-a165-d4d07c4b35a1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "91dbc13b-74a8-4534-b5fc-c6d722d105a0", "6d23f45e-1a7a-4e11-bac2-33737200b6b8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "91dbc13b-74a8-4534-b5fc-c6d722d105a0", "6ee2bb93-ffd8-42fa-a568-e50dcb6ebfb7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "91dbc13b-74a8-4534-b5fc-c6d722d105a0", "80423ca6-3286-405a-9b6b-8ef33b0be9bd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "91dbc13b-74a8-4534-b5fc-c6d722d105a0", "b220c49f-2e2a-4705-bda1-b1c3e2187346" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "91dbc13b-74a8-4534-b5fc-c6d722d105a0", "b58d8f45-5f44-4409-9ce0-a3e8ad16fff8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "91dbc13b-74a8-4534-b5fc-c6d722d105a0", "c573f512-9d0a-4bd4-a9d9-bbce131457be" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "91dbc13b-74a8-4534-b5fc-c6d722d105a0", "f294b89e-b45f-404e-9615-b880d3b72b1d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91dbc13b-74a8-4534-b5fc-c6d722d105a0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19e88f67-b954-44f8-9642-3fd7b260328c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e379750-3656-4d78-baa2-d4df9ae71339");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63ae5ef3-48ce-4242-a165-d4d07c4b35a1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d23f45e-1a7a-4e11-bac2-33737200b6b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6ee2bb93-ffd8-42fa-a568-e50dcb6ebfb7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80423ca6-3286-405a-9b6b-8ef33b0be9bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b220c49f-2e2a-4705-bda1-b1c3e2187346");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b58d8f45-5f44-4409-9ce0-a3e8ad16fff8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c573f512-9d0a-4bd4-a9d9-bbce131457be");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f294b89e-b45f-404e-9615-b880d3b72b1d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cdb6db18-f783-4cb8-ba75-d8630d953017", null, "TestUser", "TESTUSER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "26b76950-4c74-494b-b214-8278278cbfae", 0, "5dac4857-1e9d-46a8-a459-70141d6edf64", "user5@user.com", false, false, null, "USER5@USER.COM", "USER5", "AQAAAAIAAYagAAAAEAtCuJBun9qwldvof8Nvfpuz9IvangKyOu+T6R0xISfcV+ho708Rx+d1P6c/3xHAfw==", null, false, "5ee4b0d5-be73-4993-8b26-77b23bb5542f", false, "user5" },
                    { "2a73266d-8d96-4cdd-aede-30e4dc6fb397", 0, "868785cb-346a-4d99-9999-40c0694b4032", "user9@user.com", false, false, null, "USER9@USER.COM", "USER9", "AQAAAAIAAYagAAAAEAtCuJBun9qwldvof8Nvfpuz9IvangKyOu+T6R0xISfcV+ho708Rx+d1P6c/3xHAfw==", null, false, "8a4e4f8a-6ea3-44bc-8be3-bc4bf824e909", false, "user9" },
                    { "2ded97b0-48ef-4949-b7fc-348c7c8729ff", 0, "0934dc1c-02de-47bf-9612-1bd40cee7ff8", "user8@user.com", false, false, null, "USER8@USER.COM", "USER8", "AQAAAAIAAYagAAAAEAtCuJBun9qwldvof8Nvfpuz9IvangKyOu+T6R0xISfcV+ho708Rx+d1P6c/3xHAfw==", null, false, "cacc2830-bb8c-4f9f-98be-5eec2ffcdeea", false, "user8" },
                    { "4da5197b-55b0-4379-b780-a966444a6121", 0, "81aaf484-e821-421f-b06f-88d34b386210", "user2@user.com", false, false, null, "USER2@USER.COM", "USER2", "AQAAAAIAAYagAAAAEAtCuJBun9qwldvof8Nvfpuz9IvangKyOu+T6R0xISfcV+ho708Rx+d1P6c/3xHAfw==", null, false, "9ea3e500-81a0-428e-81f6-12a380f3e5d8", false, "user2" },
                    { "83283e6b-b6ce-428a-9d96-5ecf7078e13c", 0, "f970a6b2-6df0-48bc-9fa7-d6246b5e4b93", "user7@user.com", false, false, null, "USER7@USER.COM", "USER7", "AQAAAAIAAYagAAAAEAtCuJBun9qwldvof8Nvfpuz9IvangKyOu+T6R0xISfcV+ho708Rx+d1P6c/3xHAfw==", null, false, "3abe6d49-f2c7-4b7b-ba08-73129fa3bcc2", false, "user7" },
                    { "a926fc06-787d-4974-b776-fe949682193a", 0, "7d14ef90-63b5-401f-a07d-1ecee1096d98", "user10@user.com", false, false, null, "USER10@USER.COM", "USER10", "AQAAAAIAAYagAAAAEAtCuJBun9qwldvof8Nvfpuz9IvangKyOu+T6R0xISfcV+ho708Rx+d1P6c/3xHAfw==", null, false, "e835f563-4fc6-45d0-ab26-9df08f34d633", false, "user10" },
                    { "b949ff85-34d3-4ddf-bbc5-840697d8fae1", 0, "06a87eec-a1c1-43e1-89b7-8dfb7ec62882", "user1@user.com", false, false, null, "USER1@USER.COM", "USER1", "AQAAAAIAAYagAAAAEAtCuJBun9qwldvof8Nvfpuz9IvangKyOu+T6R0xISfcV+ho708Rx+d1P6c/3xHAfw==", null, false, "01bee919-7279-4862-9dfa-21a494dd597e", false, "user1" },
                    { "c69fb24b-8579-4afa-926f-1f00304113bf", 0, "06bd3031-1ecd-440d-96d5-3fcb52533324", "user3@user.com", false, false, null, "USER3@USER.COM", "USER3", "AQAAAAIAAYagAAAAEAtCuJBun9qwldvof8Nvfpuz9IvangKyOu+T6R0xISfcV+ho708Rx+d1P6c/3xHAfw==", null, false, "f36b6aaf-1612-4a38-8adf-2ede63e588b2", false, "user3" },
                    { "e1061245-a3cb-4d2b-940d-b47475970ae7", 0, "ceb0980d-3819-4b81-9f1e-e5054cf2e05c", "user6@user.com", false, false, null, "USER6@USER.COM", "USER6", "AQAAAAIAAYagAAAAEAtCuJBun9qwldvof8Nvfpuz9IvangKyOu+T6R0xISfcV+ho708Rx+d1P6c/3xHAfw==", null, false, "9a50252f-adce-451a-89e0-5c8ff5635cb2", false, "user6" },
                    { "e1a50299-8c68-4d0d-a4d8-2c4aa852f49f", 0, "40cc7dfd-80ab-4a33-bde7-45878e744592", "user4@user.com", false, false, null, "USER4@USER.COM", "USER4", "AQAAAAIAAYagAAAAEAtCuJBun9qwldvof8Nvfpuz9IvangKyOu+T6R0xISfcV+ho708Rx+d1P6c/3xHAfw==", null, false, "2241f50f-dced-4b39-bc1d-11c8e2a65f52", false, "user4" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "cdb6db18-f783-4cb8-ba75-d8630d953017", "26b76950-4c74-494b-b214-8278278cbfae" },
                    { "cdb6db18-f783-4cb8-ba75-d8630d953017", "2a73266d-8d96-4cdd-aede-30e4dc6fb397" },
                    { "cdb6db18-f783-4cb8-ba75-d8630d953017", "2ded97b0-48ef-4949-b7fc-348c7c8729ff" },
                    { "cdb6db18-f783-4cb8-ba75-d8630d953017", "4da5197b-55b0-4379-b780-a966444a6121" },
                    { "cdb6db18-f783-4cb8-ba75-d8630d953017", "83283e6b-b6ce-428a-9d96-5ecf7078e13c" },
                    { "cdb6db18-f783-4cb8-ba75-d8630d953017", "a926fc06-787d-4974-b776-fe949682193a" },
                    { "cdb6db18-f783-4cb8-ba75-d8630d953017", "b949ff85-34d3-4ddf-bbc5-840697d8fae1" },
                    { "cdb6db18-f783-4cb8-ba75-d8630d953017", "c69fb24b-8579-4afa-926f-1f00304113bf" },
                    { "cdb6db18-f783-4cb8-ba75-d8630d953017", "e1061245-a3cb-4d2b-940d-b47475970ae7" },
                    { "cdb6db18-f783-4cb8-ba75-d8630d953017", "e1a50299-8c68-4d0d-a4d8-2c4aa852f49f" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cdb6db18-f783-4cb8-ba75-d8630d953017", "26b76950-4c74-494b-b214-8278278cbfae" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cdb6db18-f783-4cb8-ba75-d8630d953017", "2a73266d-8d96-4cdd-aede-30e4dc6fb397" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cdb6db18-f783-4cb8-ba75-d8630d953017", "2ded97b0-48ef-4949-b7fc-348c7c8729ff" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cdb6db18-f783-4cb8-ba75-d8630d953017", "4da5197b-55b0-4379-b780-a966444a6121" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cdb6db18-f783-4cb8-ba75-d8630d953017", "83283e6b-b6ce-428a-9d96-5ecf7078e13c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cdb6db18-f783-4cb8-ba75-d8630d953017", "a926fc06-787d-4974-b776-fe949682193a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cdb6db18-f783-4cb8-ba75-d8630d953017", "b949ff85-34d3-4ddf-bbc5-840697d8fae1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cdb6db18-f783-4cb8-ba75-d8630d953017", "c69fb24b-8579-4afa-926f-1f00304113bf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cdb6db18-f783-4cb8-ba75-d8630d953017", "e1061245-a3cb-4d2b-940d-b47475970ae7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cdb6db18-f783-4cb8-ba75-d8630d953017", "e1a50299-8c68-4d0d-a4d8-2c4aa852f49f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdb6db18-f783-4cb8-ba75-d8630d953017");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26b76950-4c74-494b-b214-8278278cbfae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a73266d-8d96-4cdd-aede-30e4dc6fb397");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ded97b0-48ef-4949-b7fc-348c7c8729ff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4da5197b-55b0-4379-b780-a966444a6121");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83283e6b-b6ce-428a-9d96-5ecf7078e13c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a926fc06-787d-4974-b776-fe949682193a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b949ff85-34d3-4ddf-bbc5-840697d8fae1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c69fb24b-8579-4afa-926f-1f00304113bf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e1061245-a3cb-4d2b-940d-b47475970ae7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e1a50299-8c68-4d0d-a4d8-2c4aa852f49f");

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    SubCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.SubCategoryId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "91dbc13b-74a8-4534-b5fc-c6d722d105a0", null, "TestUser", "TESTUSER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "19e88f67-b954-44f8-9642-3fd7b260328c", 0, "e17e2070-35d5-40ea-92c3-0f87de252d29", "user10@user.com", false, false, null, "USER10@USER.COM", "USER10", "AQAAAAIAAYagAAAAEP3W9CVhZ4mUZ41cYKBzr9okTDL0B0CW/Ssql1QwYidYR2ZvEuB7JO+RccTal6/aHg==", null, false, "6f84a77b-4798-411a-b095-e6f302664867", false, "user10" },
                    { "5e379750-3656-4d78-baa2-d4df9ae71339", 0, "3f5c3d86-215a-4b1e-9fa5-bad098a4a133", "user2@user.com", false, false, null, "USER2@USER.COM", "USER2", "AQAAAAIAAYagAAAAEP3W9CVhZ4mUZ41cYKBzr9okTDL0B0CW/Ssql1QwYidYR2ZvEuB7JO+RccTal6/aHg==", null, false, "7f538158-07b7-44fa-8666-816285073ca0", false, "user2" },
                    { "63ae5ef3-48ce-4242-a165-d4d07c4b35a1", 0, "47b5b6a0-fcf3-430b-b80d-bcbebf517632", "user1@user.com", false, false, null, "USER1@USER.COM", "USER1", "AQAAAAIAAYagAAAAEP3W9CVhZ4mUZ41cYKBzr9okTDL0B0CW/Ssql1QwYidYR2ZvEuB7JO+RccTal6/aHg==", null, false, "30147a99-4b2e-497c-93a0-f8f2e235649d", false, "user1" },
                    { "6d23f45e-1a7a-4e11-bac2-33737200b6b8", 0, "5eb7954c-5518-477d-aa4f-89b185607a9c", "user9@user.com", false, false, null, "USER9@USER.COM", "USER9", "AQAAAAIAAYagAAAAEP3W9CVhZ4mUZ41cYKBzr9okTDL0B0CW/Ssql1QwYidYR2ZvEuB7JO+RccTal6/aHg==", null, false, "f3540388-ae81-4a27-9462-959b02641544", false, "user9" },
                    { "6ee2bb93-ffd8-42fa-a568-e50dcb6ebfb7", 0, "5d561424-b33a-4738-9767-eabc534366f1", "user8@user.com", false, false, null, "USER8@USER.COM", "USER8", "AQAAAAIAAYagAAAAEP3W9CVhZ4mUZ41cYKBzr9okTDL0B0CW/Ssql1QwYidYR2ZvEuB7JO+RccTal6/aHg==", null, false, "91404d80-05e8-4e29-9e1d-3b68777a0630", false, "user8" },
                    { "80423ca6-3286-405a-9b6b-8ef33b0be9bd", 0, "f6aeb745-b1cc-4637-ab00-8f5f47bc87b9", "user3@user.com", false, false, null, "USER3@USER.COM", "USER3", "AQAAAAIAAYagAAAAEP3W9CVhZ4mUZ41cYKBzr9okTDL0B0CW/Ssql1QwYidYR2ZvEuB7JO+RccTal6/aHg==", null, false, "87846df6-c01f-4bfd-bb0a-230a20e22776", false, "user3" },
                    { "b220c49f-2e2a-4705-bda1-b1c3e2187346", 0, "0b49bc59-6083-46c0-b256-f4d41d6b7926", "user7@user.com", false, false, null, "USER7@USER.COM", "USER7", "AQAAAAIAAYagAAAAEP3W9CVhZ4mUZ41cYKBzr9okTDL0B0CW/Ssql1QwYidYR2ZvEuB7JO+RccTal6/aHg==", null, false, "e99ea155-884d-4cb7-b9a1-edecd9390f68", false, "user7" },
                    { "b58d8f45-5f44-4409-9ce0-a3e8ad16fff8", 0, "f649b7ae-cc65-4783-8945-788d8561c0d3", "user6@user.com", false, false, null, "USER6@USER.COM", "USER6", "AQAAAAIAAYagAAAAEP3W9CVhZ4mUZ41cYKBzr9okTDL0B0CW/Ssql1QwYidYR2ZvEuB7JO+RccTal6/aHg==", null, false, "2fe84c06-91e1-49d1-b99a-9478b464038c", false, "user6" },
                    { "c573f512-9d0a-4bd4-a9d9-bbce131457be", 0, "749d2d16-a029-4d0c-bdf8-4e9ee5bfaeca", "user4@user.com", false, false, null, "USER4@USER.COM", "USER4", "AQAAAAIAAYagAAAAEP3W9CVhZ4mUZ41cYKBzr9okTDL0B0CW/Ssql1QwYidYR2ZvEuB7JO+RccTal6/aHg==", null, false, "a4957b64-80e8-4116-8aea-71a8753fcec8", false, "user4" },
                    { "f294b89e-b45f-404e-9615-b880d3b72b1d", 0, "96cb17a6-ff28-4e3d-8f70-1f52f1d56d32", "user5@user.com", false, false, null, "USER5@USER.COM", "USER5", "AQAAAAIAAYagAAAAEP3W9CVhZ4mUZ41cYKBzr9okTDL0B0CW/Ssql1QwYidYR2ZvEuB7JO+RccTal6/aHg==", null, false, "640ccb8a-8e1f-4458-b5d4-245807bb115d", false, "user5" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "91dbc13b-74a8-4534-b5fc-c6d722d105a0", "19e88f67-b954-44f8-9642-3fd7b260328c" },
                    { "91dbc13b-74a8-4534-b5fc-c6d722d105a0", "5e379750-3656-4d78-baa2-d4df9ae71339" },
                    { "91dbc13b-74a8-4534-b5fc-c6d722d105a0", "63ae5ef3-48ce-4242-a165-d4d07c4b35a1" },
                    { "91dbc13b-74a8-4534-b5fc-c6d722d105a0", "6d23f45e-1a7a-4e11-bac2-33737200b6b8" },
                    { "91dbc13b-74a8-4534-b5fc-c6d722d105a0", "6ee2bb93-ffd8-42fa-a568-e50dcb6ebfb7" },
                    { "91dbc13b-74a8-4534-b5fc-c6d722d105a0", "80423ca6-3286-405a-9b6b-8ef33b0be9bd" },
                    { "91dbc13b-74a8-4534-b5fc-c6d722d105a0", "b220c49f-2e2a-4705-bda1-b1c3e2187346" },
                    { "91dbc13b-74a8-4534-b5fc-c6d722d105a0", "b58d8f45-5f44-4409-9ce0-a3e8ad16fff8" },
                    { "91dbc13b-74a8-4534-b5fc-c6d722d105a0", "c573f512-9d0a-4bd4-a9d9-bbce131457be" },
                    { "91dbc13b-74a8-4534-b5fc-c6d722d105a0", "f294b89e-b45f-404e-9615-b880d3b72b1d" }
                });
        }
    }
}
