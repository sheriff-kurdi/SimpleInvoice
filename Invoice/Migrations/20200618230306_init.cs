using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleInvoice.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Date = table.Column<string>(nullable: true),
                    ItemName = table.Column<string>(nullable: false),
                    UnitName = table.Column<string>(nullable: false),
                    ItemPrice = table.Column<double>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Discount = table.Column<double>(nullable: false),
                    Total = table.Column<double>(nullable: false),
                    Taxes = table.Column<double>(nullable: false),
                    Net = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invoices");
        }
    }
}
