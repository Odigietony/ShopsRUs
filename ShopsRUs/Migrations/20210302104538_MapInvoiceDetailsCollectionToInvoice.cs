using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopsRUs.Migrations
{
    public partial class MapInvoiceDetailsCollectionToInvoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "InvoiceId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 3, 2, 11, 45, 37, 94, DateTimeKind.Local).AddTicks(2936));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "InvoiceId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 3, 2, 11, 45, 37, 94, DateTimeKind.Local).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "InvoiceId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 3, 2, 11, 45, 37, 94, DateTimeKind.Local).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "InvoiceId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 3, 2, 11, 45, 37, 94, DateTimeKind.Local).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2018, 3, 2, 11, 45, 37, 92, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2020, 12, 2, 11, 45, 37, 92, DateTimeKind.Local).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2020, 3, 2, 11, 45, 37, 92, DateTimeKind.Local).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2016, 3, 2, 11, 45, 37, 92, DateTimeKind.Local).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2018, 3, 2, 11, 45, 37, 92, DateTimeKind.Local).AddTicks(747));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "InvoiceId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 3, 2, 9, 23, 44, 424, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "InvoiceId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 3, 2, 9, 23, 44, 424, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "InvoiceId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 3, 2, 9, 23, 44, 424, DateTimeKind.Local).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "InvoiceId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 3, 2, 9, 23, 44, 424, DateTimeKind.Local).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2018, 3, 2, 9, 23, 44, 422, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2020, 12, 2, 9, 23, 44, 422, DateTimeKind.Local).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2020, 3, 2, 9, 23, 44, 422, DateTimeKind.Local).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2016, 3, 2, 9, 23, 44, 422, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2018, 3, 2, 9, 23, 44, 422, DateTimeKind.Local).AddTicks(7670));
        }
    }
}
