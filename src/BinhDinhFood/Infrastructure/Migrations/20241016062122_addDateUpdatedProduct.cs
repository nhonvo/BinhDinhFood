using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BinhDinhFood.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addDateUpdatedProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 18 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 21 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 23 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 25 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 25 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("72854465-d450-4ee1-ac1b-e1e8a2877d6f") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a3314be5-4c77-4fb6-82ad-302014682a73"), new Guid("865bcd33-d26c-47b6-9d6e-c97682151b6a") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("b1126a13-c169-496d-ad87-ae58d166a037") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("b9135d46-5d92-4290-93ae-818117b33f99") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("e888b698-6bb8-4d1f-a266-e9a1566a6933") });

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("72854465-d450-4ee1-ac1b-e1e8a2877d6f"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("865bcd33-d26c-47b6-9d6e-c97682151b6a"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("b1126a13-c169-496d-ad87-ae58d166a037"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("b9135d46-5d92-4290-93ae-818117b33f99"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("e888b698-6bb8-4d1f-a266-e9a1566a6933"));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "ApplicationUser",
                columns: new[] { "Id", "AccessFailedCount", "Address", "AvatarId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("474883ea-5f56-49c8-accd-9297d4451eed"), 0, "Saigon", null, "ead10764-d0aa-404c-9a8c-ae12282f898c", "nhondeptrai@example.com", false, false, null, "dotnet evil", null, null, "AQAAAAIAAYagAAAAEAKEUVE0gRU8DjT3HIzkfPbSiM9sr60Wx9Kli3JA8tkTkQ53flsf0IDRrxMDF6AKFw==", "0905726748", false, "fd1b2201-8110-4bb4-a480-6172c3f1722f", false, "nhondeptrai" },
                    { new Guid("60edc3cc-2f7c-44c7-84d0-cd39922c53f1"), 0, "Admin City", null, "2c197ce7-3a05-46f6-a26a-420d17522f6a", "admin@example.com", false, false, null, "Admin User", null, null, "AQAAAAIAAYagAAAAEN03OBMpNzokSXmeZ0GTinma1Lddqkna8JKH9QyXWZxEQy2Im+HXWNaWk3OT9zV2Kg==", "123456789", false, "9122481c-ecd1-43c6-9617-dd8dfd4d7dc7", false, "admin" },
                    { new Guid("adec3ce5-ae04-4786-8301-f48fbe7c89e9"), 0, "Tây Ninh", 2, "ce6709bb-2b0a-4e16-bd8f-0f46963f1b69", "hongthai@example.com", false, false, null, "Nguyễn Hồng Thái", null, null, "AQAAAAIAAYagAAAAEJG3KN9Zet6AmacMbfxAVl51uNpPlh0P/R9dO9kjW4+URkG3r/iODdqHCjTm/1sONg==", "0905726748", false, "5eb0ea2c-8fd6-4f39-8388-5fe525d185bd", false, "thai" },
                    { new Guid("c43f5add-dda5-4037-90a2-e9f5d6bddb6a"), 0, "Quy Nhơn, Bình Định", 1, "77b02136-cf4f-4f92-a53c-6c89bbeadefb", "truongnhon@example.com", false, false, null, "Võ Thương Trường Nhơn", null, null, "AQAAAAIAAYagAAAAEPWeb+FIO1S4IyuRipNrh8noNQ+ZYBAZeYorpxu5odgtoJqstG0TvkBBb02JetC0DQ==", "0905726748", false, "89d2c6b6-31ea-4c55-9c33-b471a7667b7c", false, "truongnhon" },
                    { new Guid("cddb5d93-f08d-4814-924e-93da85e40a48"), 0, "Nam Định", 3, "18ca2eb1-fdf6-43b0-bd2a-3c962a3eec49", "taiphamduc@example.com", false, false, null, "Phạm Đức Tài", null, null, "AQAAAAIAAYagAAAAEAPSkVwCKsuiEcfZre1iNp+Ry4QywGLkpJQUiZcJO5g4rPaOe0fkCvX91Zsb7MkKZw==", "0905726748", false, "d39c0520-15d1-46ea-8ba5-8a8a4cdceeb7", false, "tai" }
                });

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 10, 16, 13, 21, 20, 921, DateTimeKind.Local).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 10, 16, 13, 21, 20, 921, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 10, 16, 13, 21, 20, 921, DateTimeKind.Local).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 10, 16, 13, 21, 21, 115, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 10, 16, 13, 21, 21, 115, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 10, 16, 13, 21, 21, 115, DateTimeKind.Local).AddTicks(4531));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 10, 16, 13, 21, 21, 115, DateTimeKind.Local).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateUpdated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateUpdated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateUpdated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateUpdated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateUpdated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateUpdated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateUpdated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateUpdated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateUpdated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateUpdated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateUpdated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateUpdated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateUpdated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateUpdated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateUpdated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateUpdated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateUpdated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateUpdated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateUpdated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateUpdated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateUpdated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateUpdated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateUpdated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 3, 1 },
                    { 1, 2 },
                    { 3, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 3, 4 },
                    { 1, 5 },
                    { 2, 5 },
                    { 2, 7 },
                    { 3, 13 },
                    { 1, 16 },
                    { 2, 16 },
                    { 1, 17 },
                    { 3, 18 },
                    { 1, 21 },
                    { 3, 22 },
                    { 2, 23 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("474883ea-5f56-49c8-accd-9297d4451eed") },
                    { new Guid("a3314be5-4c77-4fb6-82ad-302014682a73"), new Guid("60edc3cc-2f7c-44c7-84d0-cd39922c53f1") },
                    { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("adec3ce5-ae04-4786-8301-f48fbe7c89e9") },
                    { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("c43f5add-dda5-4037-90a2-e9f5d6bddb6a") },
                    { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("cddb5d93-f08d-4814-924e-93da85e40a48") }
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
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 13 });

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
                keyValues: new object[] { 3, 18 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 21 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 22 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 23 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("474883ea-5f56-49c8-accd-9297d4451eed") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a3314be5-4c77-4fb6-82ad-302014682a73"), new Guid("60edc3cc-2f7c-44c7-84d0-cd39922c53f1") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("adec3ce5-ae04-4786-8301-f48fbe7c89e9") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("c43f5add-dda5-4037-90a2-e9f5d6bddb6a") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("cddb5d93-f08d-4814-924e-93da85e40a48") });

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("474883ea-5f56-49c8-accd-9297d4451eed"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("60edc3cc-2f7c-44c7-84d0-cd39922c53f1"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("adec3ce5-ae04-4786-8301-f48fbe7c89e9"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("c43f5add-dda5-4037-90a2-e9f5d6bddb6a"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("cddb5d93-f08d-4814-924e-93da85e40a48"));

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Product");

            migrationBuilder.InsertData(
                table: "ApplicationUser",
                columns: new[] { "Id", "AccessFailedCount", "Address", "AvatarId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("72854465-d450-4ee1-ac1b-e1e8a2877d6f"), 0, "Tây Ninh", 2, "20276c1e-b95e-4fb5-a5d9-c0a548f314c2", "hongthai@example.com", false, false, null, "Nguyễn Hồng Thái", null, null, "AQAAAAIAAYagAAAAEEf6GdJssf9uUumtdu3dPLXZ/+2noOkJwlbV6uh1W8DbA/RCuDXrfsPdYcBAJsG7cA==", "0905726748", false, "99048ee2-3a17-4083-a7ac-917806154a18", false, "thai" },
                    { new Guid("865bcd33-d26c-47b6-9d6e-c97682151b6a"), 0, "Admin City", null, "3a5d4fda-f287-40bf-a194-81b577a81310", "admin@example.com", false, false, null, "Admin User", null, null, "AQAAAAIAAYagAAAAEHG6Zbb500mTvBR7/93VulyW3ln5oMqNNkdUc0+79wauznVXqxM/TZBmwk2mamPhPg==", "123456789", false, "0b416cc8-e6d6-49fd-b596-9f0141885070", false, "admin" },
                    { new Guid("b1126a13-c169-496d-ad87-ae58d166a037"), 0, "Nam Định", 3, "cffad2ee-181e-4565-836f-658935a592cb", "taiphamduc@example.com", false, false, null, "Phạm Đức Tài", null, null, "AQAAAAIAAYagAAAAEMfoGvxVviJPk67+Z8MFh/nnIKEp5EKtCVJVN7s/dTbJjKwVYSswVlg71bFZh0taUg==", "0905726748", false, "b438dfef-13d5-4633-bb7d-f804cab854a7", false, "tai" },
                    { new Guid("b9135d46-5d92-4290-93ae-818117b33f99"), 0, "Saigon", null, "65f8e858-d67e-4771-8e2c-3e640d0ee4e8", "nhondeptrai@example.com", false, false, null, "dotnet evil", null, null, "AQAAAAIAAYagAAAAEDQBa6Y/3JgXj/6w3QdDRkx1diGhzy8wN2B897ULfxrjkAmpBG8IWhgSPzqrJiXP9w==", "0905726748", false, "713b9071-e50a-4bfa-a42b-bec01e3f62a2", false, "nhondeptrai" },
                    { new Guid("e888b698-6bb8-4d1f-a266-e9a1566a6933"), 0, "Quy Nhơn, Bình Định", 1, "1f7c2816-c856-4f60-a32d-541106f8fa83", "truongnhon@example.com", false, false, null, "Võ Thương Trường Nhơn", null, null, "AQAAAAIAAYagAAAAEA4YqvEIyBFc9sjGeB38p+QjvVuKlNwHPYT99JWYRK6/BlCk1IKA6+wCDxAKPVOTkg==", "0905726748", false, "8316be19-9c6f-43ac-bb4b-2e1a7145cb7f", false, "truongnhon" }
                });

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 10, 15, 15, 51, 49, 845, DateTimeKind.Local).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 10, 15, 15, 51, 49, 845, DateTimeKind.Local).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 10, 15, 15, 51, 49, 845, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 10, 15, 15, 51, 50, 81, DateTimeKind.Local).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 10, 15, 15, 51, 50, 81, DateTimeKind.Local).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 10, 15, 15, 51, 50, 81, DateTimeKind.Local).AddTicks(169));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 10, 15, 15, 51, 50, 81, DateTimeKind.Local).AddTicks(169));

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 3, 5 },
                    { 1, 7 },
                    { 1, 9 },
                    { 2, 9 },
                    { 2, 18 },
                    { 2, 21 },
                    { 3, 23 },
                    { 1, 25 },
                    { 3, 25 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("72854465-d450-4ee1-ac1b-e1e8a2877d6f") },
                    { new Guid("a3314be5-4c77-4fb6-82ad-302014682a73"), new Guid("865bcd33-d26c-47b6-9d6e-c97682151b6a") },
                    { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("b1126a13-c169-496d-ad87-ae58d166a037") },
                    { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("b9135d46-5d92-4290-93ae-818117b33f99") },
                    { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("e888b698-6bb8-4d1f-a266-e9a1566a6933") }
                });
        }
    }
}
