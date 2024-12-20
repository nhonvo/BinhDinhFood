﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BinhDinhFood.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageId = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Banner",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Discount = table.Column<int>(type: "int", maxLength: 1, nullable: true, defaultValue: 0),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banner", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ForgotPassword",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OTP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForgotPassword", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quality = table.Column<int>(type: "int", nullable: false),
                    OffPrice = table.Column<int>(type: "int", maxLength: 1, nullable: false, defaultValue: 0),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayOrder = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DayDelivery = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaidState = table.Column<bool>(type: "bit", nullable: false),
                    DeliveryState = table.Column<bool>(type: "bit", nullable: false),
                    TotalMoney = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_ApplicationUser_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefreshToken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Expires = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Revoked = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshToken_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogin",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogin", x => new { x.LoginProvider, x.ProviderKey, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserLogin_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_UserTokens_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Favorite",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId1 = table.Column<int>(type: "int", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorite", x => new { x.ProductId, x.CustomerId });
                    table.ForeignKey(
                        name: "FK_Favorite_ApplicationUser_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favorite_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favorite_Product_ProductId1",
                        column: x => x.ProductId1,
                        principalTable: "Product",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Media",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: true),
                    PathMedia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    FileSize = table.Column<long>(type: "bigint", nullable: true),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BannerId = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    BlogId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Media_ApplicationUser_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Media_Banner_BannerId",
                        column: x => x.BannerId,
                        principalTable: "Banner",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Media_Blog_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blog",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Media_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ProductCategory_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategory_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Stars = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Review_ApplicationUser_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Review_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductId1 = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => new { x.ProductId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Product_ProductId1",
                        column: x => x.ProductId1,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ApplicationUser",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageId", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("4d60f144-c346-42cc-952c-efcc255d06cf"), 0, "Saigon", "9090ca4a-bc8d-4767-94e0-e0bb59efc5fb", "nhondeptrai@example.com", false, null, false, null, "dotnet evil", null, null, "AQAAAAIAAYagAAAAEDpeR5+1vWQkzmQN8Vif4RFPHKJ8oS8XfIXX37mS2IG1gBJ9HjqABPLZB8fOQUhC8w==", "0905726748", false, "8782c658-b8f2-47c6-afa8-8952fb332e91", false, "nhondeptrai" },
                    { new Guid("6e726b2e-144a-40d7-b66e-30ca64a6575e"), 0, "Admin City", "7888893d-a57b-4a36-be01-66dc654980fd", "admin@example.com", false, null, false, null, "Admin User", null, null, "AQAAAAIAAYagAAAAEKFVwN9Zr0Vv3o0LKOYFiMdyqW2halKo0aczCCUV6dXwhdf6vTpVL9aXaQmgzxxQUw==", "123456789", false, "b61c8137-c82a-41de-b872-79ca5afdbd14", false, "admin" },
                    { new Guid("bad8eb9e-05ed-4040-9494-ca5de7498094"), 0, "Tây Ninh", "0fcd717a-fcf3-4c12-b78c-df235590cd86", "hongthai@example.com", false, 52, false, null, "Nguyễn Hồng Thái", null, null, "AQAAAAIAAYagAAAAEH6x+TZPUo0cVQgl49TNOu4sWv7kfz5ih9uO8GUhz4tujWW67QsCSUDq3e8zauQRnw==", "0905726748", false, "5fd2f35a-f03c-457b-8959-3f089d211b19", false, "thai" },
                    { new Guid("bc7fac01-c39e-4512-ada7-f03f09d5194f"), 0, "Nam Định", "0b740a46-a7f1-4fd8-9d46-51587c9abd47", "taiphamduc@example.com", false, 53, false, null, "Phạm Đức Tài", null, null, "AQAAAAIAAYagAAAAEPbQoP7CbydgTXUtKl/LndbBSQFYyx061fXj3GGFF6WGifKw7PBNAIr9e3LDDsR9xQ==", "0905726748", false, "342e1407-a5db-4907-abb9-7f7387dabeac", false, "tai" },
                    { new Guid("fe744598-20f7-4d11-bc3e-968f00dff0b6"), 0, "Quy Nhơn, Bình Định", "c8f6c8dd-24eb-4a02-b142-30677eafa097", "truongnhon@example.com", false, 51, false, null, "Võ Thương Trường Nhơn", null, null, "AQAAAAIAAYagAAAAEKrx6RRi/XbeKEU6vO85LxbjmNEBDIp1kkAMr72zazuqF3ZuiCA/zcdOLAGDc7FmsA==", "0905726748", false, "1f4205e6-2f8f-4cbd-8b0c-a688867e7018", false, "truongnhon" }
                });

            migrationBuilder.InsertData(
                table: "Banner",
                columns: new[] { "Id", "DateCreated", "Description", "Discount", "Name", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chả cá Quy Nhơn nổi tiếng với hương vị đặc trưng, được làm từ cá tươi ngon vùng biển Quy Nhơn.", 10, "Chả cá Quy Nhơn", 100000m },
                    { 2, new DateTime(2022, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gỏi cá chình là món ăn đặc sản với hương vị chua ngọt, kết hợp từ cá chình tươi ngon và các loại rau thơm.", 15, "Gỏi cá Chình", 200000m },
                    { 3, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nem chợ Huyện, món ăn truyền thống với hương vị thơm ngon, được làm từ thịt heo tươi và gia vị đặc trưng.", 5, "Nem chợ Huyện", 150000m }
                });

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "Id", "Content", "DateCreated", "Name" },
                values: new object[,]
                {
                    { 1, "Mực rim là món ăn phổ biến khiến du thích yêu thích có mặt ở hầu hết những vùng biển lớn. Tuy nhiên mực rim hay còn gọi là mực ngào Bình Định có một hương vị thơm ngon rất riêng từ vùng biển duyên hải miền Trung. Mực rim Quy Nhơn được người dân làm từ những con mực tươi nhất và hương vị không nơi nào giống được. Với hương thơm ngon đặc biệt cùng vị cay cay kích thích vị giác, mực rim trở thành món ăn vặt siêu ngon và được mọi người vô cùng yêu thích. Đồng thời, với những hũ mực rim được làm sẵn giúp bạn có thể dễ dàng lựa chọn đặc sản Bình Định này để làm quà tặng.", new DateTime(2022, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mực rim Quy Nhơn" },
                    { 2, "Với tên gọi độc và lạ của món Chả Tré, món đặc sản Bình Định này đã gợi nên sự tò mò với nhiều du khách muốn tìm hiểu và được thử món ăn độc đáo này. Mặc dù đã có mặt phổ biến khắp các tỉnh thành Trung Trung bộ, nhưng hương vị thơm ngon nhất vẫn là chả Tré Bình Định với cách làm và công thức chỉ vùng đất Bình Định mới làm nên được.Thành phần nguyên liệu làm chả Tré cũng tương tự với các loại nem, bì của miền bắc. Nhưng Tré Bình Định được người dân nơi đây khéo léo thay thế bằng nhiều loại nguyên liệu khác như tai heo, lỗ mũi heo, da heo, thịt ba chỉ,...Tré cũng thích hợp để trở thành món quà mang về khi bạn đến thăm Bình Định.", new DateTime(2022, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chả Tré rơm" },
                    { 3, "Mặc dù chả cá có thể là đặc sản và có mặt ở nhiều nơi nhưng không phải hương vị chả cá nào cũng như nhau. Sở dĩ chả cá Quy Nhơn là một trong các đặc sản Bình Định nổi tiếng vì vị ngon và lạ đặc trưng. Với nguyên liệu được tuyển chọn từ những con cá biển tươi ngon nhất và công thức chế biến độc quyền của người dân đã tạo nên sự khác biệt cho chả cá Quy Nhơn. Chả cá Quy Nhơn phổ biến có 2 loại là chả hấp và chả chiên. Ngoài việc thưởng thức thực tiếp miếng chả dai, giòn, thơm ngon đặc biệt, các bạn có thể dùng chả cá này để làm “topping” cho các món ăn khác như cơm, bún, phở. Đây cũng là một lựa chọn thích hợp để bạn mua về làm quà cho người thân và bạn bè nữa đó.", new DateTime(2022, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chả cá Quy Nhơn" },
                    { 4, "Đây là một món ngon đặc sản Quy Nhơn rất đỗi bình dị nhưng được du khách rất yêu thích. Nó được bày bán ở hầu hết các quán xá vỉa hè ở Bình Định. Bánh xèo được làm được những  nguyên liệu đơn giản như thịt heo băm nhuyễn, hành phi, rau thơm, trứng và bột gạo. Gaọ sẽ được tuyển chọn những những gạo to chắc mẩy không bị sâu để tạo độ ngọt của bánh. Gạo sẽ được đem đi xay và nấu bột thành một thứ hỗn hợp dẻo, đập trứng cho thịt băm và một số loại gia vị vào. Bên cạnh đó đac có một cái chảo đang được đun nóng. Người nấu sẽ múc từng múc lên chảo để tráng những miếng bánh, dải thịt băm nhuyễn đã được xào chín lên bên trên bề mặt bánh và guộn đều tay để bánh to tròn và đẹp. Hoặc có thể là những con tôm tươi ngon. Khi  ăn ăn kèm với rau thơm và nước chấm.", new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bánh Xèo Mỹ Cang" },
                    { 5, "Khi đến du lịch Bình Định không thể không nhắc tới  món bánh tráng nước dừa. Đây là một món đặc sản nơi xứ dừa. Công đoạn chế biến bánh không quá cầu kì nhưng đòi hỏi sự tỉ mỉ, có kinh nghiệm của người tráng bánh. Nguyên liệu của bánh chủ yếu là Củ Mì ( củ sắn) được sắt nhỏ, xay lấy nước. Cơm dừa được nạo thành sợi nhỏ,  nước dừa và vừng đen. Tất cả đều được đổ chung vào một nồi lớn, trộn đều cho các gia vị hòa quyện cùng với nhau và được đun nóng. Bên cạnh đó có một chảo đang được đun nóng. Khi chảo nóng lên người tráng bánh sẽ dùng một cái gáo làm bằng sọ dừa có cán dài múc từng gáo nước bánh lên chảo và tráng đều. Tráng bánh phải đều tay để cơm dừa và vừng đen được dàn đều mặt bánh. Bánh phải tròn mỏng và không bị chỗ dày, chỗ mỏng thì mới là bánh đạt chuẩn. cứ tráng được mười chiếc  bánh thì đem ra phơi. khi ăn bạn cần nướng lên để bánh có độ phồng và dậy hết mùi thơm của vừng, của nước cốt dừa và cơm dừa. Có thể ăn bánh thay cơm ăn chỉ thấy no mà không thấy chán.", new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bánh tráng nước dừa" },
                    { 6, "Bún song thần có chút khác biệt với các loại bún thông thường khác bởi thay vì sợi bún được làm từ bột gạo hay bột củ mì kéo sợi thì bún song thần lại được làm từ bột đậu xanh. Bún Song thần đặc sản Bình Định có màu trắng đặc trưng. Bún được đặt song  song bên nhau nên có tên là bún song thần. Món đặc sản này có giá trị dinh dưỡng cao hơn các loại bún khác. Tuy nhiên giá thành của bún khá cao bởi 5kg đậu xanh chỉ là được 1kg bún.", new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bún song  thần" },
                    { 7, "Món món hải sản ngon nức tiếng ở Bình Định. Cua Huỳnh đếđược xem là vua của các loại cua bởi nó có mai đỏ vàng như một bộ long bào uy nghi của các nhà vua, hai bên có gai li ti sắc nhọn, hai chiếc càng to chắc khỏe. Cua thường sống trong những ngách đá trên biển Bình Định. Cua Huỳnh Đế có thịt thơm, chắc  và có thể chế biến thành nhiều món ăn ngon khác nhau như cua nướng, cua hấp… đều rất thơm ngon.", new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cua Huỳnh Đế" },
                    { 8, "Cá Chích là loại cá nước ngọt sống ở các sông hồ ao suối. Cũng bởi Bình Định có nhiều sông hồ nên đây là môi trường thuận lợi để loài đặc sản này sinh sống. Cá Chích đặc sản Bình Định có thân  hình nhỏ, dài. Cá Chích sau khi được  đánh bắt lên sẽ được làm  sạch  và chiên giòn. Vì  là loài cá có kích cỡ nhỏ nên  khi ăn  người ta sẽ kẹp cả con cá đã được chiên vàng ăn với bánh phở cuốn, kèm rau thơm, dưa chuột. Cá ngọt thịt nên bạn ăn sẽ không bị chán. Tuy Nhiên nếu bạn là tín đồ gỏi sống bạn có thể được  thưởng thức gỏi cá chích với những thớ thịt  đc lọc xương làm sạch.", new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gỏi cá chích" },
                    { 9, "Bánh hồng Tam Quan là một trong những món đặc sản của Bình Định, được xem như biểu trưng cho tin vui, thường xuất hiện trong các dịp cưới hỏi của người dân nơi đây. Điều đặc biệt bánh hồng Tam Quan là bánh được làm từ gạo nếp Ngự nổi tiếng dẻo thơm. Do hoàn toàn không có chất bảo quản nên bánh chỉ để được 5 ngày thôi bạn nhé.", new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bánh hồng Tam Quan" },
                    { 10, "Bánh tráng chả cá là một trong những đặc sản nổi tiếng gần xa của Bình Định. Bánh tráng chả cá được làm từ nguyên liệu chính là cá cùng một ít gia vị và bột năng. Để món ăn đúng vị hơn bạn nên ăn kèm với rau răm nhé.", new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bánh tráng chả cá" },
                    { 11, "Nếu đã đến với đất Bình Định thì bạn nhất định phải thử qua món mực ngào vị tỏi nhé. Món ăn là sự hòa quyện giữa vị mực vừa tươi vừa giòn cùng vị cay đặc trưng của ớt và tỏi. Bạn nhớ bảo quản món này ở nhiệt độ thoáng mát nha.", new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mực ngào vị tỏi" }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "Description", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "A comprehensive guide to C# programming.", 29.989999999999998, "C# Programming" },
                    { 2, "Learn how to build web applications using ASP.NET Core.", 35.5, "ASP.NET Core Development" },
                    { 3, "Master the Entity Framework Core ORM for .NET development.", 40.0, "Entity Framework Core In Action" },
                    { 4, "Everything you need to know about building Blazor WebAssembly applications.", 45.990000000000002, "Blazor WebAssembly: The Complete Guide" },
                    { 5, "Implement common design patterns in C# to improve code structure.", 50.0, "Design Patterns in C#" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "DateCreated", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đồ khô" },
                    { 2, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bánh truyền thống" },
                    { 3, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đồ đặc sản" }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "BannerId", "BlogId", "Caption", "CustomerId", "FileSize", "PathMedia", "ProductId", "Type" },
                values: new object[,]
                {
                    { 51, null, null, null, null, null, "https://example.com/avatar1.png", null, 1 },
                    { 52, null, null, null, null, null, "https://example.com/avatar2.png", null, 1 },
                    { 53, null, null, null, null, null, "https://example.com/avatar3.png", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "DateCreated", "Description", "Name", "OffPrice", "Price", "Quality", "Rating" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mặc dù chả cá có thể là đặc sản và có mặt ở nhiều nơi nhưng không phải hương vị chả cá nào cũng như nhau. Sở dĩ chả cá Quy Nhơn là một trong các đặc sản Bình Định nổi tiếng vì vị ngon và lạ đặc trưng. Với nguyên liệu được tuyển chọn từ những con cá biển tươi ngon nhất và công thức chế biến độc quyền của người dân đã tạo nên sự khác biệt cho chả cá Quy Nhơn.\n Chả cá Quy Nhơn phổ biến có 2 loại là chả hấp và chả chiên. Ngoài việc thưởng thức thực tiếp miếng chả dai, giòn, thơm ngon đặc biệt, các bạn có thể dùng chả cá này để làm “topping” cho các món ăn khác như cơm, bún, phở. Đây cũng là một lựa chọn thích hợp để bạn mua về làm quà cho người thân và bạn bè nữa đó.", "Chả cá Quy Nhơn", 10, 120000m, 100, 0 },
                    { 2, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tôm khô còn gọi là tôm nõn khô là một trong các loại thực phẩm giàu dinh dưỡng rất tốt cho sức khỏe. Chúng được làm từ tôm tươi tự nhiên và phơi khô dưới ánh nắng mặt trời hoặc sấy khô thủ công. 1kg tôm tươi làm được khoảng 2 lạng tôm khô, thành phẩm tôm có kích thước nhỏ hơn, có vị ngọt thanh đậm đà rất thơm.\nGiá trị dinh dưỡng của tôm vẫn giữ gần như nguyên vẹn, trong 100g tôm khô có: 347 kcal, 75,6g đạm, 235mg canxi, 4,6mg sắt, vitamin B1, B2, PP và 3,8g chất béo chưa bảo hòa.", "Tôm khô", 20, 84000m, 20, 0 },
                    { 3, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nhum có rất nhiều loại khác nhau, nhưng mắm nhum tại Bình Định đặc biệt được làm từ con nhum ta, tạo hương vị ngon đến nỗi “ăn với món gì cũng ngon”. Đồng thời mắm Nhum tại Mỹ An cũng từng là đặc sản Bình Định được tiến vua, và hiện nay là một món ăn mà du khách không thể bỏ lỡ khi đến Bình Định du lịch.\nNhum vốn là động vật với bê ngoài gai góc có thể làm đau người dân nếu đạp phải, và người dân nơi đây đã biến chúng thành một món ngon tuyệt vời. Mắm nhum còn có thể là món quà hảo hạng giúp bạn dùng làm quà tặng sau khi đến Bình Định du lịch, nếu được thì bạn nên đến Mỹ An để mua mắm nhum nhé.", "Mắm Nhum Mỹ An Bình Định", 5, 20000m, 100, 0 },
                    { 4, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "cá cơm giàu vitamin A, nhiều axit béo, vitamin E, canxi, Vitamin A, giúp mắt sáng, ngăn ngừa các bệnh về mắt, duy trì làn da khỏe mạnh. Ăn cá cơm giúp giảm lượng cholesterol trong máu, ngăn ngừa các bệnh về tim mạch.\nCá cơm cung cấp một lượng lớn protein và đạm, nên chúng được sử dụng để làm nước mắm nhĩ", "Cá cơm khô", 15, 18000m, 55, 0 },
                    { 5, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nem chua là một trong các đặc sản Bình Định được chế biến cầu kỳ và công phu. Với công thức hương vị đặc biệt để ướp những miếng thịt heo tươi ngon nhất và gói bên trong những lớp lá khế non và lớp lá chuối cầu kì, hương vị thơm ngon nổi tiếng của nem chợ huyện cũng từ đó mà vang xa.\nĐến Bình Định ngồi cắn một miếng nem và nhâm nhi một ít rượu Bàu Đá cũng đủ để bạn nhớ về hương vị ấy mỗi khi nhắc đến chuyến du lịch này đó. Ngoài ra, nem cũng là lựa chọn thích hợp để làm quà tặng, với hương vị tuyệt vời ấy ai lại lỡ không thích món quà mà bạn tặng.", "Nem chợ huyện", 20, 150000m, 100, 0 },
                    { 6, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "“Muốn ăn bánh ít lá gai Lấy chồng Bình Định sợ dài đường đi\"Bánh ít lá gai là một trong các đặc sản Bình Định nổi tiếng. Để làm nên những chiếc bánh ít thơm ngon nức tiếng, người làm bánh phải lựa chọn và chuẩn bị những chiếc lá gai rất cầu kỳ vì đây là yếu tố quan trong quyết định đến hương vị của bánh. Kế đến là nếp và nhân cũng được lựa chọn và chế biến từ những nguyên liệu ngon nhất.\n Sau một quá trình xay bột, làm nhân, gói và hấp bánh, những chiếc bánh ít lá gai thơm ngon, dẻo dai với vị ngọt của nhân đậu xanh hoặc nhân dừa đã được ra lò. Với đặc sản này bạn nên thử ít nhất một lần, và đây cũng được xem là một món quà mà chắc chắn người thân của bạn sẽ thích.", "Bánh ít lá gai", 10, 100000m, 100, 0 },
                    { 7, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mực rim là món ăn phổ biến khiến du thích yêu thích có mặt ở hầu hết những vùng biển lớn. Tuy nhiên mực rim hay còn gọi là mực ngào Bình Định có một hương vị thơm ngon rất riêng từ vùng biển duyên hải miền Trung. Mực rim Quy Nhơn được người dân làm từ những con mực tươi nhất và hương vị không nơi nào giống được.\n Với hương thơm ngon đặc biệt cùng vị cay cay kích thích vị giác, mực rim trở thành món ăn vặt siêu ngon và được mọi người vô cùng yêu thích. Đồng thời, với những hũ mực rim được làm sẵn giúp bạn có thể dễ dàng lựa chọn đặc sản Bình Định này để làm quà tặng.", "Mực rim Quy Nhơn", 5, 150000m, 100, 0 },
                    { 8, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Với tên gọi độc và lạ của món Chả Tré, món đặc sản Bình Định này đã gợi nên sự tò mò với nhiều du khách muốn tìm hiểu và được thử món ăn độc đáo này. Mặc dù đã có mặt phổ biến khắp các tỉnh thành Trung Trung bộ, nhưng hương vị thơm ngon nhất vẫn là chả Tré Bình Định với cách làm và công thức chỉ vùng đất Bình Định mới làm nên được.\n Thành phần nguyên liệu làm chả Tré cũng tương tự với các loại nem, bì của miền bắc. Nhưng Tré Bình Định được người dân nơi đây khéo léo thay thế bằng nhiều loại nguyên liệu khác như tai heo, lỗ mũi heo, da heo, thịt ba chỉ,...Tré cũng thích hợp để trở thành món quà mang về khi bạn đến thăm Bình Định.", "Chả Tré rơm", 20, 35000m, 100, 3 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "DateCreated", "Description", "Name", "Price", "Quality", "Rating" },
                values: new object[,]
                {
                    { 9, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nếu như Hà Nội có bánh cốm, Hải Dương có bánh đậu xanh, Vũng Tàu có bánh bông lan trứng muối,...và những loại bánh làm quà đặc trưng của nhiều tỉnh khác thì Quy Nhơn lại bánh thuẫn nổi tiếng để làm quà tặng cho người thân và bạn bè. Đây cũng là loại bánh phổ biến vào ngày Tết của người dân miền Trung.\n Bánh thuẫn có vị thơm ngon từ nguyên liệu như trứng gà, bột năng, bột bình tinh, đường, đâu ăn, vani và đặc biệt là khuôn đúc bánh. Quá trình đúc bánh bằng than đã góp phần tạo nên được mùi thơm đặc trưng của đặc sản Bình Định này.", "Bánh thuẫn", 15000m, 100, 0 },
                    { 10, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sở dĩ rượu Bàu đá được biết đến là một trong những đặc sản Bình Định nổi tiếng vì đây là loại rượu không nấu từ gạo thông thường như những loại rượu khác. Rượu Bàu đá Bình Định được nấu từ gạo lứt và chỉ khi sử dụng một nguồn nước trong một làng của tỉnh Bình Định mới đạt được hương vị ngon nhất.\n Từ xưa, rượu Bàu đá đã được tiến cung cho vua nên được xếp vào loại đặc sản thượng hạng của Bình Định. Rượu nổi tiếng dễ say vì có độ cồn rất cao, lên đến 50. Nhưng điều khiến người ta yêu thích hương vị của rượu là vị thanh mát mang lại cảm giác sảng khoái vô cùng. Đây cũng là một món quà thích hợp thể hiện sự kính trọng bạn có thể chọn.", "Rượu Bầu đá", 40000m, 100, 0 },
                    { 11, new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Một trong những món ăn phải kể đến đầu tiên trong dah sách những món đặc sản Bình Định đó chính là mực ngào. Mực ngào có một hương vị thơm ngon rất riêng thu hút khách du lịch. Để chế biến được món mực ngào người đầu bếp đã phải rất công phu, tài tình tỉ mỉ chăm chút cho món ăn. Mực sau khi đươc thu mua từ những cảng hải sản tươi ngon được đem về sơ chế và chế biến luôn để giữ được độ tươi ngon nguyên vẹn  của mực.\nMực được  ướp cùng tiêu, tỏi, ớt, mắm và một số loại gia vị khác để tạo độ thơm ngon đặc trưng của mực. Món ăn này có vị cay đặc trưng, thơm thơm của các loại gia vị sẽ làm bạn thích thú và muốn ăn ngay từ cái nhìn đầu tiên. Gía của một cân mực ngào giao động từ  200.000 – 400.000 đồng.", "Mực ngào Bình Định", 250000m, 100, 0 },
                    { 12, new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cá chỉ vàng là loài cá nước mặn (còn gọi là cá ngân chỉ) thức ăn của chúng là những sinh vật nổi. Thân cá dẹp hình thoi, hai bên có một sọc vàng chạy thẳng từ sau mắt đến gần vây đuôi, phần lưng màu xanh xám, bụng trắng bạc, trên mang cá có chấm đen, vây đuôi vàng, đầu cá hơi nhọn, miệng chếch, hàm dưới nhô ra.\n Cá chỉ vàng thịt trắng có vị ngọt thơm, giàu vitamin B, Omega 3 giúp ngăn ngừa bệnh tim mạch, tốt cho não bộ, cải thiện giấc ngủ...", "Khô cá chỉ vàng", 135000m, 100, 0 },
                    { 13, new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Khi đến du lịch Bình Định không thể không nhắc tới  món bánh tráng nước dừa. Đây là một món đặc sản nơi xứ dừa. Công đoạn chế biến bánh không quá cầu kì nhưng đòi hỏi sự tỉ mỉ, có kinh nghiệm của người tráng bánh. Nguyên liệu của bánh chủ yếu là Củ Mì ( củ sắn) được sắt nhỏ, xay lấy nước. Cơm dừa được nạo thành sợi nhỏ,  nước dừa và vừng đen. Tất cả đều được đổ chung vào một nồi lớn, trộn đều cho các gia vị hòa quyện cùng với nhau và được đun nóng. Bên cạnh đó có một chảo đang được đun nóng. Khi chảo nóng lên người tráng bánh sẽ dùng một cái gáo làm bằng sọ dừa có cán dài múc từng gáo nước bánh lên chảo và tráng đều. Tráng bánh phải đều tay để cơm dừa và vừng đen được dàn đều mặt bánh. Bánh phải tròn mỏng và không bị chỗ dày, chỗ mỏng thì mới là bánh đạt chuẩn. cứ tráng được mười chiếc  bánh thì đem ra phơi. khi ăn bạn cần nướng lên để bánh có độ phồng và dậy hết mùi thơm của vừng, của nước cốt dừa và cơm dừa. Có thể ăn bánh thay cơm ăn chỉ thấy no mà không thấy chán.", "Bánh tráng nước dừa", 120000m, 50, 0 },
                    { 14, new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nước mắm nhĩ hay nhỉ còn gọi là nước mắm kéo lù hoặc mắm cốt, là loại nước mắm được hứng từ các giọt nước mắm đầu tiên được “nhỉ” ra. Hay nói cách khác là rò rỉ ra từng giọt, từng giọt từ lỗ van đang đóng kín ở đáy của thùng hay lu vại đang muối cá đã đến thời gian chín có thể lấy nước mắm thành phẩm.", "Nước mắm nhĩ Bình Định", 95000m, 50, 0 },
                    { 15, new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Con ruốc còn gọi là tép biển, tép moi, ở Việt Nam được coi là đặc sản. Chúng là động vật giáp xác 10 chân sống ở vùng nước mặn ven biển hay nước lợ. Ruốc dạng như tôm nhỏ, chỉ lớn khoảng 10–40 mm Do kích thước của con ruốc biển nhỏ, nên thường được dùng để làm nước mắm ruốc (là một loại mắm đặc sản của miền biển) hoặc phơi khô ruốc để chế biến thành các món ăn dân dã đậm đà hương vị biển.", "Ruốt khô", 200000m, 50, 0 },
                    { 16, new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hải sản Quy Nhơn nổi tiếng khắp cả nước với nhiều loại hải sản phong phú đa dạng, trong đó Cá lao là một loại hải sản khô đặc biệt thơm ngon, chúng là một loại cá biển, sau khi được ngư dân đánh bắt được xẻ thịt, phơi khô tạo nên một loại thực phẩm thơm ngon đúng chất tinh túy từ biển.", "Cá Lao Khô Tẩm Gia Vị", 125000m, 50, 0 },
                    { 17, new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bánh hồng Tam Quan là một trong những món đặc sản của Bình Định, được xem như biểu trưng cho tin vui, thường xuất hiện trong các dịp cưới hỏi của người dân nơi đây.\n Điều đặc biệt bánh hồng Tam Quan là bánh được làm từ gạo nếp Ngự nổi tiếng dẻo thơm. Do hoàn toàn không có chất bảo quản nên bánh chỉ để được 5 ngày thôi bạn nhé.", "Bánh hồng Tam Quan", 200000m, 50, 0 },
                    { 18, new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bánh tráng chả cá là một trong những đặc sản nổi tiếng gần xa của Bình Định. Bánh tráng chả cá được làm từ nguyên liệu chính là cá cùng một ít gia vị và bột năng. Để món ăn đúng vị hơn bạn nên ăn kèm với rau răm nhé.", "Bánh tráng chả cá", 400000m, 50, 0 },
                    { 19, new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nếu đã đến với đất Bình Định thì bạn nhất định phải thử qua món mực ngào vị tỏi nhé. Món ăn là sự hòa quyện giữa vị mực vừa tươi vừa giòn cùng vị cay đặc trưng của ớt và tỏi. Bạn nhớ bảo quản món này ở nhiệt độ thoáng mát nha.", "Mực ngào vị tỏi", 200000m, 100, 0 },
                    { 20, new DateTime(2022, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chả ram tôm đất là một trong những món ngon đặc sản nổi tiếng của miền đất võ Bình Định, món ăn này phù hợp với mọi lứa tuổi, từ già đến trẻ đều yêu thích và thường xuyên xuất hiện trong các bữa cơm gia đình.\n Miếng chả ram tôm đất Bình Định giòn tan của lớp bánh tráng chiên bên ngoài, bên trong có thịt tôm ngọt tự nhiên, một chút ngầy ngậy của thịt mỡ, tất cả tạo nên hương vị đặc biệt hấp dẫn, gây nghiện cho thực khách khi dùng thử món ăn độc đáo này.", "Chả ram tôm đất", 890000m, 45, 0 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "DateCreated", "Description", "Name", "OffPrice", "Price", "Quality", "Rating" },
                values: new object[,]
                {
                    { 21, new DateTime(2022, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ghẹ sữa là ghẹ còn non có kích thước nhỏ, cỡ ngón chân cái người lớn, nhiều nhất vào tháng 5 đến tháng 11, thời điểm ghẹ sinh sản nhiều.\nGhẹ sữa có hàm lượng dinh dưỡng cao, nhiều canxi, đạm, sắt, các vitamin A, B1, B2, C và đặc biệt là magnesium, calcium và axit béo omega 3, có lợi cho sức khỏe và rất tốt cho người có vấn đề tim mạch và hỗ trợ tăng trưởng chiều cao cho trẻ.", "Ghẹ sữa rim tỏi ớt, rang me, chiên giòn", 15, 90000m, 44, 4 },
                    { 22, new DateTime(2022, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mực một nắng là loại hải sản đặc biệt, để làm mực 1 nắng được ngon, sau khi xẻ phải rửa mực tươi bằng nước biển, rồi phơi dưới trời nắng gắt. Chỉ được phơi qua một nắng để mực vẫn giữ được độ tươi ngon, bên ngoài ráo nước, bên trong dẻo và giòn. \nNhững vùng biển có nước biển càng mặn thì mực 1 nắng sẽ càng ngon, đặc biệt là các khu vực miền Trung. Mực một nắng có nhiều loại, nhưng mực ngon nhất vẫn là làm từ những con mực ống và mực lá.\nĐây là một trong các đặc sản nổi tiếng của Bình Định được du khách tìm mua làm quà.", "Mực một nắng", 20, 500000m, 50, 2 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "DateCreated", "Description", "Name", "Price", "Quality", "Rating" },
                values: new object[,]
                {
                    { 23, new DateTime(2022, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cá đù hay Cá lù đù là một họ cá thuộc bộ Cá vược (Perciformes) có kích thước lớn, chúng sống ở vùng biển nhiệt đới, cận nhiệt đới. Tại vùng biển Việt Nam, có khoảng 270 loài trong 70 chi, đáng kể nhất là cá lù đù bạc chiếm số lượng lớn trong 20 loài như cá lù đù măng đen, cá lù đù lỗ tai đen, cá lù đù kẽm, cá lù đù sóc, cá lù đù đỏ dạ...\nChúng sống thành từng đàn lớn ở gần bờ, thường núp trong những rạn, hốc đá. Thức ăn của chúng là các loại động vật thủy sinh, côn trùng hay cá nhỏ, giáp xác.\n Vì muốn dự trữ được lâu nên sau khi được đánh bắt, ngư dân chọn cá tươi làm sạch, xẻ lóc bỏ xương, bỏ đầu để ráo. Sau đó, đem phơi khô dưới 1 nắng gắt để cá se lại để thịt dẻo dẻo. Hoặc có thể phơi cho thật khô để dự trữ ăn dần.\n Cá đù 1 nắng phần thân sau của cá có nhiều mỡ, rất béo. Loại cá này có vị ngọt dịu deo dẻo và đặc biệt thịt mềm, hậu bùi, có thể chế biến thành nhiều món ngon hấp dẫn. \nHiện nay, đây là đặc sản được rất nhiều người săn lùng, kể cả người nước ngoài cũng rất thích thú với vị ngon ngọt của nó “đặc biệt là giá cả phải chăng”.", "Cá đù một nắng", 16000m, 12, 0 },
                    { 24, new DateTime(2022, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chả Bò (Giò Bò) Bình Định Chính Gốc – Cây 500G", "Chả Bò (Giò Bò) Bình Định Chính Gốc – Cây 500G", 180000m, 15, 0 },
                    { 25, new DateTime(2022, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đến với Bình Định, du khách sẽ được thưởng thức những món được làm từ các loại bánh tráng. Nào là bánh tráng mè nướng, bánh tráng nước cốt dừa Tam Quan hay bánh tráng bột mì nhứt nướng, bánh tráng gạo nhúng, … loại bánh nào cũng ngon nhứt nách. Hôm nay, Đặc Sản Bình Định Online xin được giới thiệu đến quý khách một loại bánh tráng độc đáo hơn cả đó là bánh tráng nhúng giòn Phù Mỹ. Hãy cùng khám phá bạn nhé. Nếu có cơ hội đến Bình Định hãy thử một lần thưởng thức loại bánh tráng đặc sản Phù Mỹ để tự cảm nhận hương vị thơm ngon đặc trưng của nó nhé.", "Bánh Tráng Nhúng Giòn Phù Mỹ", 45000m, 20, 0 }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("a3314be5-4c77-4fb6-82ad-302014682a73"), null, "Admin", "ADMIN" },
                    { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "BannerId", "BlogId", "Caption", "CustomerId", "FileSize", "PathMedia", "ProductId", "Type" },
                values: new object[,]
                {
                    { 1, 1, null, null, null, null, "slide_home_1.jpg", null, 1 },
                    { 2, 2, null, null, null, null, "slide_home_2.jpg", null, 1 },
                    { 3, 3, null, null, null, null, "slide_home_3.jpg", null, 1 },
                    { 11, null, 1, null, null, null, "mucrim.png", null, 1 },
                    { 12, null, 2, null, null, null, "chatre.png", null, 1 },
                    { 13, null, 3, null, null, null, "chaca.png", null, 1 },
                    { 14, null, 3, null, null, null, "banh-xeo-my-cang-dac-san-binh-dinh.vntrip-e1501650332846.jpg", null, 1 },
                    { 15, null, 3, null, null, null, "Banh-trang-nuoc-dua-am-thuc-binh-dinh.jpg", null, 1 },
                    { 16, null, 3, null, null, null, "bat-bun-song-than.jpg", null, 1 },
                    { 17, null, 3, null, null, null, "cua-huynh-de-vntrip-e1536313616403.jpg", null, 1 },
                    { 18, null, 3, null, null, null, "goi-ca-chinh-binh-dinh.jpg", null, 1 },
                    { 19, null, 3, null, null, null, "banhhong.jpg", null, 1 },
                    { 20, null, 3, null, null, null, "banhtrangchaca.jpg", null, 1 },
                    { 21, null, null, null, null, null, "chaca.png", 1, 1 },
                    { 22, null, null, null, null, null, "tom-kho-gia-bao-nhieu-1kg.jpg", 2, 1 },
                    { 23, null, null, null, null, null, "mamnhum.png", 3, 1 },
                    { 24, null, null, null, null, null, "cach-lam-ca-kho-tam-gia-vi.jpg", 4, 1 },
                    { 25, null, null, null, null, null, "nem.png", 5, 1 },
                    { 26, null, null, null, null, null, "banhit.png", 6, 1 },
                    { 27, null, null, null, null, null, "mucrim.png", 7, 1 },
                    { 28, null, null, null, null, null, "chatre.png", 8, 1 },
                    { 29, null, null, null, null, null, "banhthuan.png", 9, 1 },
                    { 30, null, null, null, null, null, "ruoubauda.png", 10, 1 },
                    { 31, null, null, null, null, null, "muc-ngao-ot-dac-san-binh-dinh-lam-qua.jpg", 11, 1 },
                    { 32, null, null, null, null, null, "cach-lua-ca-chi-vang-kho-ngon.jpg", 12, 1 },
                    { 33, null, null, null, null, null, "Banh-trang-nuoc-dua-am-thuc-binh-dinh.jpg", 13, 1 },
                    { 34, null, null, null, null, null, "nuoc-mam-nhi-nguyen-chat-tam-quan-binh-dinh.jpg", 14, 1 },
                    { 35, null, null, null, null, null, "các-món-từ-ruốc-khô.jpg", 15, 1 },
                    { 36, null, null, null, null, null, "cá-lao-khô-quy-nhơn.jpg", 16, 1 },
                    { 37, null, null, null, null, null, "banhhong.jpg", 17, 1 },
                    { 38, null, null, null, null, null, "banhtrangchaca.jpg", 18, 1 },
                    { 39, null, null, null, null, null, "muc-ngao-ot-dac-san-binh-dinh-lam-qua.jpg", 19, 1 },
                    { 40, null, null, null, null, null, "chả-ram-tôm-đất-quy-nhơn-ngon-loại-1.jpg", 20, 1 },
                    { 41, null, null, null, null, null, "ghe-sua-chien-gion.jpg", 21, 1 },
                    { 42, null, null, null, null, null, "muc-mot-nang-gia-bao-nhieu-1kg.jpg", 22, 1 },
                    { 43, null, null, null, null, null, "cá-đù-một-nắng.jpg", 23, 1 },
                    { 44, null, null, null, null, null, "cha-bo-binh-dinh-nha-lam.jpg", 24, 1 },
                    { 45, null, null, null, null, null, "banh-trang-nhung-binh-dinh.jpg", 25, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 2 },
                    { 1, 3 },
                    { 3, 3 },
                    { 1, 4 },
                    { 2, 4 },
                    { 3, 4 },
                    { 1, 5 },
                    { 2, 5 },
                    { 3, 5 },
                    { 2, 6 },
                    { 3, 6 },
                    { 1, 7 },
                    { 3, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 3, 9 },
                    { 1, 10 },
                    { 2, 10 },
                    { 3, 10 },
                    { 1, 11 },
                    { 3, 11 },
                    { 1, 12 },
                    { 2, 12 },
                    { 3, 13 },
                    { 1, 14 },
                    { 3, 14 },
                    { 1, 15 },
                    { 2, 15 },
                    { 3, 15 },
                    { 1, 16 },
                    { 2, 16 },
                    { 3, 16 },
                    { 1, 17 },
                    { 1, 18 },
                    { 2, 18 },
                    { 1, 19 },
                    { 2, 19 },
                    { 3, 19 },
                    { 2, 20 },
                    { 3, 20 },
                    { 2, 21 },
                    { 3, 21 },
                    { 1, 22 },
                    { 2, 22 },
                    { 1, 23 },
                    { 1, 24 },
                    { 1, 25 },
                    { 2, 25 },
                    { 3, 25 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("4d60f144-c346-42cc-952c-efcc255d06cf") },
                    { new Guid("a3314be5-4c77-4fb6-82ad-302014682a73"), new Guid("6e726b2e-144a-40d7-b66e-30ca64a6575e") },
                    { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("bad8eb9e-05ed-4040-9494-ca5de7498094") },
                    { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("bc7fac01-c39e-4512-ada7-f03f09d5194f") },
                    { new Guid("b4314be5-4c77-4fb6-82ad-302014682b13"), new Guid("fe744598-20f7-4d11-bc3e-968f00dff0b6") }
                });

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "ApplicationUser",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "ApplicationUser",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Favorite_CustomerId",
                table: "Favorite",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorite_ProductId1",
                table: "Favorite",
                column: "ProductId1");

            migrationBuilder.CreateIndex(
                name: "IX_Media_BannerId",
                table: "Media",
                column: "BannerId",
                unique: true,
                filter: "[BannerId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Media_BlogId",
                table: "Media",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_CustomerId",
                table: "Media",
                column: "CustomerId",
                unique: true,
                filter: "[CustomerId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Media_ProductId",
                table: "Media",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderId",
                table: "OrderDetail",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProductId1",
                table: "OrderDetail",
                column: "ProductId1");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategory_CategoryId",
                table: "ProductCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_UserId",
                table: "RefreshToken",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_CustomerId",
                table: "Review",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_ProductId",
                table: "Review",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Role",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogin_UserId",
                table: "UserLogin",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Favorite");

            migrationBuilder.DropTable(
                name: "ForgotPassword");

            migrationBuilder.DropTable(
                name: "Media");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "ProductCategory");

            migrationBuilder.DropTable(
                name: "RefreshToken");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogin");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Banner");

            migrationBuilder.DropTable(
                name: "Blog");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "ApplicationUser");
        }
    }
}
