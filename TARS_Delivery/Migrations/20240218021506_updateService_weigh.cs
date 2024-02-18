using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TARS_Delivery.Migrations
{
    /// <inheritdoc />
    public partial class updateService_weigh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TypeService",
                table: "Services",
                newName: "WeighTo");

            migrationBuilder.AddColumn<int>(
                name: "WeighFrom",
                table: "Services",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WeighFrom",
                table: "Services");

            migrationBuilder.RenameColumn(
                name: "WeighTo",
                table: "Services",
                newName: "TypeService");
        }
    }
}
