using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TARS_Delivery.Migrations
{
    /// <inheritdoc />
    public partial class Step1 : Migration
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
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeighFrom = table.Column<int>(type: "int", nullable: false),
                    WeighTo = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
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
                name: "FeeCustoms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    LocationIdFrom = table.Column<int>(type: "int", nullable: false),
                    LocationIdTo = table.Column<int>(type: "int", nullable: false),
                    Distance = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
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
                    { 1, "1234 TARS Street", "TARS Delivery", new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8306), "TARS", "123456789", "1234", "TARS", 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8321) },
                    { 2, "1234 TARS Street", "TARS Delivery 2", new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8326), "TARS", "123456789", "1234", "TARS", 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8326) },
                    { 3, "1234 TARS Street", "TARS Delivery 3", new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8328), "TARS", "123456789", "1234", "TARS", 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8328) }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "CreatedAt", "LocationLevel", "LocationName", "LocationOf", "PostalCode", "Status", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8613), 0, "TP HCM", null, "700000", 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8614) });

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
                table: "Services",
                columns: new[] { "Id", "CreatedAt", "ServiceDescription", "ServiceName", "Status", "UpdatedAt", "WeighFrom", "WeighTo" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8839), "Fast and secure international delivery service", "EMS Delivery Service", 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8839), 0, 500 },
                    { 2, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8841), "Fast and secure international delivery service", "EMS Delivery Service", 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8842), 501, 1000 },
                    { 3, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8844), "Fast and secure international delivery service", "EMS Delivery Service", 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8844), 1001, 2000 },
                    { 4, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8846), "Fast and convenient express delivery service", "Express Delivery", 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8847), 2001, 3000 },
                    { 5, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8849), "Reliable freight and cargo delivery solutions", "Freight Delivery Services", 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8849), 3001, 10000 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Avatar", "CreatedAt", "Email", "Fullname", "Password", "Phone", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "avatar.jpg", new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8811), "usera@usera", "Nguyễn Văn User", "123", "0123456789", 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8812) },
                    { 2, "avatar.jpg", new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8814), "userb@userb", "Trần Thị User", "123", "0987654321", 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8815) },
                    { 3, "avatar.jpg", new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8817), "userc@userc", "Lê Văn User", "123", "023023920392", 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8818) }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "CreatedAt", "District", "Name", "PhoneNumber", "Province", "Status", "TypeInfo", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, "Số 1, Đường 1, Phường 1, Quận 1, TP HCM", new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8448), "Quận 1", "Nguyễn Văn Customer", "0123456789", "TP HCM", 1, 0, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8449), 1 },
                    { 2, "Số 2, Đường 2, Phường 2, Quận 2, TP HCM", new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8452), "Quận 2", "Trần Thị Customer", "0987654321", "TP HCM", 1, 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8453), 2 },
                    { 3, "Số 3, Đường 3, Phường 3, Quận 3, TP HCM", new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8455), "Quận 3", "Lê Văn Customer", "044333333", "TP HCM", 1, 0, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8455), 3 }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Avatar", "BranchId", "CreatedAt", "District", "Email", "EmployeeCode", "Fullname", "Password", "PhoneNumber", "PostalCode", "Province", "RoleId", "Status", "SubmitedInfo", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Số 1, Đường 1, Phường 1, Quận 1, TP HCM", "avatar.jpg", 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8484), "Quận 1", "emp1@emp1", "EMP001", "Nguyễn Văn Employee", "123", "0123456789", "700000", "TP HCM", 1, 1, "SubmitedInfo", new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8485) },
                    { 2, "Số 2, Đường 2, Phường 2, Quận 2, TP HCM", "avatar.jpg", 2, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8489), "Quận 2", "emp2@emp2", "EMP002", "Trần Thị Employee", "123", "0987654321", "700000", "TP HCM", 2, 1, "SubmitedInfo", new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8490) },
                    { 3, "Số 3, Đường 3, Phường 3, Quận 3, TP HCM", "avatar.jpg", 3, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8493), "Quận 3", "emp3@emp3", "EMP003", "Lê Văn Employee", "123", "12548897451", "700000", "TP HCM", 3, 1, "SubmitedInfo", new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8493) }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "CreatedAt", "LocationLevel", "LocationName", "LocationOf", "PostalCode", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8618), 1, "Quận 1", 1, "710100", 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8619) },
                    { 3, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8621), 1, "Quận 2", 1, "713000", 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8621) },
                    { 4, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8623), 1, "Quận 3", 1, "722000", 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8624) },
                    { 5, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8626), 1, "Quận 4", 1, "754000", 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8627) },
                    { 6, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8659), 1, "Quận 5", 1, "748000", 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8659) },
                    { 7, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8662), 1, "Quận 6", 1, "746000", 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8662) },
                    { 8, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8664), 1, "Quận 7", 1, "756000", 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8666) },
                    { 9, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8668), 1, "Quận 8", 1, "751500", 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8669) },
                    { 10, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8671), 1, "Quận 9", 1, "715000", 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8672) },
                    { 11, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8674), 1, "Quận 10", 1, "740010", 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8674) },
                    { 12, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8676), 1, "Quận 11", 1, "743800", 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8677) },
                    { 13, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8679), 1, "Quận 12", 1, "729400", 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8679) },
                    { 14, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8681), 1, "Quận Gò Vấp", 1, "727010", 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8682) },
                    { 15, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8684), 1, "Quận Tân Bình", 1, "736090", 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8685) },
                    { 16, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8687), 1, "Quận Tân Phú", 1, "760000", 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8688) },
                    { 17, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8690), 1, "Quận Phú Nhuận", 1, "725060", 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8691) },
                    { 18, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8693), 1, "Quận Bình Thạnh", 1, "718440", 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8694) },
                    { 19, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8696), 1, "Quận Thủ Đức", 1, "720150", 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8696) }
                });

            migrationBuilder.InsertData(
                table: "Packages",
                columns: new[] { "Id", "AddressFrom", "AddressTo", "CreatedAt", "NameFrom", "NameTo", "PackageNote", "PackageSize", "PostalCodeFrom", "PostalCodeTo", "ServiceId", "Status", "Step", "TotalFee", "TrackingCode", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, "Số 1, Đường 1, Phường 1, Quận 1, TP HCM", "Số 2, Đường 2, Phường 2, Quận 2, TP HCM", new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8738), "Nguyễn Văn A", "Trần Thị B", "Giao hàng cẩn thận", null, "700000", "700000", 1, 1, 0, 100000m, "123456789", new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8739), 1 },
                    { 2, "Số 2, Đường 2, Phường 2, Quận 2, TP HCM", "Số 3, Đường 3, Phường 3, Quận 3, TP HCM", new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8743), "Trần Thị B", "Lê Văn C", "Giao hàng cẩn thận", null, "700000", "700000", 1, 1, 0, 100000m, "987654321", new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8744), 2 }
                });

            migrationBuilder.InsertData(
                table: "FeeCustoms",
                columns: new[] { "Id", "CreatedAt", "Distance", "FeeCharge", "LocationIdFrom", "LocationIdTo", "ServiceId", "Status", "TimeProcess", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8519), 15.5m, 35000.00m, 2, 3, 1, 1, 2, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8520) },
                    { 2, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8523), 25.0m, 45000.00m, 2, 3, 2, 1, 4, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8523) },
                    { 3, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8526), 30.0m, 50000.00m, 2, 3, 3, 1, 5, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8526) },
                    { 4, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8528), 15.0m, 60000.00m, 2, 3, 1, 1, 24, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8529) }
                });

            migrationBuilder.InsertData(
                table: "HistoryLogs",
                columns: new[] { "Id", "CreatedAt", "EmployeeId", "EmployeeIdNextStep", "HistoryNote", "PackageId", "Photos", "ProcessStep", "Status", "Step", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8555), 1, 2, "Đang chờ lấy hàng", 1, "https://tars.com/photos/1", 0, 1, 0, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8557) },
                    { 2, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8559), 2, 3, "Đang chờ lấy hàng", 2, "https://tars.com/photos/2", 0, 1, 0, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8560) }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "ItemName", "ItemQuantity", "ItemType", "ItemValue", "ItemWeight", "PackageId", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8587), "Quần áo", 5, 0, 1000000m, 2, 1, 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8587) },
                    { 2, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8590), "Giày dép", 3, 1, 500000m, 1, 2, 1, new DateTime(2024, 2, 23, 20, 17, 55, 843, DateTimeKind.Local).AddTicks(8591) }
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
        }
    }
}
