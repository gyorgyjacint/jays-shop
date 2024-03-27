using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Jaysbe.Migrations
{
    /// <inheritdoc />
    public partial class CategoryRemoveToAddLabel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

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

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "Labels",
                columns: table => new
                {
                    LabelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Labels", x => x.LabelId);
                    table.ForeignKey(
                        name: "FK_Labels_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b65f3bb3-498f-4d85-9936-6729f233d0e2", null, "TestUser", "TESTUSER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "13ecfd33-66a5-43a2-ab49-f7d00494c57e", 0, "3fbb6fe9-6374-457b-948e-a36770a6f0a8", "user9@user.com", false, false, null, "USER9@USER.COM", "USER9", "AQAAAAIAAYagAAAAEICxXlfgCyk9wzE9FWLUekVJi3y9yud1z9Fsj2REyVKTsquXwsJhPijS7DUNJ5WnCA==", null, false, "ce5272bc-1fda-4afa-92c8-41448a4e3e37", false, "user9" },
                    { "32b569bd-eb28-4370-9058-0d5678cdce8b", 0, "dc21e3e1-2fac-4ed5-a5e4-66e2dce7e283", "user10@user.com", false, false, null, "USER10@USER.COM", "USER10", "AQAAAAIAAYagAAAAEICxXlfgCyk9wzE9FWLUekVJi3y9yud1z9Fsj2REyVKTsquXwsJhPijS7DUNJ5WnCA==", null, false, "5270c278-3585-4095-9643-e46c8d0c3824", false, "user10" },
                    { "57d28415-4a6b-4f2e-b280-a949dcdc5e74", 0, "ff671e3e-c41d-4f80-a150-339f3e05d117", "user8@user.com", false, false, null, "USER8@USER.COM", "USER8", "AQAAAAIAAYagAAAAEICxXlfgCyk9wzE9FWLUekVJi3y9yud1z9Fsj2REyVKTsquXwsJhPijS7DUNJ5WnCA==", null, false, "353fe948-baef-4181-b38d-088860bb05ba", false, "user8" },
                    { "5f593909-83f7-491a-9e36-f7793eb7c764", 0, "b91b9343-654f-4c3c-8d59-e124397711a7", "user1@user.com", false, false, null, "USER1@USER.COM", "USER1", "AQAAAAIAAYagAAAAEICxXlfgCyk9wzE9FWLUekVJi3y9yud1z9Fsj2REyVKTsquXwsJhPijS7DUNJ5WnCA==", null, false, "375c4315-37ed-4011-845e-26eb8fbe03ea", false, "user1" },
                    { "891f799b-d021-485e-b4d5-b9c9a6d488eb", 0, "ff58e0f2-4030-4426-b78e-c6346a4fe93b", "user7@user.com", false, false, null, "USER7@USER.COM", "USER7", "AQAAAAIAAYagAAAAEICxXlfgCyk9wzE9FWLUekVJi3y9yud1z9Fsj2REyVKTsquXwsJhPijS7DUNJ5WnCA==", null, false, "3153f6bf-bb35-44f5-8c11-d646bcb70523", false, "user7" },
                    { "bf4d56fe-a070-4b2b-bb60-062dd648cf14", 0, "da07f549-47a2-4727-bace-273ca30ce5ed", "user4@user.com", false, false, null, "USER4@USER.COM", "USER4", "AQAAAAIAAYagAAAAEICxXlfgCyk9wzE9FWLUekVJi3y9yud1z9Fsj2REyVKTsquXwsJhPijS7DUNJ5WnCA==", null, false, "7cf1003f-7836-4d9a-9212-956771b310c4", false, "user4" },
                    { "d0f4ab00-8fb4-4a96-91ce-1fbd5bef623e", 0, "c71eb8a4-3dc1-4a01-b090-9320a7330e2c", "user6@user.com", false, false, null, "USER6@USER.COM", "USER6", "AQAAAAIAAYagAAAAEICxXlfgCyk9wzE9FWLUekVJi3y9yud1z9Fsj2REyVKTsquXwsJhPijS7DUNJ5WnCA==", null, false, "d3dced03-b950-47ac-a33b-3b3517e09f88", false, "user6" },
                    { "d934e2bf-0ade-43ca-8341-002d0c439525", 0, "7a5d7bbb-a1ca-4201-87e2-e080f2d499a5", "user5@user.com", false, false, null, "USER5@USER.COM", "USER5", "AQAAAAIAAYagAAAAEICxXlfgCyk9wzE9FWLUekVJi3y9yud1z9Fsj2REyVKTsquXwsJhPijS7DUNJ5WnCA==", null, false, "76f708e2-3bb0-4a83-afc8-1db9eba77bad", false, "user5" },
                    { "f6153610-7328-457b-bc1f-f885a8b85be7", 0, "21d2c6c4-c6bd-4b8c-a7d0-5702053ef1da", "user3@user.com", false, false, null, "USER3@USER.COM", "USER3", "AQAAAAIAAYagAAAAEICxXlfgCyk9wzE9FWLUekVJi3y9yud1z9Fsj2REyVKTsquXwsJhPijS7DUNJ5WnCA==", null, false, "038799fc-1135-4669-ad9e-309687991928", false, "user3" },
                    { "fb81ce1b-e5fa-4011-b938-de21e7770f56", 0, "e51915de-cc8a-4a5e-93ea-afacb4b8a0e2", "user2@user.com", false, false, null, "USER2@USER.COM", "USER2", "AQAAAAIAAYagAAAAEICxXlfgCyk9wzE9FWLUekVJi3y9yud1z9Fsj2REyVKTsquXwsJhPijS7DUNJ5WnCA==", null, false, "056a9c04-aa3a-4b72-8913-6a9473464992", false, "user2" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b65f3bb3-498f-4d85-9936-6729f233d0e2", "13ecfd33-66a5-43a2-ab49-f7d00494c57e" },
                    { "b65f3bb3-498f-4d85-9936-6729f233d0e2", "32b569bd-eb28-4370-9058-0d5678cdce8b" },
                    { "b65f3bb3-498f-4d85-9936-6729f233d0e2", "57d28415-4a6b-4f2e-b280-a949dcdc5e74" },
                    { "b65f3bb3-498f-4d85-9936-6729f233d0e2", "5f593909-83f7-491a-9e36-f7793eb7c764" },
                    { "b65f3bb3-498f-4d85-9936-6729f233d0e2", "891f799b-d021-485e-b4d5-b9c9a6d488eb" },
                    { "b65f3bb3-498f-4d85-9936-6729f233d0e2", "bf4d56fe-a070-4b2b-bb60-062dd648cf14" },
                    { "b65f3bb3-498f-4d85-9936-6729f233d0e2", "d0f4ab00-8fb4-4a96-91ce-1fbd5bef623e" },
                    { "b65f3bb3-498f-4d85-9936-6729f233d0e2", "d934e2bf-0ade-43ca-8341-002d0c439525" },
                    { "b65f3bb3-498f-4d85-9936-6729f233d0e2", "f6153610-7328-457b-bc1f-f885a8b85be7" },
                    { "b65f3bb3-498f-4d85-9936-6729f233d0e2", "fb81ce1b-e5fa-4011-b938-de21e7770f56" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Labels_Name",
                table: "Labels",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Labels_ProductId",
                table: "Labels",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Labels");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b65f3bb3-498f-4d85-9936-6729f233d0e2", "13ecfd33-66a5-43a2-ab49-f7d00494c57e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b65f3bb3-498f-4d85-9936-6729f233d0e2", "32b569bd-eb28-4370-9058-0d5678cdce8b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b65f3bb3-498f-4d85-9936-6729f233d0e2", "57d28415-4a6b-4f2e-b280-a949dcdc5e74" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b65f3bb3-498f-4d85-9936-6729f233d0e2", "5f593909-83f7-491a-9e36-f7793eb7c764" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b65f3bb3-498f-4d85-9936-6729f233d0e2", "891f799b-d021-485e-b4d5-b9c9a6d488eb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b65f3bb3-498f-4d85-9936-6729f233d0e2", "bf4d56fe-a070-4b2b-bb60-062dd648cf14" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b65f3bb3-498f-4d85-9936-6729f233d0e2", "d0f4ab00-8fb4-4a96-91ce-1fbd5bef623e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b65f3bb3-498f-4d85-9936-6729f233d0e2", "d934e2bf-0ade-43ca-8341-002d0c439525" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b65f3bb3-498f-4d85-9936-6729f233d0e2", "f6153610-7328-457b-bc1f-f885a8b85be7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b65f3bb3-498f-4d85-9936-6729f233d0e2", "fb81ce1b-e5fa-4011-b938-de21e7770f56" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b65f3bb3-498f-4d85-9936-6729f233d0e2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13ecfd33-66a5-43a2-ab49-f7d00494c57e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32b569bd-eb28-4370-9058-0d5678cdce8b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57d28415-4a6b-4f2e-b280-a949dcdc5e74");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5f593909-83f7-491a-9e36-f7793eb7c764");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "891f799b-d021-485e-b4d5-b9c9a6d488eb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf4d56fe-a070-4b2b-bb60-062dd648cf14");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0f4ab00-8fb4-4a96-91ce-1fbd5bef623e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d934e2bf-0ade-43ca-8341-002d0c439525");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6153610-7328-457b-bc1f-f885a8b85be7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fb81ce1b-e5fa-4011-b938-de21e7770f56");

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Name",
                table: "Categories",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentId",
                table: "Categories",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId");
        }
    }
}
