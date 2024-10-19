using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BinhDinhFood.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class removeStatusUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 16 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 18 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 22 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("22185f7c-743a-4fb1-bbd7-3775e69a8baa") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("824ff7da-ffb5-4224-aba6-b2b6826c00c4") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a3314be5-4c77-4fb6-82ad-302014682a73"), new Guid("84c2840e-7489-471d-b8f6-c610c0e5c97f") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("e73a7108-7012-47f9-99a7-0276eccb5621") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("f83f2d71-07df-4da6-a082-e13b1bb25a0a") });

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("22185f7c-743a-4fb1-bbd7-3775e69a8baa"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("824ff7da-ffb5-4224-aba6-b2b6826c00c4"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("84c2840e-7489-471d-b8f6-c610c0e5c97f"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("e73a7108-7012-47f9-99a7-0276eccb5621"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("f83f2d71-07df-4da6-a082-e13b1bb25a0a"));

            migrationBuilder.DropColumn(
                name: "Status",
                table: "ApplicationUser");

            migrationBuilder.InsertData(
                table: "ApplicationUser",
                columns: new[] { "Id", "AccessFailedCount", "Address", "AvatarId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("031e8695-e2d1-4730-a9bf-febde2f02cad"), 0, "Tây Ninh", 2, "76ec2799-96ca-4b3a-aeb1-dfb1fc4886ff", "hongthai@example.com", false, false, null, "Nguyễn Hồng Thái", null, null, "AQAAAAIAAYagAAAAEH02LXsa4MDcluji15shTV0dRL8Te3Mf1xE2Jfx9IOeZwxWlppismfahBfUDmTkXNA==", "0905726748", false, "7af1a18c-ffba-4b61-a130-263bb0cdbb37", false, "thai" },
                    { new Guid("05c34245-43a0-4c99-a406-51c5340b696f"), 0, "Quy Nhơn, Bình Định", 1, "38c1f9e9-2537-4786-87c5-04d964697111", "truongnhon@example.com", false, false, null, "Võ Thương Trường Nhơn", null, null, "AQAAAAIAAYagAAAAEMQ5QkeCwpWQeEEwWugB69uzFvAxYG+SknLlkK7n2jYVoKkYQUWyEkZoJRD2CnFkQQ==", "0905726748", false, "42286af1-2d96-4a8d-a7b5-0ae66a7960bd", false, "truongnhon" },
                    { new Guid("4fef3895-9d0b-4c2f-a9ca-e17f4d3fddb1"), 0, "Nam Định", 3, "ce43e066-35ff-444b-9f7c-aa32351669f7", "taiphamduc@example.com", false, false, null, "Phạm Đức Tài", null, null, "AQAAAAIAAYagAAAAEJxlnGzVQgIcelpC/YFsjvvLYPqeOZkZcjhvY3uUZXe1ETo1YE2Di/1/HrMLemUkWQ==", "0905726748", false, "938d0212-a2dd-4f62-9b9a-dbfc75158c02", false, "tai" },
                    { new Guid("9252e5d5-328f-470a-9862-5d220595a574"), 0, "Admin City", null, "ee154120-cc6d-43ec-9eec-18470215fff7", "admin@example.com", false, false, null, "Admin User", null, null, "AQAAAAIAAYagAAAAEHHbB8NPYcbRFAngFGG2d0Er+bxcFnfzA7CkzjXy5YMQhkuwjK0wv4T9ZAt1kyZgsw==", "123456789", false, "99aa37e9-e2c7-420c-8f84-221ace747a6f", false, "admin" },
                    { new Guid("dda27303-c0a1-4991-856b-5810686f7973"), 0, "Saigon", null, "aa007ac4-cddf-4daf-84f1-de4a698fafc2", "nhondeptrai@example.com", false, false, null, "dotnet evil", null, null, "AQAAAAIAAYagAAAAEFtSW/xy3+OX0fiPbaphN8LjB3a8425/JEMqR31DAJl62UGyCKVbwKRjgubhDlBTUw==", "0905726748", false, "80f9ff7e-5e89-49f7-b887-ead5e75c4e31", false, "nhondeptrai" }
                });

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 10, 20, 2, 15, 26, 67, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 10, 20, 2, 15, 26, 67, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 10, 20, 2, 15, 26, 67, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 10, 20, 2, 15, 26, 267, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 10, 20, 2, 15, 26, 267, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 10, 20, 2, 15, 26, 267, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 10, 20, 2, 15, 26, 267, DateTimeKind.Local).AddTicks(6915));

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 3, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 1, 6 },
                    { 1, 7 },
                    { 3, 7 },
                    { 2, 8 },
                    { 3, 8 },
                    { 3, 9 },
                    { 1, 13 },
                    { 2, 15 },
                    { 2, 17 },
                    { 2, 18 },
                    { 3, 20 },
                    { 1, 22 },
                    { 3, 23 },
                    { 2, 24 },
                    { 3, 24 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("031e8695-e2d1-4730-a9bf-febde2f02cad") },
                    { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("05c34245-43a0-4c99-a406-51c5340b696f") },
                    { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("4fef3895-9d0b-4c2f-a9ca-e17f4d3fddb1") },
                    { new Guid("a3314be5-4c77-4fb6-82ad-302014682a73"), new Guid("9252e5d5-328f-470a-9862-5d220595a574") },
                    { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("dda27303-c0a1-4991-856b-5810686f7973") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 15 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 17 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 18 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 20 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 22 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 23 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 24 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 24 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("031e8695-e2d1-4730-a9bf-febde2f02cad") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("05c34245-43a0-4c99-a406-51c5340b696f") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("4fef3895-9d0b-4c2f-a9ca-e17f4d3fddb1") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a3314be5-4c77-4fb6-82ad-302014682a73"), new Guid("9252e5d5-328f-470a-9862-5d220595a574") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("dda27303-c0a1-4991-856b-5810686f7973") });

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("031e8695-e2d1-4730-a9bf-febde2f02cad"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("05c34245-43a0-4c99-a406-51c5340b696f"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("4fef3895-9d0b-4c2f-a9ca-e17f4d3fddb1"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("9252e5d5-328f-470a-9862-5d220595a574"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("dda27303-c0a1-4991-856b-5810686f7973"));

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "ApplicationUser",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.InsertData(
                table: "ApplicationUser",
                columns: new[] { "Id", "AccessFailedCount", "Address", "AvatarId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("22185f7c-743a-4fb1-bbd7-3775e69a8baa"), 0, "Nam Định", 3, "fe892764-5a06-4bb6-8a74-d318b8b4ffb5", "taiphamduc@example.com", false, false, null, "Phạm Đức Tài", null, null, "AQAAAAIAAYagAAAAENJRCrzzBfP5DGe+nYZ6bUYrWS0JWyBlsbIpQhRwFczJQHpAdKqwEAQKOi/CASwSwQ==", "0905726748", false, "bcb7e7d1-dcfe-4cb0-9ebc-a3f535936f78", false, "tai" },
                    { new Guid("824ff7da-ffb5-4224-aba6-b2b6826c00c4"), 0, "Quy Nhơn, Bình Định", 1, "9d15c66d-8452-4c02-b284-0b74d8d92526", "truongnhon@example.com", false, false, null, "Võ Thương Trường Nhơn", null, null, "AQAAAAIAAYagAAAAEBoVu0CHZ2f9akbacI3qs4TZk6W8WbV8b/rmlLwsnKVG8wTzJ4PvysSYXZvLLknlDw==", "0905726748", false, "a8ec11b0-0618-4769-9e6f-7d2e3711535a", false, "truongnhon" },
                    { new Guid("84c2840e-7489-471d-b8f6-c610c0e5c97f"), 0, "Admin City", null, "9540d3fb-a706-444b-9eed-f8e47219ad91", "admin@example.com", false, false, null, "Admin User", null, null, "AQAAAAIAAYagAAAAEOVAU2VijOxIhq+anTHAXHECq3jskPY50BycVRyGITw4/f3mN3NWq5XkhOrSpEediQ==", "123456789", false, "65cce18e-285f-44ea-84c1-4efe432b1c36", false, "admin" },
                    { new Guid("e73a7108-7012-47f9-99a7-0276eccb5621"), 0, "Saigon", null, "0467173f-79f4-498b-b446-74fc950d3c47", "nhondeptrai@example.com", false, false, null, "dotnet evil", null, null, "AQAAAAIAAYagAAAAEJvn5Bx8HYObJ6QbdO7D8J1NPGZVdI4twnTLCoqtmiStE7j6weJepMEiHvv+STqlYQ==", "0905726748", false, "07716d19-4232-4cfb-8697-7bfada8b3b0d", false, "nhondeptrai" },
                    { new Guid("f83f2d71-07df-4da6-a082-e13b1bb25a0a"), 0, "Tây Ninh", 2, "054dbf22-a6d4-4505-a352-04cde138cbf4", "hongthai@example.com", false, false, null, "Nguyễn Hồng Thái", null, null, "AQAAAAIAAYagAAAAEPsR+6ZRwNOhH9z6CgSjROfsXCo6/VcshY5eICTRNqjzhDnPXfo/eSPU+NulgnSsTA==", "0905726748", false, "bb8f021e-7188-486f-9790-7d780db7affc", false, "thai" }
                });

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 10, 16, 22, 45, 27, 673, DateTimeKind.Local).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 10, 16, 22, 45, 27, 673, DateTimeKind.Local).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 10, 16, 22, 45, 27, 673, DateTimeKind.Local).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 10, 16, 22, 45, 27, 953, DateTimeKind.Local).AddTicks(130));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 10, 16, 22, 45, 27, 953, DateTimeKind.Local).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 10, 16, 22, 45, 27, 953, DateTimeKind.Local).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 10, 16, 22, 45, 27, 953, DateTimeKind.Local).AddTicks(136));

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 4 },
                    { 2, 5 },
                    { 3, 5 },
                    { 3, 13 },
                    { 1, 14 },
                    { 1, 15 },
                    { 3, 15 },
                    { 1, 16 },
                    { 2, 16 },
                    { 1, 17 },
                    { 1, 18 },
                    { 3, 18 },
                    { 2, 22 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("22185f7c-743a-4fb1-bbd7-3775e69a8baa") },
                    { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("824ff7da-ffb5-4224-aba6-b2b6826c00c4") },
                    { new Guid("a3314be5-4c77-4fb6-82ad-302014682a73"), new Guid("84c2840e-7489-471d-b8f6-c610c0e5c97f") },
                    { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("e73a7108-7012-47f9-99a7-0276eccb5621") },
                    { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("f83f2d71-07df-4da6-a082-e13b1bb25a0a") }
                });
        }
    }
}
