using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TARS_Delivery.Migrations
{
    /// <inheritdoc />
    public partial class iupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1071), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1085) });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1091), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1091) });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1093), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1093) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1248), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1248) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1251), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1252) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1254), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1255) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1281), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1281) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1285), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1285) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1288), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1289) });

            migrationBuilder.UpdateData(
                table: "FeeCustoms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1323), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1324) });

            migrationBuilder.UpdateData(
                table: "FeeCustoms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1327), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1327) });

            migrationBuilder.UpdateData(
                table: "FeeCustoms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1329), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1330) });

            migrationBuilder.UpdateData(
                table: "FeeCustoms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1332), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1332) });

            migrationBuilder.UpdateData(
                table: "HistoryLogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1366), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1367) });

            migrationBuilder.UpdateData(
                table: "HistoryLogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1388), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1389) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1424), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1424) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1427), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1427) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1461), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1461) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1464), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1464) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1466), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1467) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1469), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1469) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1471), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1471) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1473), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1474) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1476), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1478), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1479) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1481), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1483), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1484) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1486), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1486) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1488), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1488) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1490), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1491) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1493), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1493) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1495), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1495) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1497), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1498) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1500), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1500) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1502), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1503) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1504), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1505) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1546), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1546) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1550), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1660), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1661) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1663), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1664) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1666), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1668), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1671), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1671) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1626), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1629), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1632), new DateTime(2024, 2, 25, 9, 0, 50, 95, DateTimeKind.Local).AddTicks(1632) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8306), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8321) });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8326), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8326) });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8328), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8328) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8448), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8449) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8452), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8453) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8455), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8455) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8484), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8485) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8489), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8493), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8493) });

            migrationBuilder.UpdateData(
                table: "FeeCustoms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8519), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "FeeCustoms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8523), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8523) });

            migrationBuilder.UpdateData(
                table: "FeeCustoms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8526), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8526) });

            migrationBuilder.UpdateData(
                table: "FeeCustoms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8528), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8529) });

            migrationBuilder.UpdateData(
                table: "HistoryLogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8555), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8557) });

            migrationBuilder.UpdateData(
                table: "HistoryLogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8559), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8587), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8587) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8590), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8591) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8613), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8614) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8618), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8619) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8621), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8621) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8623), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8624) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8626), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8627) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8659), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8659) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8662), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8664), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8666) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8668), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8669) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8671), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8672) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8674), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8674) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8676), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8677) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8679), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8679) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8681), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8682) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8684), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8685) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8687), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8688) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8690), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8691) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8693), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8696), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8696) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8738), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8743), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8744) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8839), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8839) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8841), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8844), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8846), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8849), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8849) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8811), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8812) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8814), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8815) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8817), new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8818) });
        }
    }
}
