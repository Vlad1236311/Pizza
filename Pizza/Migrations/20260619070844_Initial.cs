using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pizza.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryName = table.Column<string>(nullable: true),
                    desc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    phone = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    latitude = table.Column<double>(nullable: false),
                    longitude = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(maxLength: 10, nullable: false),
                    surname = table.Column<string>(maxLength: 15, nullable: false),
                    phone = table.Column<string>(maxLength: 15, nullable: false),
                    email = table.Column<string>(maxLength: 30, nullable: false),
                    city = table.Column<string>(maxLength: 20, nullable: true),
                    street = table.Column<string>(maxLength: 30, nullable: true),
                    house = table.Column<string>(maxLength: 10, nullable: true),
                    entrance = table.Column<string>(maxLength: 10, nullable: true),
                    floor = table.Column<string>(maxLength: 10, nullable: true),
                    flat = table.Column<string>(maxLength: 10, nullable: true),
                    deliveryTime = table.Column<string>(nullable: true),
                    paymentMethod = table.Column<string>(nullable: true),
                    comment = table.Column<string>(nullable: true),
                    callMe = table.Column<bool>(nullable: false),
                    cashChange = table.Column<decimal>(nullable: false),
                    orderTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Food",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    shortDesc = table.Column<string>(nullable: true),
                    longDesc = table.Column<string>(nullable: true),
                    img = table.Column<string>(nullable: true),
                    price = table.Column<int>(nullable: false),
                    isFavourite = table.Column<bool>(nullable: false),
                    available = table.Column<bool>(nullable: false),
                    categoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food", x => x.id);
                    table.ForeignKey(
                        name: "FK_Food_Category_categoryID",
                        column: x => x.categoryID,
                        principalTable: "Category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    orderId = table.Column<int>(nullable: false),
                    foodId = table.Column<int>(nullable: false),
                    price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Food_foodId",
                        column: x => x.foodId,
                        principalTable: "Food",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order_orderId",
                        column: x => x.orderId,
                        principalTable: "Order",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PizzaCartItem",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    foodid = table.Column<int>(nullable: true),
                    PizzaCartId = table.Column<string>(nullable: true),
                    quantity = table.Column<int>(nullable: false),
                    price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaCartItem", x => x.id);
                    table.ForeignKey(
                        name: "FK_PizzaCartItem_Food_foodid",
                        column: x => x.foodid,
                        principalTable: "Food",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "Login", "PasswordHash" },
                values: new object[] { 1, "admin", "AQAAAAEAACcQAAAAECB9Qxcbkfc5xwVi8mn0HtLcgv3PtGSVM6yulf68RxjQUb47FI+LB0cd+0KfdR4yRQ==" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "id", "address", "email", "latitude", "longitude", "phone" },
                values: new object[] { 1, "Kyiv, Ukraine", "prijmakvlad7@gmail.com", 50.450099999999999, 30.523399999999999, "+380933613299" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "id", "address", "email", "latitude", "longitude", "phone" },
                values: new object[] { 2, "Kyiv, Ukraine", "andreyzet08a@icloud.com", 50.450099999999999, 30.523399999999999, "+380970494450" });

            migrationBuilder.CreateIndex(
                name: "IX_Food_categoryID",
                table: "Food",
                column: "categoryID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_foodId",
                table: "OrderDetail",
                column: "foodId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_orderId",
                table: "OrderDetail",
                column: "orderId");

            migrationBuilder.CreateIndex(
                name: "IX_PizzaCartItem_foodid",
                table: "PizzaCartItem",
                column: "foodid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "PizzaCartItem");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Food");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
