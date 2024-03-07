using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TARS_Delivery.Migrations
{
    /// <inheritdoc />
    public partial class updateSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeneralSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SettingName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SettingValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationLevel = table.Column<int>(type: "int", nullable: false),
                    LocationOf = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_Locations_LocationOf",
                        column: x => x.LocationOf,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PermissionName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubmitedInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoleHasPermissions",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    PermissionId = table.Column<int>(type: "int", nullable: false),
                    RoleId1 = table.Column<int>(type: "int", nullable: false),
                    RoleId2 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleHasPermissions", x => new { x.RoleId, x.PermissionId });
                    table.ForeignKey(
                        name: "FK_RoleHasPermissions_Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoleHasPermissions_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoleHasPermissions_Roles_RoleId1",
                        column: x => x.RoleId1,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceTypeId = table.Column<int>(type: "int", nullable: false),
                    WeighFrom = table.Column<int>(type: "int", nullable: false),
                    WeighTo = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_ServiceTypes_ServiceTypeId",
                        column: x => x.ServiceTypeId,
                        principalTable: "ServiceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeInfo = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FeeCustoms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    LocationIdFrom = table.Column<int>(type: "int", nullable: false),
                    LocationIdTo = table.Column<int>(type: "int", nullable: false),
                    OverWeightCharge = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    FeeCharge = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    TimeProcess = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeeCustoms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeeCustoms_Locations_LocationIdFrom",
                        column: x => x.LocationIdFrom,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FeeCustoms_Locations_LocationIdTo",
                        column: x => x.LocationIdTo,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FeeCustoms_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Packages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrackingCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NameFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCodeFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCodeTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PackageSize = table.Column<int>(type: "int", nullable: true),
                    PackageNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Step = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Packages_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Packages_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistoryLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackageId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Step = table.Column<int>(type: "int", nullable: false),
                    HistoryNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessStep = table.Column<int>(type: "int", nullable: false),
                    EmployeeIdNextStep = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoryLogs_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoryLogs_Employees_EmployeeIdNextStep",
                        column: x => x.EmployeeIdNextStep,
                        principalTable: "Employees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HistoryLogs_Packages_PackageId",
                        column: x => x.PackageId,
                        principalTable: "Packages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackageId = table.Column<int>(type: "int", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemWeight = table.Column<int>(type: "int", nullable: false),
                    ItemQuantity = table.Column<int>(type: "int", nullable: false),
                    ItemValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ItemType = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Packages_PackageId",
                        column: x => x.PackageId,
                        principalTable: "Packages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Address", "BranchName", "CreatedAt", "District", "PhoneNumber", "PostalCode", "Province", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "1234 TARS Street", "TARS Delivery", new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8176), "TARS", "123456789", "1234", "TARS", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8192) },
                    { 2, "1234 TARS Street", "TARS Delivery 2", new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8198), "TARS", "123456789", "1234", "TARS", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8199) },
                    { 3, "1234 TARS Street", "TARS Delivery 3", new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8200), "TARS", "123456789", "1234", "TARS", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8201) }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "CreatedAt", "LocationLevel", "LocationName", "LocationOf", "PostalCode", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8716), 0, "Ho Chi Minh city", null, "700000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8716) },
                    { 59, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8918), 0, "Ha Noi", null, "100000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8919) },
                    { 134, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9220), 0, "Binh Duong", null, "750000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9221) },
                    { 177, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9335), 0, "Long An", null, "850000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9335) },
                    { 230, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9499), 0, "Lam Dong", null, "670000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9499) }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "PermissionName" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "User" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName", "Status" },
                values: new object[,]
                {
                    { 1, "Admin", 0 },
                    { 2, "Branch Manager", 0 },
                    { 3, "Warehouse", 0 },
                    { 4, "Delivery", 0 }
                });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "CreatedAt", "ServiceDescription", "ServiceName", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 7, 19, 20, 8, 469, DateTimeKind.Local).AddTicks(91), "Fast and secure international delivery service", "EMS Delivery Service", 1, new DateTime(2024, 3, 7, 19, 20, 8, 469, DateTimeKind.Local).AddTicks(91) },
                    { 2, new DateTime(2024, 3, 7, 19, 20, 8, 469, DateTimeKind.Local).AddTicks(94), "Fast and convenient express delivery service", "Express Delivery", 1, new DateTime(2024, 3, 7, 19, 20, 8, 469, DateTimeKind.Local).AddTicks(95) },
                    { 3, new DateTime(2024, 3, 7, 19, 20, 8, 469, DateTimeKind.Local).AddTicks(97), "Reliable freight and cargo delivery solutions", "Freight Delivery Services", 1, new DateTime(2024, 3, 7, 19, 20, 8, 469, DateTimeKind.Local).AddTicks(98) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Avatar", "CreatedAt", "Email", "Fullname", "Password", "Phone", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "avatar.jpg", new DateTime(2024, 3, 7, 19, 20, 8, 469, DateTimeKind.Local).AddTicks(3), "usera@usera", "Nguyễn Văn User", "123", "0123456789", 1, new DateTime(2024, 3, 7, 19, 20, 8, 469, DateTimeKind.Local).AddTicks(3) },
                    { 2, "avatar.jpg", new DateTime(2024, 3, 7, 19, 20, 8, 469, DateTimeKind.Local).AddTicks(8), "userb@userb", "Trần Thị User", "123", "0987654321", 1, new DateTime(2024, 3, 7, 19, 20, 8, 469, DateTimeKind.Local).AddTicks(8) },
                    { 3, "avatar.jpg", new DateTime(2024, 3, 7, 19, 20, 8, 469, DateTimeKind.Local).AddTicks(11), "userc@userc", "Lê Văn User", "123", "023023920392", 1, new DateTime(2024, 3, 7, 19, 20, 8, 469, DateTimeKind.Local).AddTicks(11) }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "CreatedAt", "District", "Name", "PhoneNumber", "Province", "Status", "TypeInfo", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, "Số 1, Đường 1, Phường 1, Quận 1, TP HCM", new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8470), "Quận 1", "Nguyễn Văn Customer", "0123456789", "TP HCM", 1, 0, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8471), 1 },
                    { 2, "Số 2, Đường 2, Phường 2, Quận 2, TP HCM", new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8473), "Quận 2", "Trần Thị Customer", "0987654321", "TP HCM", 1, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8474), 2 },
                    { 3, "Số 3, Đường 3, Phường 3, Quận 3, TP HCM", new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8476), "Quận 3", "Lê Văn Customer", "044333333", "TP HCM", 1, 0, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8477), 3 }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Avatar", "BranchId", "CreatedAt", "District", "Email", "EmployeeCode", "Fullname", "Password", "PhoneNumber", "PostalCode", "Province", "RoleId", "Status", "SubmitedInfo", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Số 1, Đường 1, Phường 1, Quận 1, TP HCM", "avatar.jpg", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8510), "Quận 1", "emp1@emp1", "EMP001", "Nguyễn Văn Employee", "123", "0123456789", "700000", "TP HCM", 1, 1, "SubmitedInfo", new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8510) },
                    { 2, "Số 2, Đường 2, Phường 2, Quận 2, TP HCM", "avatar.jpg", 2, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8514), "Quận 2", "emp2@emp2", "EMP002", "Trần Thị Employee", "123", "0987654321", "700000", "TP HCM", 2, 1, "SubmitedInfo", new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8515) },
                    { 3, "Số 3, Đường 3, Phường 3, Quận 3, TP HCM", "avatar.jpg", 3, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8519), "Quận 3", "emp3@emp3", "EMP003", "Lê Văn Employee", "123", "12548897451", "700000", "TP HCM", 3, 1, "SubmitedInfo", new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8519) }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "CreatedAt", "LocationLevel", "LocationName", "LocationOf", "PostalCode", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8719), 1, "District 1", 1, "710000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8719) },
                    { 3, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8722), 1, "District 2", 1, "713000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8722) },
                    { 4, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8725), 1, "District 3", 1, "722700", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8725) },
                    { 5, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8727), 1, "District 4", 1, "754000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8728) },
                    { 6, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8733), 1, "District 5", 1, "749000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8733) },
                    { 7, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8735), 1, "District 6", 1, "746000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8736) },
                    { 8, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8738), 1, "District 7", 1, "756000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8739) },
                    { 9, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8741), 1, "District 8", 1, "751000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8741) },
                    { 10, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8743), 1, "District 9", 1, "715000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8744) },
                    { 11, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8746), 1, "District 10", 1, "740500", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8746) },
                    { 12, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8749), 1, "District 11", 1, "743000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8749) },
                    { 13, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8751), 1, "District 12", 1, "729110", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8752) },
                    { 14, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8754), 1, "Phu Nhuan", 1, "725000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8754) },
                    { 15, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8756), 1, "Binh Thanh", 1, "717000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8757) },
                    { 16, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8759), 1, "Tan Binh", 1, "736090", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8759) },
                    { 17, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8762), 1, "Binh Tan", 1, "762000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8762) },
                    { 18, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8764), 1, "Go Vap", 1, "727000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8765) },
                    { 19, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8767), 1, "Tan Phu", 1, "760000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8767) },
                    { 20, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8769), 1, "Thu Duc", 1, "721400", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8770) },
                    { 21, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8772), 1, "Binh Chanh", 1, "738000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8773) },
                    { 22, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8819), 1, "Can Gio", 1, "759000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8820) },
                    { 23, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8822), 1, "Hoc Mon", 1, "731000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8823) },
                    { 24, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8825), 1, "Cu Chi", 1, "733000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8826) },
                    { 25, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8828), 1, "Nha Be", 1, "758000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8828) },
                    { 60, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8921), 1, "Quan Ba Dinh", 59, "118000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8922) },
                    { 61, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8924), 1, "Quan Dong Da", 59, "115000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8924) },
                    { 62, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8926), 1, "Quan Hai Ba Trung", 59, "113000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8927) },
                    { 63, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8929), 1, "Quan Hoan Kiem", 59, "111000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8930) },
                    { 64, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8932), 1, "Quan Cau Giay", 59, "122000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8932) },
                    { 65, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8934), 1, "Quan Tay Ho", 59, "124000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8935) },
                    { 66, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8937), 1, "Quan Hoang Mai", 59, "128100", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8938) },
                    { 67, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8940), 1, "Quan Long Bien", 59, "120000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8940) },
                    { 68, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8942), 1, "Huyen Dong Anh", 59, "136000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8943) },
                    { 69, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8945), 1, "Quan Dong Anh", 59, "136000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8945) },
                    { 70, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8947), 1, "Quan Nam Tu Liem", 59, "130000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8948) },
                    { 71, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8950), 1, "Quan Tu Liem", 59, "129000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8951) },
                    { 72, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8953), 1, "Huyen Phuc Tho", 59, "153600", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8953) },
                    { 73, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8956), 1, "Quan Hoan Kiem", 59, "111000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8956) },
                    { 74, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8958), 1, "Huyen Soc Son", 59, "139000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8959) },
                    { 75, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8961), 1, "Huyen Thach That", 59, "1155300", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8962) },
                    { 76, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8964), 1, "Huyen Thanh Tri", 59, "134000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8964) },
                    { 77, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8966), 1, "Huyen Thuong Tin", 59, "158501", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8967) },
                    { 78, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8969), 1, "Thi Xa Son Tay", 59, "154000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8969) },
                    { 135, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9223), 1, "Thanh pho Thu Dau Mot", 134, "75100", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9224) },
                    { 136, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9226), 1, "Thanh pho Di An", 134, "75300", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9226) },
                    { 137, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9228), 1, "Thanh pho Thuan An", 134, "75200", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9229) },
                    { 138, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9231), 1, "Huyen Bau Bang", 134, "75700", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9231) },
                    { 139, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9233), 1, "Huyen Dau Tieng", 134, "75800", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9234) },
                    { 140, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9236), 1, "Huyen Bac Tan Uyen", 134, "75500", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9236) },
                    { 141, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9239), 1, "Thi xa Phu Giao", 134, "75600", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9239) },
                    { 142, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9241), 1, "Thi xa Ben Cat", 134, "75900", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9242) },
                    { 143, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9244), 1, "Thi xa Tan Uyen", 134, "75400", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9244) },
                    { 178, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9337), 1, "Thanh pho Tan An", 177, "851000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9338) },
                    { 179, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9376), 1, "Thi xa Kien Tuong", 177, "855600", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9377) },
                    { 180, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9379), 1, "Huyen Ben Luc", 177, "852340", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9380) },
                    { 181, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9382), 1, "Huyen Can Duoc", 177, "852700", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9383) },
                    { 182, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9385), 1, "Huyen Can Giuoc", 177, "853290", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9386) },
                    { 183, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9388), 1, "Huyen Chau Thanh", 177, "82200", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9389) },
                    { 184, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9391), 1, "Huyen Duc Hoa", 177, "853700", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9391) },
                    { 185, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9393), 1, "Huyen Duc Hue", 177, "854241", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9394) },
                    { 186, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9396), 1, "Huyen Moc Hoa", 177, "856000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9396) },
                    { 187, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9399), 1, "Huyen Tan Hung", 177, "854700", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9399) },
                    { 188, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9401), 1, "Huyen Tan Thanh", 177, "855100", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9402) },
                    { 189, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9404), 1, "Huyen Tan Tru", 177, "851500", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9404) },
                    { 190, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9406), 1, "Huyen Thanh Hoa", 177, "856400", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9407) },
                    { 191, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9409), 1, "Huyen Thu Thua", 177, "853900", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9410) },
                    { 192, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9412), 1, "Huyen Vinh Hung", 177, "856800", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9412) },
                    { 231, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9501), 1, "Thanh pho Da Lat", 230, "670000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9502) },
                    { 232, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9504), 1, "Thanh pho Bao Loc", 230, "671000", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9504) },
                    { 233, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9507), 1, "Huyen Bao Lam", 230, "672010", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9507) },
                    { 234, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9509), 1, "Huyen Cat Tien", 230, "672020", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9510) },
                    { 235, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9512), 1, "Huyen Di Linh", 230, "672030", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9512) },
                    { 236, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9514), 1, "Huyen Lam Ha", 230, "672040", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9515) },
                    { 237, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9517), 1, "Huyen Lac Duong", 230, "672050", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9518) },
                    { 238, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9520), 1, "Huyen Dam Rong", 230, "672060", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9520) },
                    { 239, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9522), 1, "Huyen Don Duong", 230, "672070", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9523) },
                    { 240, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9525), 1, "Huyen Da Huoai", 230, "672080", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9526) },
                    { 241, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9528), 1, "Huyen Da Teh", 230, "672090", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9528) },
                    { 242, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9530), 1, "Huyen Duc Trong", 230, "672100", 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9531) }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "CreatedAt", "ServiceTypeId", "Status", "UpdatedAt", "WeighFrom", "WeighTo" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 7, 19, 20, 8, 469, DateTimeKind.Local).AddTicks(45), 1, 1, new DateTime(2024, 3, 7, 19, 20, 8, 469, DateTimeKind.Local).AddTicks(45), 0, 500 },
                    { 2, new DateTime(2024, 3, 7, 19, 20, 8, 469, DateTimeKind.Local).AddTicks(47), 1, 1, new DateTime(2024, 3, 7, 19, 20, 8, 469, DateTimeKind.Local).AddTicks(48), 501, 1000 },
                    { 3, new DateTime(2024, 3, 7, 19, 20, 8, 469, DateTimeKind.Local).AddTicks(50), 1, 1, new DateTime(2024, 3, 7, 19, 20, 8, 469, DateTimeKind.Local).AddTicks(51), 1001, 2000 },
                    { 4, new DateTime(2024, 3, 7, 19, 20, 8, 469, DateTimeKind.Local).AddTicks(53), 1, 1, new DateTime(2024, 3, 7, 19, 20, 8, 469, DateTimeKind.Local).AddTicks(53), 2001, 3000 },
                    { 5, new DateTime(2024, 3, 7, 19, 20, 8, 469, DateTimeKind.Local).AddTicks(55), 1, 1, new DateTime(2024, 3, 7, 19, 20, 8, 469, DateTimeKind.Local).AddTicks(56), 3001, 10000 }
                });

            migrationBuilder.InsertData(
                table: "FeeCustoms",
                columns: new[] { "Id", "CreatedAt", "FeeCharge", "LocationIdFrom", "LocationIdTo", "OverWeightCharge", "ServiceId", "Status", "TimeProcess", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8564), 35000.00m, 2, 3, 2m, 1, 1, 2, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8565) },
                    { 2, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8568), 45000.00m, 2, 3, 3m, 2, 1, 4, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8568) },
                    { 3, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8571), 50000.00m, 2, 3, 4m, 3, 1, 5, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8571) },
                    { 4, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8574), 60000.00m, 2, 3, 5m, 1, 1, 24, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8574) }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "CreatedAt", "LocationLevel", "LocationName", "LocationOf", "PostalCode", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 26, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8831), 2, "Tan Đinh", 2, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8831) },
                    { 27, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8833), 2, "Da Kao", 2, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8834) },
                    { 28, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8836), 2, "Ben Nghe", 2, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8837) },
                    { 29, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8839), 2, "Ben Thanh", 2, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8839) },
                    { 30, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8841), 2, "Nguyen Thai Binh", 2, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8842) },
                    { 31, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8844), 2, "Pham Ngu Lao", 2, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8844) },
                    { 32, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8847), 2, "Cau Ong Lanh", 2, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8847) },
                    { 33, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8849), 2, "Co Giang", 2, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8850) },
                    { 34, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8852), 2, "Nguyen Cu Trinh", 2, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8853) },
                    { 35, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8855), 2, "Cau Kho", 2, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8855) },
                    { 36, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8858), 2, "Thanh My Loi", 3, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8858) },
                    { 37, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8860), 2, "An Khanh", 3, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8861) },
                    { 38, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8863), 2, "An Loi Dong", 3, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8863) },
                    { 39, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8866), 2, "Thao Dien", 3, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8866) },
                    { 40, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8868), 2, "Thu Thiem", 3, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8869) },
                    { 41, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8871), 2, "Binh An", 3, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8871) },
                    { 42, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8873), 2, "Binh Khanh", 3, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8874) },
                    { 43, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8876), 2, "Binh Trung Dong", 3, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8876) },
                    { 44, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8878), 2, "Binh Trung Tay", 3, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8879) },
                    { 45, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8881), 2, "Cat Lai", 3, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8882) },
                    { 46, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8884), 2, "Long Binh", 3, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8884) },
                    { 47, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8887), 2, "Phuong 1", 4, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8887) },
                    { 48, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8889), 2, "Phuong 2", 4, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8890) },
                    { 49, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8892), 2, "Phuong 3", 4, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8892) },
                    { 50, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8894), 2, "Phuong 4", 4, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8895) },
                    { 51, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8897), 2, "Phuong 5", 4, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8897) },
                    { 52, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8900), 2, "Phuong Vo Thi Sau", 4, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8900) },
                    { 53, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8902), 2, "Phuong 9", 4, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8903) },
                    { 54, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8905), 2, "Phuong 10", 4, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8905) },
                    { 55, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8908), 2, "Phuong 11", 4, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8908) },
                    { 56, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8910), 2, "Phuong 12", 4, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8911) },
                    { 57, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8913), 2, "Phuong 13", 4, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8913) },
                    { 58, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8915), 2, "Phuong 14", 4, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8916) },
                    { 79, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8972), 2, "Trúc Bạch", 60, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8972) },
                    { 80, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8974), 2, "Kim Mã", 60, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8975) },
                    { 81, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8977), 2, "Đội Cấn", 60, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8978) },
                    { 82, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8980), 2, "Cống Vị", 60, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8980) },
                    { 83, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8983), 2, "Giảng Võ", 60, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8983) },
                    { 84, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8985), 2, "Liễu Giai", 60, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8986) },
                    { 85, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8988), 2, "Ngọc Hà", 60, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8988) },
                    { 86, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8991), 2, "Thành Công", 60, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8991) },
                    { 87, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8993), 2, "Ngọc Khánh", 60, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8994) },
                    { 88, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8996), 2, "Vĩnh Phúc", 60, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8996) },
                    { 89, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8998), 2, "Nguyễn Trung Trực", 60, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8999) },
                    { 90, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9001), 2, "Phúc Xá", 60, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9002) },
                    { 91, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9004), 2, "Điện Biên", 60, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9004) },
                    { 92, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9006), 2, "Quán Thánh", 60, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9007) },
                    { 93, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9009), 2, "Quang Trung", 61, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9009) },
                    { 94, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9012), 2, "Hang Bot", 61, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9012) },
                    { 95, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9014), 2, "Phuong Lien", 61, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9015) },
                    { 96, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9017), 2, "Khuong Thuong", 61, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9017) },
                    { 97, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9019), 2, "Thinh Quang", 61, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9020) },
                    { 98, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9022), 2, "Kim Lien", 61, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9023) },
                    { 99, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9025), 2, "Lang Ha", 61, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9025) },
                    { 100, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9027), 2, "Lang Thuong", 61, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9028) },
                    { 101, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9133), 2, "Cat Linh", 61, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9134) },
                    { 102, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9136), 2, "Nam Dong", 61, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9137) },
                    { 103, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9139), 2, "O Cho Dua", 61, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9139) },
                    { 104, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9141), 2, "Trung Tu", 61, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9142) },
                    { 105, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9144), 2, "Van Mieu", 61, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9144) },
                    { 106, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9147), 2, "Van Chuong", 61, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9147) },
                    { 107, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9149), 2, "Trung Phung", 61, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9150) },
                    { 108, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9152), 2, "Quoc Tu Giam", 61, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9153) },
                    { 109, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9155), 2, "Nguyen Trai", 61, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9155) },
                    { 110, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9157), 2, "Tho Quan", 61, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9158) },
                    { 111, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9160), 2, "Phuong Mai", 61, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9161) },
                    { 112, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9163), 2, "Kham Thien", 61, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9163) },
                    { 113, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9165), 2, "Trung Liet", 61, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9166) },
                    { 114, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9168), 2, "Bach Dang", 62, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9169) },
                    { 115, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9171), 2, "Bach Khoa", 62, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9171) },
                    { 116, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9173), 2, "Bach Mai", 62, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9174) },
                    { 117, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9176), 2, "Bui Thi Xuan", 62, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9177) },
                    { 118, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9179), 2, "Cau Den", 62, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9179) },
                    { 119, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9181), 2, "Dong Mac", 62, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9182) },
                    { 120, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9184), 2, "Dong Nhan", 62, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9184) },
                    { 121, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9187), 2, "Dong Tam", 62, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9187) },
                    { 122, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9189), 2, "Le Dai Hanh", 62, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9190) },
                    { 123, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9192), 2, "Minh Khai", 62, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9192) },
                    { 124, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9194), 2, "Ngo Thi Nham", 62, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9195) },
                    { 125, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9197), 2, "Nguyen Du", 62, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9197) },
                    { 126, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9200), 2, "Pham Dinh Ho", 62, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9200) },
                    { 127, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9202), 2, "Pho Hue", 62, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9203) },
                    { 128, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9205), 2, "Quynh Loi", 62, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9205) },
                    { 129, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9207), 2, "Quynh Mai", 62, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9208) },
                    { 130, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9210), 2, "Thanh Luong", 62, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9211) },
                    { 131, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9213), 2, "Thanh Nhan", 62, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9213) },
                    { 132, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9215), 2, "Truong Dinh", 62, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9216) },
                    { 133, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9218), 2, "Vinh Tuy", 62, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9218) },
                    { 144, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9247), 2, "Chanh My", 135, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9247) },
                    { 145, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9249), 2, "Chanh Nghia", 135, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9250) },
                    { 146, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9252), 2, "Dinh Hoa", 135, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9253) },
                    { 147, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9255), 2, "Hiep An", 135, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9255) },
                    { 148, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9257), 2, "Hiep Thanh", 135, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9258) },
                    { 149, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9260), 2, "Hoa Phu", 135, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9260) },
                    { 150, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9263), 2, "Phu Cuong", 135, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9263) },
                    { 151, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9265), 2, "Phu Hoa", 135, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9266) },
                    { 152, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9268), 2, "Phu Loi", 135, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9268) },
                    { 153, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9271), 2, "Phu My", 135, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9271) },
                    { 154, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9273), 2, "Phu Tan", 135, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9274) },
                    { 155, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9276), 2, "Phu Tho", 135, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9276) },
                    { 156, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9279), 2, "Tan An", 135, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9279) },
                    { 157, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9282), 2, "Tuong Binh Hiep", 135, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9282) },
                    { 158, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9285), 2, "Binh Minh 1", 136, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9285) },
                    { 159, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9288), 2, "Binh Minh 2", 136, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9288) },
                    { 160, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9290), 2, "Dong Tan", 136, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9291) },
                    { 161, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9293), 2, "Nhi Dong 1", 136, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9293) },
                    { 162, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9295), 2, "Nhi Dong 2", 136, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9296) },
                    { 163, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9298), 2, "Thang Loi 1", 136, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9298) },
                    { 164, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9301), 2, "Thang Loi 2", 136, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9301) },
                    { 165, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9303), 2, "Thong Nhat 1", 136, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9304) },
                    { 166, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9306), 2, "Thong Nhat 2", 136, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9306) },
                    { 167, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9308), 2, "An Phu", 137, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9309) },
                    { 168, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9311), 2, "An Thanh", 137, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9312) },
                    { 169, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9314), 2, "Binh Chuan", 137, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9314) },
                    { 170, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9316), 2, "Binh Hoa", 137, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9317) },
                    { 171, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9319), 2, "Binh Nham", 137, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9319) },
                    { 172, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9321), 2, "Hung Dinh", 137, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9322) },
                    { 173, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9324), 2, "Lai Thieu", 137, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9325) },
                    { 174, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9327), 2, "Thuan Giao", 137, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9327) },
                    { 175, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9329), 2, "Vinh Phu", 137, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9330) },
                    { 176, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9332), 2, "An Son", 137, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9332) },
                    { 193, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9414), 2, "Phuong 1", 178, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9415) },
                    { 194, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9417), 2, "Phuong 2", 178, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9417) },
                    { 200, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9420), 2, "Khanh Hau", 178, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9420) },
                    { 201, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9422), 2, "Tan Khanh", 178, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9423) },
                    { 202, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9425), 2, "Binh Tam", 178, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9425) },
                    { 203, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9427), 2, "Loi Binh Nhon", 178, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9428) },
                    { 204, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9430), 2, "An Vinh Ngai", 178, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9431) },
                    { 205, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9433), 2, "Huong Tho Phu", 178, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9433) },
                    { 206, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9435), 2, "Nhon Thanh Trung", 178, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9436) },
                    { 207, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9438), 2, "Phuong 1", 179, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9439) },
                    { 208, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9441), 2, "Phuong 2", 179, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9441) },
                    { 209, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9443), 2, "Phuong 3", 179, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9444) },
                    { 210, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9446), 2, "Binh Hiep", 179, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9447) },
                    { 211, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9449), 2, "Binh Tan", 179, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9449) },
                    { 212, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9451), 2, "Thanh Hung", 179, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9452) },
                    { 213, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9454), 2, "Thanh Tri", 179, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9454) },
                    { 214, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9457), 2, "Tuyen Thanh", 179, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9457) },
                    { 215, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9459), 2, "Thi tran Ben Luc", 180, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9460) },
                    { 216, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9462), 2, "An Thanh", 180, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9462) },
                    { 217, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9464), 2, "Binh Duc", 180, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9465) },
                    { 218, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9467), 2, "Long Hiep", 180, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9467) },
                    { 219, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9470), 2, "Luong Binh", 180, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9470) },
                    { 220, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9472), 2, "Luong Hoa", 180, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9473) },
                    { 221, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9475), 2, "My Yen", 180, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9475) },
                    { 222, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9478), 2, "Nhut Chanh", 180, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9478) },
                    { 223, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9480), 2, "Phuoc Loi", 180, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9481) },
                    { 224, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9483), 2, "Tan Buu", 180, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9483) },
                    { 225, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9486), 2, "Tan Hoa", 180, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9486) },
                    { 226, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9488), 2, "Thanh Duc", 180, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9489) },
                    { 227, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9491), 2, "Thanh Hoa", 180, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9491) },
                    { 228, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9494), 2, "Thanh Loi", 180, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9494) },
                    { 229, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9496), 2, "Thanh Phu", 180, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9497) },
                    { 243, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9533), 2, "Phuong 1", 231, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9534) },
                    { 244, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9536), 2, "Phuong 2", 231, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9536) },
                    { 245, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9538), 2, "Phuong 3", 231, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9539) },
                    { 246, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9541), 2, "Phuong 4", 231, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9541) },
                    { 247, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9543), 2, "Phuong 5", 231, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9544) },
                    { 248, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9546), 2, "Phuong 6", 231, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9547) },
                    { 249, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9549), 2, "Phuong 7", 231, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9549) },
                    { 250, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9551), 2, "Phuong 8", 231, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9552) },
                    { 251, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9554), 2, "Phuong 9", 231, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9554) },
                    { 252, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9557), 2, "Phuong 10", 231, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9557) },
                    { 253, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9559), 2, "Phuong 11", 231, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9560) },
                    { 254, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9562), 2, "Phuong 12", 231, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9562) },
                    { 255, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9564), 2, "Ta Nung", 231, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9565) },
                    { 256, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9567), 2, "Tram Hanh", 231, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9568) },
                    { 257, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9570), 2, "Xuan Tho", 231, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9570) },
                    { 258, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9572), 2, "Xuan Truong", 231, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9573) },
                    { 259, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9575), 2, "B'Lao", 232, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9576) },
                    { 260, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9578), 2, "Phuong 1", 232, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9578) },
                    { 261, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9580), 2, "Phuong 2", 232, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9581) },
                    { 262, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9583), 2, "Loc Phat", 232, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9583) },
                    { 263, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9620), 2, "Loc Tien", 232, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9620) },
                    { 264, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9623), 2, "Loc Son", 232, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9623) },
                    { 265, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9625), 2, "Loc Nga", 232, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9626) },
                    { 266, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9628), 2, "Loc Chau", 232, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9628) },
                    { 267, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9631), 2, "Dam Bri", 232, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9631) },
                    { 268, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9633), 2, "Loc Thanh", 232, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9634) },
                    { 269, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9636), 2, "Dai Lao", 232, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9636) },
                    { 270, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9638), 2, "Loc Thang", 233, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9639) },
                    { 271, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9641), 2, "B'La", 233, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9642) },
                    { 272, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9644), 2, "Loc An", 233, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9644) },
                    { 273, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9646), 2, "Loc Bac", 233, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9647) },
                    { 274, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9649), 2, "Loc Bao", 233, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9650) },
                    { 275, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9652), 2, "Loc Duc", 233, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9653) },
                    { 276, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9655), 2, "Loc Lam", 233, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9655) },
                    { 277, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9657), 2, "Loc Nam", 233, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9658) },
                    { 278, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9660), 2, "Loc Ngai", 233, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9660) },
                    { 279, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9663), 2, "Loc Phu", 233, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9663) },
                    { 280, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9668), 2, "Loc Quang", 233, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9669) },
                    { 281, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9671), 2, "Loc Tan", 233, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9671) },
                    { 282, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9673), 2, "Loc Thanh", 233, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9674) },
                    { 283, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9676), 2, "Tan Lac", 233, null, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9676) }
                });

            migrationBuilder.InsertData(
                table: "Packages",
                columns: new[] { "Id", "AddressFrom", "AddressTo", "CreatedAt", "NameFrom", "NameTo", "PackageNote", "PackageSize", "PostalCodeFrom", "PostalCodeTo", "ServiceId", "Status", "Step", "TotalFee", "TrackingCode", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, "Số 1, Đường 1, Phường 1, Quận 1, TP HCM", "Số 2, Đường 2, Phường 2, Quận 2, TP HCM", new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9900), "Nguyễn Văn A", "Trần Thị B", "Giao hàng cẩn thận", null, "700000", "700000", 1, 1, 0, 100000m, "123456789", new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9900), 1 },
                    { 2, "Số 2, Đường 2, Phường 2, Quận 2, TP HCM", "Số 3, Đường 3, Phường 3, Quận 3, TP HCM", new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9904), "Trần Thị B", "Lê Văn C", "Giao hàng cẩn thận", null, "700000", "700000", 1, 1, 0, 100000m, "987654321", new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(9904), 2 }
                });

            migrationBuilder.InsertData(
                table: "HistoryLogs",
                columns: new[] { "Id", "CreatedAt", "EmployeeId", "EmployeeIdNextStep", "HistoryNote", "PackageId", "Photos", "ProcessStep", "Status", "Step", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8611), 1, 2, "Đang chờ lấy hàng", 1, "https://tars.com/photos/1", 0, 1, 0, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8612) },
                    { 2, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8615), 2, 3, "Đang chờ lấy hàng", 2, "https://tars.com/photos/2", 0, 1, 0, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8615) }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "ItemName", "ItemQuantity", "ItemType", "ItemValue", "ItemWeight", "PackageId", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8657), "Quần áo", 5, 0, 1000000m, 2, 1, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8657) },
                    { 2, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8660), "Giày dép", 3, 1, 500000m, 1, 2, 1, new DateTime(2024, 3, 7, 19, 20, 8, 468, DateTimeKind.Local).AddTicks(8660) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserId",
                table: "Customers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_BranchId",
                table: "Employees",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeCode",
                table: "Employees",
                column: "EmployeeCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_RoleId",
                table: "Employees",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_FeeCustoms_LocationIdFrom",
                table: "FeeCustoms",
                column: "LocationIdFrom");

            migrationBuilder.CreateIndex(
                name: "IX_FeeCustoms_LocationIdTo",
                table: "FeeCustoms",
                column: "LocationIdTo");

            migrationBuilder.CreateIndex(
                name: "IX_FeeCustoms_ServiceId",
                table: "FeeCustoms",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryLogs_EmployeeId",
                table: "HistoryLogs",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryLogs_EmployeeIdNextStep",
                table: "HistoryLogs",
                column: "EmployeeIdNextStep");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryLogs_PackageId",
                table: "HistoryLogs",
                column: "PackageId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_PackageId",
                table: "Items",
                column: "PackageId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_LocationOf",
                table: "Locations",
                column: "LocationOf");

            migrationBuilder.CreateIndex(
                name: "IX_Packages_ServiceId",
                table: "Packages",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Packages_TrackingCode",
                table: "Packages",
                column: "TrackingCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Packages_UserId",
                table: "Packages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleHasPermissions_PermissionId",
                table: "RoleHasPermissions",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleHasPermissions_RoleId1",
                table: "RoleHasPermissions",
                column: "RoleId1");

            migrationBuilder.CreateIndex(
                name: "IX_Services_ServiceTypeId",
                table: "Services",
                column: "ServiceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Phone",
                table: "Users",
                column: "Phone",
                unique: true,
                filter: "[Phone] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "FeeCustoms");

            migrationBuilder.DropTable(
                name: "GeneralSettings");

            migrationBuilder.DropTable(
                name: "HistoryLogs");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "RoleHasPermissions");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Packages");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ServiceTypes");
        }
    }
}
