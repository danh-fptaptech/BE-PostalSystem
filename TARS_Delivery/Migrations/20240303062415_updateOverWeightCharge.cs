using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TARS_Delivery.Migrations
{
    /// <inheritdoc />
    public partial class updateOverWeightCharge : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Distance",
                table: "FeeCustoms",
                newName: "OverWeightCharge");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7066), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7089), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7090) });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7091), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7092) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7244), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7245) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7247), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7248) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7250), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7251) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7284), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7288), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7288) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7291), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "FeeCustoms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OverWeightCharge", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7322), 2m, new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7322) });

            migrationBuilder.UpdateData(
                table: "FeeCustoms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OverWeightCharge", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7325), 3m, new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7325) });

            migrationBuilder.UpdateData(
                table: "FeeCustoms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OverWeightCharge", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7328), 4m, new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7328) });

            migrationBuilder.UpdateData(
                table: "FeeCustoms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OverWeightCharge", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7330), 5m, new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "HistoryLogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7362), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7362) });

            migrationBuilder.UpdateData(
                table: "HistoryLogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7365), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7365) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7399), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7400) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7402), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7403) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7438), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7438) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7442), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7442) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7444), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7445) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7447), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7447) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7449), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7449) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7451), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7452) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7454), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7454) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7456), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7457) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7458), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7459) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7461), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7461) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7463), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7466), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7466) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7468), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7468) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7470), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7471) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7473), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7473) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7475), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7476) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7477), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7478) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7480), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7482), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7483) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7556), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7557) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7560), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7560) });

            migrationBuilder.UpdateData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7733), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7736) });

            migrationBuilder.UpdateData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7738), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7741), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7688), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7689) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7691), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7693), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7694) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7695), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7696) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7698), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7698) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7654), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7654) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7657), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7657) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7659), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7660) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OverWeightCharge",
                table: "FeeCustoms",
                newName: "Distance");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4698), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4715) });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4721), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4721) });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4723), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4723) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4863), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4863) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4866), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4866) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4868), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4869) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4898), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4899) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4902), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4903) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4906), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4906) });

            migrationBuilder.UpdateData(
                table: "FeeCustoms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Distance", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4937), 15.5m, new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4938) });

            migrationBuilder.UpdateData(
                table: "FeeCustoms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Distance", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4940), 25.0m, new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4941) });

            migrationBuilder.UpdateData(
                table: "FeeCustoms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Distance", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4943), 30.0m, new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4944) });

            migrationBuilder.UpdateData(
                table: "FeeCustoms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Distance", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4946), 15.0m, new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4946) });

            migrationBuilder.UpdateData(
                table: "HistoryLogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4984), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4984) });

            migrationBuilder.UpdateData(
                table: "HistoryLogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4987), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4987) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5019), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5020) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5022), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5023) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5059), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5062), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5063) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5065), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5065) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5067), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5068) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5070), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5070) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5072), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5072) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5074), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5075) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5077), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5077) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5079), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5079) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5081), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5082) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5084), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5084) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5086), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5088), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5089) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5091), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5091) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5093), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5094) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5096), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5096) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5098), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5098) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5100), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5101) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5102), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5103) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5142), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5143) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5183), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5184) });

            migrationBuilder.UpdateData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5347), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5350), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5351) });

            migrationBuilder.UpdateData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5353), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5307), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5308) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5310), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5312), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5313) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5315), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5315) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5317), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5317) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5272), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5273) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5275), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5275) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5278), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(5278) });
        }
    }
}
