using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Jaysbe.Migrations
{
    /// <inheritdoc />
    public partial class CategoryNameConstraint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "IX_Categories_Name",
                table: "Categories",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Categories_Name",
                table: "Categories");

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
    }
}
