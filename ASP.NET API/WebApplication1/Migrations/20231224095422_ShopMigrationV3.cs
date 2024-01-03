using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class ShopMigrationV3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StockNum",
                table: "Mouses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Monitors_MonitorType",
                table: "Monitors",
                column: "MonitorType");

            migrationBuilder.AddForeignKey(
                name: "FK_Monitors_MonitorTypes_MonitorType",
                table: "Monitors",
                column: "MonitorType",
                principalTable: "MonitorTypes",
                principalColumn: "MonitorTypeID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Monitors_MonitorTypes_MonitorType",
                table: "Monitors");

            migrationBuilder.DropIndex(
                name: "IX_Monitors_MonitorType",
                table: "Monitors");

            migrationBuilder.DropColumn(
                name: "StockNum",
                table: "Mouses");
        }
    }
}
