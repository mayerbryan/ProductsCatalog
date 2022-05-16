using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductsCatalog.Migrations
{
    public partial class SKUImplementation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SKU",
                table: "Product",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SKU",
                table: "Product");
        }
    }
}
