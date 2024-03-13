using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Jaysbe.Migrations
{
    /// <inheritdoc />
    public partial class CategoryUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubCategories_Categories_CategoryId",
                table: "SubCategories");

            migrationBuilder.DropIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7271bd88-cd38-4078-bbf0-230cf4794de8", "32bc3886-f0c0-4339-97e5-5f4ee850e783" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7271bd88-cd38-4078-bbf0-230cf4794de8", "49605273-7e25-4632-a712-f4b9f867e5fa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7271bd88-cd38-4078-bbf0-230cf4794de8", "4d6efc47-c777-46f6-92d1-34e0c868bea4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7271bd88-cd38-4078-bbf0-230cf4794de8", "588c146a-766e-4b72-9092-4134383e8c6a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7271bd88-cd38-4078-bbf0-230cf4794de8", "672af8c7-e4e6-419e-b477-920db37636a8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7271bd88-cd38-4078-bbf0-230cf4794de8", "8316701a-0c32-4e9a-b91d-3be274c8f979" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7271bd88-cd38-4078-bbf0-230cf4794de8", "8791fc29-3898-436c-8577-1357a11bcc05" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7271bd88-cd38-4078-bbf0-230cf4794de8", "c4970663-53d8-4c02-8d33-7c93964be5df" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7271bd88-cd38-4078-bbf0-230cf4794de8", "da2519b2-d723-4ced-a6b4-6923aff54bfd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7271bd88-cd38-4078-bbf0-230cf4794de8", "e2823794-a97c-41c7-91c4-362e67c7d52a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7271bd88-cd38-4078-bbf0-230cf4794de8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32bc3886-f0c0-4339-97e5-5f4ee850e783");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49605273-7e25-4632-a712-f4b9f867e5fa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d6efc47-c777-46f6-92d1-34e0c868bea4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "588c146a-766e-4b72-9092-4134383e8c6a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "672af8c7-e4e6-419e-b477-920db37636a8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8316701a-0c32-4e9a-b91d-3be274c8f979");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8791fc29-3898-436c-8577-1357a11bcc05");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c4970663-53d8-4c02-8d33-7c93964be5df");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da2519b2-d723-4ced-a6b4-6923aff54bfd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2823794-a97c-41c7-91c4-362e67c7d52a");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "SubCategories");

            migrationBuilder.AddColumn<Guid>(
                name: "ParentId",
                table: "Categories",
                type: "uniqueidentifier",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentId",
                table: "Categories",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Categories_ParentId",
                table: "Categories",
                column: "ParentId",
                principalTable: "Categories",
                principalColumn: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Categories_ParentId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ParentId",
                table: "Categories");

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

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Categories");

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "SubCategories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7271bd88-cd38-4078-bbf0-230cf4794de8", null, "TestUser", "TESTUSER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "32bc3886-f0c0-4339-97e5-5f4ee850e783", 0, "22c11d59-68cd-4ab5-945a-d2f3a93c9f1b", "user10@user.com", false, false, null, "USER10@USER.COM", "USER10", "AQAAAAIAAYagAAAAEFWJrcuU6akEBhZ0XtKxE9cUBNyMUc83O3FreTNnzzX3hxlAc3TI+9p+wazMR2N1sg==", null, false, "02a0d734-1b00-4bc0-ab3c-5661d7af407d", false, "user10" },
                    { "49605273-7e25-4632-a712-f4b9f867e5fa", 0, "04f0a9b3-e5a8-4a04-9e54-5431ae08a267", "user4@user.com", false, false, null, "USER4@USER.COM", "USER4", "AQAAAAIAAYagAAAAEFWJrcuU6akEBhZ0XtKxE9cUBNyMUc83O3FreTNnzzX3hxlAc3TI+9p+wazMR2N1sg==", null, false, "32a6d174-5766-461d-afbf-228ea4917bd0", false, "user4" },
                    { "4d6efc47-c777-46f6-92d1-34e0c868bea4", 0, "03e4ec8a-beea-41dc-addb-1335c61e36f9", "user9@user.com", false, false, null, "USER9@USER.COM", "USER9", "AQAAAAIAAYagAAAAEFWJrcuU6akEBhZ0XtKxE9cUBNyMUc83O3FreTNnzzX3hxlAc3TI+9p+wazMR2N1sg==", null, false, "f26e8e1f-8490-4edf-83c6-32017e98f59a", false, "user9" },
                    { "588c146a-766e-4b72-9092-4134383e8c6a", 0, "2faa1707-0062-4c8b-8c74-dc3b3e23e45b", "user3@user.com", false, false, null, "USER3@USER.COM", "USER3", "AQAAAAIAAYagAAAAEFWJrcuU6akEBhZ0XtKxE9cUBNyMUc83O3FreTNnzzX3hxlAc3TI+9p+wazMR2N1sg==", null, false, "46664c11-810b-46e8-96ea-d20e3344d254", false, "user3" },
                    { "672af8c7-e4e6-419e-b477-920db37636a8", 0, "97adc489-2019-442e-8122-f1ade2688a50", "user6@user.com", false, false, null, "USER6@USER.COM", "USER6", "AQAAAAIAAYagAAAAEFWJrcuU6akEBhZ0XtKxE9cUBNyMUc83O3FreTNnzzX3hxlAc3TI+9p+wazMR2N1sg==", null, false, "8b1594fd-acee-4433-b320-a53e92bf64ef", false, "user6" },
                    { "8316701a-0c32-4e9a-b91d-3be274c8f979", 0, "f1e7fc5c-4346-4936-a339-0107d49a6720", "user8@user.com", false, false, null, "USER8@USER.COM", "USER8", "AQAAAAIAAYagAAAAEFWJrcuU6akEBhZ0XtKxE9cUBNyMUc83O3FreTNnzzX3hxlAc3TI+9p+wazMR2N1sg==", null, false, "cad98386-f20c-4a6f-a9f1-22ec40acb1fa", false, "user8" },
                    { "8791fc29-3898-436c-8577-1357a11bcc05", 0, "a659e9f3-ca43-47ad-a193-589b4f41b08c", "user7@user.com", false, false, null, "USER7@USER.COM", "USER7", "AQAAAAIAAYagAAAAEFWJrcuU6akEBhZ0XtKxE9cUBNyMUc83O3FreTNnzzX3hxlAc3TI+9p+wazMR2N1sg==", null, false, "435b34ca-6273-4a8c-9d78-16cb35816634", false, "user7" },
                    { "c4970663-53d8-4c02-8d33-7c93964be5df", 0, "46d2be1c-bbb9-461d-a3db-57f3197abab2", "user2@user.com", false, false, null, "USER2@USER.COM", "USER2", "AQAAAAIAAYagAAAAEFWJrcuU6akEBhZ0XtKxE9cUBNyMUc83O3FreTNnzzX3hxlAc3TI+9p+wazMR2N1sg==", null, false, "6bfe749c-9b19-4009-a7d4-98a2af5a418e", false, "user2" },
                    { "da2519b2-d723-4ced-a6b4-6923aff54bfd", 0, "b7189844-b20b-45e7-a4ca-9938d5ba6ae8", "user5@user.com", false, false, null, "USER5@USER.COM", "USER5", "AQAAAAIAAYagAAAAEFWJrcuU6akEBhZ0XtKxE9cUBNyMUc83O3FreTNnzzX3hxlAc3TI+9p+wazMR2N1sg==", null, false, "dfda6315-3625-4fa8-ae48-15af09c1ae7d", false, "user5" },
                    { "e2823794-a97c-41c7-91c4-362e67c7d52a", 0, "5f9918c0-a4df-4a33-996a-908fd7b22e53", "user1@user.com", false, false, null, "USER1@USER.COM", "USER1", "AQAAAAIAAYagAAAAEFWJrcuU6akEBhZ0XtKxE9cUBNyMUc83O3FreTNnzzX3hxlAc3TI+9p+wazMR2N1sg==", null, false, "ae34d25d-7010-4d08-a6cf-5fcbff246866", false, "user1" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "7271bd88-cd38-4078-bbf0-230cf4794de8", "32bc3886-f0c0-4339-97e5-5f4ee850e783" },
                    { "7271bd88-cd38-4078-bbf0-230cf4794de8", "49605273-7e25-4632-a712-f4b9f867e5fa" },
                    { "7271bd88-cd38-4078-bbf0-230cf4794de8", "4d6efc47-c777-46f6-92d1-34e0c868bea4" },
                    { "7271bd88-cd38-4078-bbf0-230cf4794de8", "588c146a-766e-4b72-9092-4134383e8c6a" },
                    { "7271bd88-cd38-4078-bbf0-230cf4794de8", "672af8c7-e4e6-419e-b477-920db37636a8" },
                    { "7271bd88-cd38-4078-bbf0-230cf4794de8", "8316701a-0c32-4e9a-b91d-3be274c8f979" },
                    { "7271bd88-cd38-4078-bbf0-230cf4794de8", "8791fc29-3898-436c-8577-1357a11bcc05" },
                    { "7271bd88-cd38-4078-bbf0-230cf4794de8", "c4970663-53d8-4c02-8d33-7c93964be5df" },
                    { "7271bd88-cd38-4078-bbf0-230cf4794de8", "da2519b2-d723-4ced-a6b4-6923aff54bfd" },
                    { "7271bd88-cd38-4078-bbf0-230cf4794de8", "e2823794-a97c-41c7-91c4-362e67c7d52a" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategories_Categories_CategoryId",
                table: "SubCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId");
        }
    }
}
