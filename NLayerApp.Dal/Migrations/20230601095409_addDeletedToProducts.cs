using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayerApp.Dal.Migrations
{
    public partial class addDeletedToProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 1, 12, 54, 9, 675, DateTimeKind.Local).AddTicks(262));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 1, 12, 54, 9, 675, DateTimeKind.Local).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 6, 1, 12, 54, 9, 675, DateTimeKind.Local).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 1, 12, 54, 9, 675, DateTimeKind.Local).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 1, 12, 54, 9, 675, DateTimeKind.Local).AddTicks(405));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 3, 23, 22, 24, 22, 725, DateTimeKind.Local).AddTicks(2885));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 3, 23, 22, 24, 22, 725, DateTimeKind.Local).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 3, 23, 22, 24, 22, 725, DateTimeKind.Local).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 3, 23, 22, 24, 22, 725, DateTimeKind.Local).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 3, 23, 22, 24, 22, 725, DateTimeKind.Local).AddTicks(3064));
        }
    }
}
