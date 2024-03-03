using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TARS_Delivery.Migrations
{
    /// <inheritdoc />
    public partial class update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(6770), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(6786) });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(6791), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(6793), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(6902), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(6905), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(6906) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(6909), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(6909) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(6941), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(6941) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(6944), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(6945) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(6948), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(6948) });

            migrationBuilder.UpdateData(
                table: "FeeCustoms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(6973), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(6974) });

            migrationBuilder.UpdateData(
                table: "FeeCustoms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(6976), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(6977) });

            migrationBuilder.UpdateData(
                table: "FeeCustoms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(6979), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "FeeCustoms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7009), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7010) });

            migrationBuilder.UpdateData(
                table: "HistoryLogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7036), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7036) });

            migrationBuilder.UpdateData(
                table: "HistoryLogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7039), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7040) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7067), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7068) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7070), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7071) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7092), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7093) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7095), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7096) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7098), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7101), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7103), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7105), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7106) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7108), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7110), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7110) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7112), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7113) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7115), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7115) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7117), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7119), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7122), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7122) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7124), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7124) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7126), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7127) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7128), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7131), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7131) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7133), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7133) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7135), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7136) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7170), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7174), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7174) });

            migrationBuilder.UpdateData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7315), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7315) });

            migrationBuilder.UpdateData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7317), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7318) });

            migrationBuilder.UpdateData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7320), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7280), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7281) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7283), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7283) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7285), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7286) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7288), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7288) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7290), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7246), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7247) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7252), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7253) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7255), new DateTime(2024, 3, 2, 20, 16, 27, 623, DateTimeKind.Local).AddTicks(7255) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5056), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5075) });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5080), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5082), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5082) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5183), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5183) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5186), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5186) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5189), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5189) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5214), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5215) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5218), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5218) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5245), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "FeeCustoms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5270), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5271) });

            migrationBuilder.UpdateData(
                table: "FeeCustoms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5273), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5274) });

            migrationBuilder.UpdateData(
                table: "FeeCustoms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5276), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5277) });

            migrationBuilder.UpdateData(
                table: "FeeCustoms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5279), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5279) });

            migrationBuilder.UpdateData(
                table: "HistoryLogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5311), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5311) });

            migrationBuilder.UpdateData(
                table: "HistoryLogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5314), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5315) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5342), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5342) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5345), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5345) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5371), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5372) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5375), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5375) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5378), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5378) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5380), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5381) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5382), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5383) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5385), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5385) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5387), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5387) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5389), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5392), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5392) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5394), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5395) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5396), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5397) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5399), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5399) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5401), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5402) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5403), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5404) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5406), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5406) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5408), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5409) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5411), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5413), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5413) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5415), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5416) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5451), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5452) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5455), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5455) });

            migrationBuilder.UpdateData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5661), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5661) });

            migrationBuilder.UpdateData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5663), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5664) });

            migrationBuilder.UpdateData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5666), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5666) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5557), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5558) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5560), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5629), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5629) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5631), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5632) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5634), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5634) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5527), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5528) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5530), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5531) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5533), new DateTime(2024, 3, 2, 19, 52, 12, 540, DateTimeKind.Local).AddTicks(5533) });
        }
    }
}
