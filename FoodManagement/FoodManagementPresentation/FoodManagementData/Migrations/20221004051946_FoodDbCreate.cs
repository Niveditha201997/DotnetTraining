using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodManagementData.Migrations
{
    public partial class FoodDbCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admins",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminPassword = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admins", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "foodCategories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_foodCategories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "foodItems",
                columns: table => new
                {
                    SINo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    foodCategoryCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_foodItems", x => x.SINo);
                    table.ForeignKey(
                        name: "FK_foodItems_foodCategories_foodCategoryCategoryId",
                        column: x => x.foodCategoryCategoryId,
                        principalTable: "foodCategories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "foodSales",
                columns: table => new
                {
                    SalesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    foodCategoryCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_foodSales", x => x.SalesId);
                    table.ForeignKey(
                        name: "FK_foodSales_foodCategories_foodCategoryCategoryId",
                        column: x => x.foodCategoryCategoryId,
                        principalTable: "foodCategories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_foodItems_foodCategoryCategoryId",
                table: "foodItems",
                column: "foodCategoryCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_foodSales_foodCategoryCategoryId",
                table: "foodSales",
                column: "foodCategoryCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admins");

            migrationBuilder.DropTable(
                name: "foodItems");

            migrationBuilder.DropTable(
                name: "foodSales");

            migrationBuilder.DropTable(
                name: "foodCategories");
        }
    }
}
