using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pizza.Migrations
{
    public partial class Orders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PizzaCartItem_Food_foodId",
                table: "PizzaCartItem");

            migrationBuilder.RenameColumn(
                name: "foodId",
                table: "PizzaCartItem",
                newName: "foodid");

            migrationBuilder.RenameIndex(
                name: "IX_PizzaCartItem_foodId",
                table: "PizzaCartItem",
                newName: "IX_PizzaCartItem_foodid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Food",
                newName: "id");

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    surname = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    orderTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    orderID = table.Column<int>(nullable: false),
                    pizzaID = table.Column<int>(nullable: false),
                    price = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order_orderID",
                        column: x => x.orderID,
                        principalTable: "Order",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Food_pizzaID",
                        column: x => x.pizzaID,
                        principalTable: "Food",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_orderID",
                table: "OrderDetail",
                column: "orderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_pizzaID",
                table: "OrderDetail",
                column: "pizzaID");

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaCartItem_Food_foodid",
                table: "PizzaCartItem",
                column: "foodid",
                principalTable: "Food",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PizzaCartItem_Food_foodid",
                table: "PizzaCartItem");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.RenameColumn(
                name: "foodid",
                table: "PizzaCartItem",
                newName: "foodId");

            migrationBuilder.RenameIndex(
                name: "IX_PizzaCartItem_foodid",
                table: "PizzaCartItem",
                newName: "IX_PizzaCartItem_foodId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Food",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaCartItem_Food_foodId",
                table: "PizzaCartItem",
                column: "foodId",
                principalTable: "Food",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
