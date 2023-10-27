using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HepsiApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ProductCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 10, 27, 16, 5, 50, 849, DateTimeKind.Local).AddTicks(7236), "Clothing, Outdoors & Toys" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 10, 27, 16, 5, 50, 849, DateTimeKind.Local).AddTicks(7246), "Clothing" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 10, 27, 16, 5, 50, 849, DateTimeKind.Local).AddTicks(7263), "Sports & Industrial" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 27, 16, 5, 50, 850, DateTimeKind.Local).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 27, 16, 5, 50, 850, DateTimeKind.Local).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 27, 16, 5, 50, 850, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 27, 16, 5, 50, 850, DateTimeKind.Local).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 27, 16, 5, 50, 854, DateTimeKind.Local).AddTicks(1642), "Consequatur dolayı rem kapının layıkıyla.", "Rem." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 27, 16, 5, 50, 854, DateTimeKind.Local).AddTicks(1688), "Eaque commodi qui enim enim.", "Dignissimos blanditiis." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 27, 16, 5, 50, 854, DateTimeKind.Local).AddTicks(1782), "Sit bilgiyasayarı magni voluptate totam.", "Sokaklarda." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2023, 10, 27, 16, 5, 50, 867, DateTimeKind.Local).AddTicks(7863), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 2.519868647168440m, 467.75m, "Handmade Concrete Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2023, 10, 27, 16, 5, 50, 867, DateTimeKind.Local).AddTicks(7900), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 2.807259843142890m, 811.77m, "Fantastic Fresh Pizza" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryId",
                table: "ProductCategories",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => new { x.CategoriesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 10, 2, 11, 55, 9, 788, DateTimeKind.Local).AddTicks(5359), "Automotive & Computers" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 10, 2, 11, 55, 9, 788, DateTimeKind.Local).AddTicks(5409), "Books, Outdoors & Garden" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 10, 2, 11, 55, 9, 788, DateTimeKind.Local).AddTicks(5697), "Automotive, Tools & Clothing" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 2, 11, 55, 9, 789, DateTimeKind.Local).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 2, 11, 55, 9, 789, DateTimeKind.Local).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 2, 11, 55, 9, 789, DateTimeKind.Local).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 2, 11, 55, 9, 789, DateTimeKind.Local).AddTicks(1106));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 2, 11, 55, 9, 798, DateTimeKind.Local).AddTicks(5240), "Vel bundan ekşili exercitationem quia.", "Vel." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 2, 11, 55, 9, 798, DateTimeKind.Local).AddTicks(5365), "Şafak sed eos de explicabo.", "Bahar dergi." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 2, 11, 55, 9, 798, DateTimeKind.Local).AddTicks(5411), "Kalemi çobanın dağılımı camisi dolorem.", "Mi." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2023, 10, 2, 11, 55, 9, 804, DateTimeKind.Local).AddTicks(6007), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 4.689733638177250m, 139.05m, "Sleek Soft Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2023, 10, 2, 11, 55, 9, 804, DateTimeKind.Local).AddTicks(6048), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 4.582524111670340m, 118.11m, "Intelligent Cotton Bike" });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_ProductsId",
                table: "CategoryProduct",
                column: "ProductsId");
        }
    }
}
