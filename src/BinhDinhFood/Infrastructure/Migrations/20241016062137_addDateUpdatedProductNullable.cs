using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BinhDinhFood.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addDateUpdatedProductNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 18 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 22 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 22 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 25 });

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

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdated",
                table: "Product",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "ApplicationUser",
                columns: new[] { "Id", "AccessFailedCount", "Address", "AvatarId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("4a077118-0667-4f28-8cba-aac7279885ac"), 0, "Saigon", null, "93cee426-389f-4c6c-8228-e6ae467f51aa", "nhondeptrai@example.com", false, false, null, "dotnet evil", null, null, "AQAAAAIAAYagAAAAEK1lwj5RCOYbhLnJPIQU9XDoBWphYFqCIIfrXigR6eP74o5+bJzYZUijWBxZT8jIwQ==", "0905726748", false, "ff106eba-7080-47b1-9ef6-a8689ade3ba6", false, "nhondeptrai" },
                    { new Guid("692f60bb-6f77-4d68-9384-3768aef40288"), 0, "Nam Định", 3, "5fc19385-3dff-4590-b371-bbc2d48982c5", "taiphamduc@example.com", false, false, null, "Phạm Đức Tài", null, null, "AQAAAAIAAYagAAAAECBDfFNC4miILTUziVdNdv5G6NeV3Nqe6n2lKKnLXax6r0JKRDbuU3z/RxICyGB+kg==", "0905726748", false, "2b82978f-280a-4c1b-a4f4-f3feacc80ddc", false, "tai" },
                    { new Guid("893edb85-6ad6-4b51-ab19-abbf36aa48c3"), 0, "Quy Nhơn, Bình Định", 1, "474fec87-a99f-42c0-9ffb-af1b1dec5976", "truongnhon@example.com", false, false, null, "Võ Thương Trường Nhơn", null, null, "AQAAAAIAAYagAAAAEGtZycwvDr6JNb5TtuZN2/2ErDJ4fmhue/i1EcEP2Diym/MZYm/i9mmvu6E5QrlzPg==", "0905726748", false, "578f0f62-3675-41b2-b912-1c002c2cb26c", false, "truongnhon" },
                    { new Guid("97ed5ff5-7269-422e-9af7-777014f42e6c"), 0, "Admin City", null, "aab287c2-9efd-4a09-bd19-1dcab30836b7", "admin@example.com", false, false, null, "Admin User", null, null, "AQAAAAIAAYagAAAAEKPUivJNTzaXc2SrRj/EFfw6UbHkr80vZS1JRVMTIOWle0AcKWFS8PgT/6TUjD9LGw==", "123456789", false, "66819a05-b59b-4b96-bfc9-9977ef8fe633", false, "admin" },
                    { new Guid("98056de7-7a15-49c1-a2e4-63025b6c2459"), 0, "Tây Ninh", 2, "e5e33dd6-4654-4546-96c2-7a9c3b68f107", "hongthai@example.com", false, false, null, "Nguyễn Hồng Thái", null, null, "AQAAAAIAAYagAAAAEPQmtSQtfaPU1WutVRYgzXPbp5qez2aQuCr+UbsWuY3KXvDkZPVjdOUHSSVeqyWB5g==", "0905726748", false, "e4a3352f-e9f2-4c77-aab6-927ae210fd12", false, "thai" }
                });

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 10, 16, 13, 21, 37, 32, DateTimeKind.Local).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 10, 16, 13, 21, 37, 32, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 10, 16, 13, 21, 37, 32, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 10, 16, 13, 21, 37, 230, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 10, 16, 13, 21, 37, 230, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 10, 16, 13, 21, 37, 230, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 10, 16, 13, 21, 37, 230, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUpdated",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateUpdated",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateUpdated",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateUpdated",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateUpdated",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateUpdated",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateUpdated",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateUpdated",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateUpdated",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateUpdated",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateUpdated",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateUpdated",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateUpdated",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateUpdated",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateUpdated",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateUpdated",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateUpdated",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateUpdated",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateUpdated",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateUpdated",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateUpdated",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateUpdated",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateUpdated",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateUpdated",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateUpdated",
                value: null);

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 3, 3 },
                    { 1, 7 },
                    { 3, 7 },
                    { 1, 9 },
                    { 2, 12 },
                    { 3, 12 },
                    { 3, 14 },
                    { 3, 17 },
                    { 1, 18 },
                    { 1, 19 },
                    { 3, 21 },
                    { 3, 23 },
                    { 2, 24 },
                    { 3, 24 },
                    { 1, 25 },
                    { 3, 25 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("4a077118-0667-4f28-8cba-aac7279885ac") },
                    { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("692f60bb-6f77-4d68-9384-3768aef40288") },
                    { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("893edb85-6ad6-4b51-ab19-abbf36aa48c3") },
                    { new Guid("a3314be5-4c77-4fb6-82ad-302014682a73"), new Guid("97ed5ff5-7269-422e-9af7-777014f42e6c") },
                    { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("98056de7-7a15-49c1-a2e4-63025b6c2459") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 3 });

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
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 17 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 19 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 21 });

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
                keyValues: new object[] { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("4a077118-0667-4f28-8cba-aac7279885ac") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("692f60bb-6f77-4d68-9384-3768aef40288") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("893edb85-6ad6-4b51-ab19-abbf36aa48c3") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a3314be5-4c77-4fb6-82ad-302014682a73"), new Guid("97ed5ff5-7269-422e-9af7-777014f42e6c") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("98056de7-7a15-49c1-a2e4-63025b6c2459") });

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("4a077118-0667-4f28-8cba-aac7279885ac"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("692f60bb-6f77-4d68-9384-3768aef40288"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("893edb85-6ad6-4b51-ab19-abbf36aa48c3"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("97ed5ff5-7269-422e-9af7-777014f42e6c"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("98056de7-7a15-49c1-a2e4-63025b6c2459"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdated",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
                    { 2, 4 },
                    { 1, 11 },
                    { 3, 11 },
                    { 1, 12 },
                    { 1, 14 },
                    { 1, 16 },
                    { 3, 18 },
                    { 1, 22 },
                    { 3, 22 },
                    { 2, 25 }
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
    }
}
