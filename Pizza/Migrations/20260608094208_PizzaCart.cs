using Microsoft.EntityFrameworkCore.Migrations;

namespace Pizza.Migrations
{
    public partial class PizzaCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PizzaCartItem",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    foodId = table.Column<int>(nullable: true),
                    price = table.Column<int>(nullable: false),
                    PizzaCartId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaCartItem", x => x.id);
                    table.ForeignKey(
                        name: "FK_PizzaCartItem_Food_foodId",
                        column: x => x.foodId,
                        principalTable: "Food",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PizzaCartItem_foodId",
                table: "PizzaCartItem",
                column: "foodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PizzaCartItem");
        }
    }
}
