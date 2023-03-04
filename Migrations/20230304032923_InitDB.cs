using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_SignalR.Migrations
{
    public partial class InitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockQty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Category", "ProdName", "StockQty", "UnitPrice" },
                values: new object[] { 1, "Caterory", "Name1", 100, "bag" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Category", "ProdName", "StockQty", "UnitPrice" },
                values: new object[] { 2, "Caterory", "Name2", 100, "bag" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Category", "ProdName", "StockQty", "UnitPrice" },
                values: new object[] { 3, "Caterory", "Name3", 100, "bag" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
