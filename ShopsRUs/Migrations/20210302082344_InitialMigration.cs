using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopsRUs.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiscountType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    Type = table.Column<string>(type: "TEXT", maxLength: 35, nullable: false),
                    Rate = table.Column<decimal>(type: "decimal(19, 2)", nullable: false),
                    IsRatePercentage = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    MiddleName = table.Column<string>(type: "TEXT", maxLength: 25, nullable: true),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    Address = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 13, nullable: false),
                    UserType = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    InvoiceId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InvoiceNumber = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    OrderId = table.Column<int>(type: "INTEGER", maxLength: 25, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(19, 2)", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.InvoiceId);
                    table.ForeignKey(
                        name: "FK_Invoices_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductName = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    ProductPrice = table.Column<decimal>(type: "TEXT", maxLength: 30, nullable: false),
                    ProductQuantity = table.Column<int>(type: "INTEGER", maxLength: 30, nullable: false),
                    DerivedProductCost = table.Column<decimal>(type: "decimal(19, 2)", nullable: false),
                    DiscountPrice = table.Column<decimal>(type: "decimal(19, 2)", nullable: false),
                    TotalDerivedCost = table.Column<decimal>(type: "decimal(19, 2)", nullable: false),
                    InvoiceId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceDetails_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "InvoiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DiscountType",
                columns: new[] { "Id", "IsRatePercentage", "Name", "Rate", "Type" },
                values: new object[] { 1, true, "Affiliate Discount", 10m, "Affiliate" });

            migrationBuilder.InsertData(
                table: "DiscountType",
                columns: new[] { "Id", "IsRatePercentage", "Name", "Rate", "Type" },
                values: new object[] { 2, true, "Employee Discount", 30m, "Employee" });

            migrationBuilder.InsertData(
                table: "DiscountType",
                columns: new[] { "Id", "IsRatePercentage", "Name", "Rate", "Type" },
                values: new object[] { 3, true, "Loyal Customer Discount", 5m, "Customer" });

            migrationBuilder.InsertData(
                table: "DiscountType",
                columns: new[] { "Id", "IsRatePercentage", "Name", "Rate", "Type" },
                values: new object[] { 4, false, "Price Discount", 5m, "Price" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "DateCreated", "Email", "FirstName", "LastName", "MiddleName", "PhoneNumber", "UserType" },
                values: new object[] { 1, null, new DateTime(2018, 3, 2, 9, 23, 44, 422, DateTimeKind.Local).AddTicks(7550), "user1@email.com", "Sheldon", "Cooper", "Lee", "123456789", "Customer" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "DateCreated", "Email", "FirstName", "LastName", "MiddleName", "PhoneNumber", "UserType" },
                values: new object[] { 2, null, new DateTime(2020, 12, 2, 9, 23, 44, 422, DateTimeKind.Local).AddTicks(7655), "user2@email.com", "Leonard", "Hoffsteder", "Lee", "12345678910", "Customer" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "DateCreated", "Email", "FirstName", "LastName", "MiddleName", "PhoneNumber", "UserType" },
                values: new object[] { 3, null, new DateTime(2020, 3, 2, 9, 23, 44, 422, DateTimeKind.Local).AddTicks(7663), "user3@email.com", "Penny", "Jackson", "L.", "123456789", "Affiliate" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "DateCreated", "Email", "FirstName", "LastName", "MiddleName", "PhoneNumber", "UserType" },
                values: new object[] { 4, null, new DateTime(2016, 3, 2, 9, 23, 44, 422, DateTimeKind.Local).AddTicks(7667), "user4@email.com", "Amy", "Fowler", null, "123456789", "Employee" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "DateCreated", "Email", "FirstName", "LastName", "MiddleName", "PhoneNumber", "UserType" },
                values: new object[] { 5, null, new DateTime(2018, 3, 2, 9, 23, 44, 422, DateTimeKind.Local).AddTicks(7670), "user5@email.com", "Raj", "Koothrappali", null, "123456789", "Employee" });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceId", "DateCreated", "InvoiceNumber", "OrderId", "Total", "UserId" },
                values: new object[] { 1, new DateTime(2021, 3, 2, 9, 23, 44, 424, DateTimeKind.Local).AddTicks(4740), "SRU001", 1, 500m, 1 });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceId", "DateCreated", "InvoiceNumber", "OrderId", "Total", "UserId" },
                values: new object[] { 2, new DateTime(2021, 3, 2, 9, 23, 44, 424, DateTimeKind.Local).AddTicks(6380), "SRU002", 2, 1500m, 2 });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceId", "DateCreated", "InvoiceNumber", "OrderId", "Total", "UserId" },
                values: new object[] { 3, new DateTime(2021, 3, 2, 9, 23, 44, 424, DateTimeKind.Local).AddTicks(6386), "SRU003", 3, 990m, 3 });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceId", "DateCreated", "InvoiceNumber", "OrderId", "Total", "UserId" },
                values: new object[] { 4, new DateTime(2021, 3, 2, 9, 23, 44, 424, DateTimeKind.Local).AddTicks(6388), "SRU004", 4, 920m, 4 });

            migrationBuilder.InsertData(
                table: "InvoiceDetails",
                columns: new[] { "Id", "DerivedProductCost", "DiscountPrice", "InvoiceId", "ProductId", "ProductName", "ProductPrice", "ProductQuantity", "TotalDerivedCost" },
                values: new object[] { 1, 40m, 2m, 1, 2, "Item 2", 20m, 2, 38m });

            migrationBuilder.InsertData(
                table: "InvoiceDetails",
                columns: new[] { "Id", "DerivedProductCost", "DiscountPrice", "InvoiceId", "ProductId", "ProductName", "ProductPrice", "ProductQuantity", "TotalDerivedCost" },
                values: new object[] { 2, 482m, 20m, 1, 4, "Item 4", 482m, 1, 462m });

            migrationBuilder.InsertData(
                table: "InvoiceDetails",
                columns: new[] { "Id", "DerivedProductCost", "DiscountPrice", "InvoiceId", "ProductId", "ProductName", "ProductPrice", "ProductQuantity", "TotalDerivedCost" },
                values: new object[] { 3, 250m, 0m, 2, 40, "Item 40", 50m, 5, 250m });

            migrationBuilder.InsertData(
                table: "InvoiceDetails",
                columns: new[] { "Id", "DerivedProductCost", "DiscountPrice", "InvoiceId", "ProductId", "ProductName", "ProductPrice", "ProductQuantity", "TotalDerivedCost" },
                values: new object[] { 4, 250m, 25m, 3, 3, "Item 3", 50m, 5, 225m });

            migrationBuilder.InsertData(
                table: "InvoiceDetails",
                columns: new[] { "Id", "DerivedProductCost", "DiscountPrice", "InvoiceId", "ProductId", "ProductName", "ProductPrice", "ProductQuantity", "TotalDerivedCost" },
                values: new object[] { 5, 400m, 20m, 3, 5, "Item 5", 400m, 1, 380m });

            migrationBuilder.InsertData(
                table: "InvoiceDetails",
                columns: new[] { "Id", "DerivedProductCost", "DiscountPrice", "InvoiceId", "ProductId", "ProductName", "ProductPrice", "ProductQuantity", "TotalDerivedCost" },
                values: new object[] { 6, 385m, 0m, 3, 15, "Item 15", 77m, 5, 385m });

            migrationBuilder.InsertData(
                table: "InvoiceDetails",
                columns: new[] { "Id", "DerivedProductCost", "DiscountPrice", "InvoiceId", "ProductId", "ProductName", "ProductPrice", "ProductQuantity", "TotalDerivedCost" },
                values: new object[] { 7, 1000m, 80m, 4, 105, "Item 105", 200m, 5, 920m });

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDetails_InvoiceId",
                table: "InvoiceDetails",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_UserId",
                table: "Invoices",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiscountType");

            migrationBuilder.DropTable(
                name: "InvoiceDetails");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
