using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BinhDinhFood.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class changeMediaBannerSeedingUserAvatar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("38fe3520-3812-4cfe-bf96-27132cd95bfd") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a3314be5-4c77-4fb6-82ad-302014682a73"), new Guid("a94e0a72-8a58-4368-b425-06a834dd7480") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("b8dbf035-2522-4533-a257-e1bf0b14f0b1") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("c7c06ac6-36d8-4f36-ba9e-f8ac54de8bc7") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("c900b6a0-8355-4c71-bc55-6b21b28127d3") });

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("38fe3520-3812-4cfe-bf96-27132cd95bfd"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("a94e0a72-8a58-4368-b425-06a834dd7480"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("b8dbf035-2522-4533-a257-e1bf0b14f0b1"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("c7c06ac6-36d8-4f36-ba9e-f8ac54de8bc7"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("c900b6a0-8355-4c71-bc55-6b21b28127d3"));

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Banner");

            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "Media",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "Caption",
                table: "Media",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Banner",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "ApplicationUser",
                columns: new[] { "Id", "AccessFailedCount", "Address", "AvatarId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("7fd027d4-bbc5-47a2-9243-3e5136eb7d65"), 0, "Admin City", null, "776c37c2-be04-44e7-8327-392fb170284d", "admin@example.com", false, false, null, "Admin User", null, null, "AQAAAAIAAYagAAAAEK+ariBOQ+Y0shdXfTxBtBToHmBpun91AYzfh8znFQYuSPK2LnIoJF7/UTyZHCITNA==", "123456789", false, "ebe4a09e-4c4b-4af7-a21a-2e6fedccf127", false, "admin" },
                    { new Guid("a077bf63-f25a-49f8-b16a-95426ff86c1c"), 0, "Saigon", null, "21d82aa3-4630-4555-9dcd-53cad34eca31", "nhondeptrai@example.com", false, false, null, "dotnet evil", null, null, "AQAAAAIAAYagAAAAEDjJUBVtnPwh5GiWaqrAbVMOIQw2fFBQMDIcenFaBZB4QPTV48WmzBsz6HQ39LTT9A==", "0905726748", false, "2ed57ade-6cce-4899-afc0-d01b694a0c24", false, "nhondeptrai" }
                });

            migrationBuilder.UpdateData(
                table: "Banner",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Banner",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Banner",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Banner",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageId",
                value: 7);

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "Caption", "DateCreated", "FileSize", "PathMedia", "Type" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 10, 15, 7, 56, 4, 321, DateTimeKind.Local).AddTicks(8172), null, "https://example.com/avatar1.png", 1 },
                    { 2, null, new DateTime(2024, 10, 15, 7, 56, 4, 321, DateTimeKind.Local).AddTicks(8197), null, "https://example.com/avatar2.png", 1 },
                    { 3, null, new DateTime(2024, 10, 15, 7, 56, 4, 321, DateTimeKind.Local).AddTicks(8197), null, "https://example.com/avatar3.png", 1 },
                    { 4, null, new DateTime(2024, 10, 15, 7, 56, 4, 513, DateTimeKind.Local).AddTicks(5397), null, "slide_home_1.jpg", 1 },
                    { 5, null, new DateTime(2024, 10, 15, 7, 56, 4, 513, DateTimeKind.Local).AddTicks(5407), null, "slide_home_1.jpg", 1 },
                    { 6, null, new DateTime(2024, 10, 15, 7, 56, 4, 513, DateTimeKind.Local).AddTicks(5408), null, "slide_home_1.jpg", 1 },
                    { 7, null, new DateTime(2024, 10, 15, 7, 56, 4, 513, DateTimeKind.Local).AddTicks(5408), null, "slide_home_1.jpg", 1 }
                });

            migrationBuilder.InsertData(
                table: "ApplicationUser",
                columns: new[] { "Id", "AccessFailedCount", "Address", "AvatarId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("1161bc74-97f6-47fa-95bd-d1ba8ab59aa7"), 0, "Nam Định", 3, "f3715555-8bf8-4161-b0ad-e5528d44cc22", "taiphamduc@example.com", false, false, null, "Phạm Đức Tài", null, null, "AQAAAAIAAYagAAAAEO5G1eIbd6/YTfKCiDf9RcDXd1VYZo/cbPOBeRWoGjcL1uyiO6wF9f8LeD+QfCeZ4Q==", "0905726748", false, "ffa409a5-1814-4485-9a66-2303e1873d76", false, "tai" },
                    { new Guid("84c55fc3-0707-4141-86df-ab0c5f6c7aac"), 0, "Quy Nhơn, Bình Định", 1, "38bf51b9-f7f5-474f-946e-9b079e306e35", "truongnhon@example.com", false, false, null, "Võ Thương Trường Nhơn", null, null, "AQAAAAIAAYagAAAAEL4pognRAqjHdVpI1IujDPflGu2Rp1eNbO5VPQa5+g7zTx+qA8kt9zkruzXMdkNN8w==", "0905726748", false, "56d96616-843d-48d5-add6-bcfb8e6ee034", false, "truongnhon" },
                    { new Guid("9843c709-dad7-40d2-971b-8cb17d39db27"), 0, "Tây Ninh", 2, "7ed989ae-0a9a-4564-a674-c7ce858db240", "hongthai@example.com", false, false, null, "Nguyễn Hồng Thái", null, null, "AQAAAAIAAYagAAAAEC8gzU1/zGYfnOvzGictmdPpEHnjmDToNYXxaxDkODw/MPaza1R9zDBomuzdbwKXQA==", "0905726748", false, "5a897138-01f9-44ca-ab81-c91cacf6a584", false, "thai" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("a3314be5-4c77-4fb6-82ad-302014682a73"), new Guid("7fd027d4-bbc5-47a2-9243-3e5136eb7d65") },
                    { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("a077bf63-f25a-49f8-b16a-95426ff86c1c") },
                    { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("1161bc74-97f6-47fa-95bd-d1ba8ab59aa7") },
                    { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("84c55fc3-0707-4141-86df-ab0c5f6c7aac") },
                    { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("9843c709-dad7-40d2-971b-8cb17d39db27") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Banner_ImageId",
                table: "Banner",
                column: "ImageId",
                unique: true,
                filter: "[ImageId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Banner_Media_ImageId",
                table: "Banner",
                column: "ImageId",
                principalTable: "Media",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Banner_Media_ImageId",
                table: "Banner");

            migrationBuilder.DropIndex(
                name: "IX_Banner_ImageId",
                table: "Banner");

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("1161bc74-97f6-47fa-95bd-d1ba8ab59aa7") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a3314be5-4c77-4fb6-82ad-302014682a73"), new Guid("7fd027d4-bbc5-47a2-9243-3e5136eb7d65") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("84c55fc3-0707-4141-86df-ab0c5f6c7aac") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("9843c709-dad7-40d2-971b-8cb17d39db27") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("a077bf63-f25a-49f8-b16a-95426ff86c1c") });

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("1161bc74-97f6-47fa-95bd-d1ba8ab59aa7"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("7fd027d4-bbc5-47a2-9243-3e5136eb7d65"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("84c55fc3-0707-4141-86df-ab0c5f6c7aac"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("9843c709-dad7-40d2-971b-8cb17d39db27"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("a077bf63-f25a-49f8-b16a-95426ff86c1c"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Banner");

            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "Media",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Caption",
                table: "Media",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Banner",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "ApplicationUser",
                columns: new[] { "Id", "AccessFailedCount", "Address", "AvatarId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("38fe3520-3812-4cfe-bf96-27132cd95bfd"), 0, "Tây Ninh", null, "ff0e5c17-8621-4991-a5b3-6d22f2c32bc9", "hongthai@example.com", false, false, null, "Nguyễn Hồng Thái", null, null, "AQAAAAIAAYagAAAAENgGoVGVtor9kjFxIiLvIHM+pxoyUPe15pvkx9I/ULX5bFAInCVOn8fN9KpyVUM40g==", "0905726748", false, "81020dfa-add3-4808-baba-e79f0b696ea5", false, "thai" },
                    { new Guid("a94e0a72-8a58-4368-b425-06a834dd7480"), 0, "Admin City", null, "e961f40e-1d06-4e28-afac-17df299ddf38", "admin@example.com", false, false, null, "Admin User", null, null, "AQAAAAIAAYagAAAAEK2itYSuR3JgX8jRdyEqlzZXbW2L2ljunIpOYcRdP6VbFEY58NNua8FI2n5NAZOCFQ==", "123456789", false, "71b4b255-9ead-4a4a-912f-a24a5750d41c", false, "admin" },
                    { new Guid("b8dbf035-2522-4533-a257-e1bf0b14f0b1"), 0, "Saigon", null, "10fa99cf-e690-4abc-97bc-3df99754d7ff", "nhondeptrai@example.com", false, false, null, "dotnet evil", null, null, "AQAAAAIAAYagAAAAEAixAvhlcb2v0wT62oxEBbnPYZEOs/Jk+IJ10EDb4uBdG8EXDe7597Gw/af4v2xyOQ==", "0905726748", false, "07bad3dd-0bb8-4205-b783-dd8344efb88a", false, "nhondeptrai" },
                    { new Guid("c7c06ac6-36d8-4f36-ba9e-f8ac54de8bc7"), 0, "Quy Nhơn, Bình Định", null, "a5c139ed-dafc-4f4b-8a8b-702b1ba3d2f6", "truongnhon@example.com", false, false, null, "Võ Thương Trường Nhơn", null, null, "AQAAAAIAAYagAAAAEDrNt6I6oEdnaN917tpdXQbjg77O3Ei5A5XALPxAHC6XfhRy1LYmpC2lDdGsxI7r2Q==", "0905726748", false, "e5c7cb93-bd71-42fa-bb45-a26e5db27d07", false, "truongnhon" },
                    { new Guid("c900b6a0-8355-4c71-bc55-6b21b28127d3"), 0, "Nam Định", null, "ab85c76e-bf11-4c2e-80dc-3b51a9b3e110", "taiphamduc@example.com", false, false, null, "Phạm Đức Tài", null, null, "AQAAAAIAAYagAAAAEKfX3ZFy9TCdHYFGSmMTF/SXxdylTn9IAregZN1SgIB6n9ZvV9IDZhPpjSbpfPtH0A==", "0905726748", false, "7b66b2bc-406e-40a9-b445-493c967180ad", false, "tai" }
                });

            migrationBuilder.UpdateData(
                table: "Banner",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "slide_home_1.jpg");

            migrationBuilder.UpdateData(
                table: "Banner",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "slide_home_2.jpg");

            migrationBuilder.UpdateData(
                table: "Banner",
                keyColumn: "Id",
                keyValue: 9,
                column: "Image",
                value: "slide_home_3.jpg");

            migrationBuilder.UpdateData(
                table: "Banner",
                keyColumn: "Id",
                keyValue: 10,
                column: "Image",
                value: "slide_home_4.jpg");

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("38fe3520-3812-4cfe-bf96-27132cd95bfd") },
                    { new Guid("a3314be5-4c77-4fb6-82ad-302014682a73"), new Guid("a94e0a72-8a58-4368-b425-06a834dd7480") },
                    { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("b8dbf035-2522-4533-a257-e1bf0b14f0b1") },
                    { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("c7c06ac6-36d8-4f36-ba9e-f8ac54de8bc7") },
                    { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("c900b6a0-8355-4c71-bc55-6b21b28127d3") }
                });
        }
    }
}
