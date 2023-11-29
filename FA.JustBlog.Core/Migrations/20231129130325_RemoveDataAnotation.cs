using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    /// <inheritdoc />
    public partial class RemoveDataAnotation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostedOn",
                value: new DateTime(2023, 11, 29, 20, 3, 25, 666, DateTimeKind.Local).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedOn",
                value: new DateTime(2023, 11, 29, 20, 3, 25, 666, DateTimeKind.Local).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedOn",
                value: new DateTime(2023, 11, 29, 20, 3, 25, 666, DateTimeKind.Local).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "PostedOn",
                value: new DateTime(2023, 11, 29, 20, 3, 25, 666, DateTimeKind.Local).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "PostedOn",
                value: new DateTime(2023, 11, 29, 20, 3, 25, 666, DateTimeKind.Local).AddTicks(1556));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostedOn",
                value: new DateTime(2023, 11, 29, 19, 59, 15, 906, DateTimeKind.Local).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedOn",
                value: new DateTime(2023, 11, 29, 19, 59, 15, 906, DateTimeKind.Local).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedOn",
                value: new DateTime(2023, 11, 29, 19, 59, 15, 906, DateTimeKind.Local).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "PostedOn",
                value: new DateTime(2023, 11, 29, 19, 59, 15, 906, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "PostedOn",
                value: new DateTime(2023, 11, 29, 19, 59, 15, 906, DateTimeKind.Local).AddTicks(4114));
        }
    }
}
