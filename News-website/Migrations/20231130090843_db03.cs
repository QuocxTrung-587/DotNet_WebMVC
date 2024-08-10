using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace News_website.Migrations
{
    /// <inheritdoc />
    public partial class db03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestedDate",
                value: new DateTime(2023, 11, 30, 16, 8, 43, 355, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestedDate",
                value: new DateTime(2023, 11, 30, 16, 8, 43, 355, DateTimeKind.Local).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "RequestedDate",
                value: new DateTime(2023, 11, 30, 16, 8, 43, 355, DateTimeKind.Local).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "RequestedDate",
                value: new DateTime(2023, 11, 30, 16, 8, 43, 355, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "https://cdn.bongdaplus.vn/Assets/Media/2023/11/30/36/park%20Choong%20Kyun.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestedDate",
                value: new DateTime(2023, 11, 30, 15, 54, 50, 117, DateTimeKind.Local).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestedDate",
                value: new DateTime(2023, 11, 30, 15, 54, 50, 117, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "RequestedDate",
                value: new DateTime(2023, 11, 30, 15, 54, 50, 117, DateTimeKind.Local).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "RequestedDate",
                value: new DateTime(2023, 11, 30, 15, 54, 50, 117, DateTimeKind.Local).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "https://image.sggp.org.vn/w560/Uploaded/2023/mrwqlqrnw/2023_05_07/img-9591-4011.jpg");
        }
    }
}
