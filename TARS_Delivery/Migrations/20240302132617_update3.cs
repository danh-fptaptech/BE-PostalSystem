using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TARS_Delivery.Migrations
{
    /// <inheritdoc />
    public partial class update3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4937), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4938) });

            migrationBuilder.UpdateData(
                table: "FeeCustoms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4940), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4941) });

            migrationBuilder.UpdateData(
                table: "FeeCustoms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4943), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4944) });

            migrationBuilder.UpdateData(
                table: "FeeCustoms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4946), new DateTime(2024, 3, 2, 20, 26, 16, 534, DateTimeKind.Local).AddTicks(4946) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
