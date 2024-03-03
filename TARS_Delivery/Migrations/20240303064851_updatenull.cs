using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TARS_Delivery.Migrations
{
    /// <inheritdoc />
    public partial class updatenull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "OverWeightCharge",
                table: "FeeCustoms",
                type: "decimal(12,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2656), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2669) });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2678), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2679) });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2680), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2775), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2779), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2779) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2781), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2782) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2812), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2812) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2816), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2816) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2819), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2820) });

            migrationBuilder.UpdateData(
                table: "FeeCustoms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2847), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2848) });

            migrationBuilder.UpdateData(
                table: "FeeCustoms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2851), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2851) });

            migrationBuilder.UpdateData(
                table: "FeeCustoms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2853), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2854) });

            migrationBuilder.UpdateData(
                table: "FeeCustoms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2856), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2856) });

            migrationBuilder.UpdateData(
                table: "HistoryLogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2887), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2887) });

            migrationBuilder.UpdateData(
                table: "HistoryLogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2890), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2891) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2918), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2922), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2922) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2946), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2947) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2949), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2950) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2952), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2952) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2954), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2955) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2957), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2957) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2959), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2959) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2961), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2962) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2964), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2964) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2966), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2966) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2968), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2969) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2971), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2971) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2973), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2973) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2975), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2976) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2978), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2978) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2980), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2980) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2982), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2984), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2985) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2987), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2987) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2989), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(3049), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(3049) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(3053), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(3053) });

            migrationBuilder.UpdateData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(3195), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(3196) });

            migrationBuilder.UpdateData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(3199), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(3201), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(3202) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(3161), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(3164), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(3164) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(3166), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(3167) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(3169), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(3169) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(3171), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(3171) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(3131), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(3132) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(3135), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(3136) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(3138), new DateTime(2024, 3, 3, 13, 48, 50, 922, DateTimeKind.Local).AddTicks(3138) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "OverWeightCharge",
                table: "FeeCustoms",
                type: "decimal(12,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)",
                oldNullable: true);

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
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7322), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7322) });

            migrationBuilder.UpdateData(
                table: "FeeCustoms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7325), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7325) });

            migrationBuilder.UpdateData(
                table: "FeeCustoms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7328), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7328) });

            migrationBuilder.UpdateData(
                table: "FeeCustoms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7330), new DateTime(2024, 3, 3, 13, 24, 15, 318, DateTimeKind.Local).AddTicks(7330) });

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
    }
}
