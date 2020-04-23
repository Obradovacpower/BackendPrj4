using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VareDatabase.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: false),
                    Title = table.Column<string>(maxLength: 120, nullable: false),
                    BuyOutPrice = table.Column<int>(nullable: false),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UserIdSeller = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "Bid",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bid = table.Column<int>(nullable: false),
                    UserIdBuyer = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bid", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bid_Item_Bid",
                        column: x => x.Bid,
                        principalTable: "Item",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Description",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageOfItem = table.Column<string>(nullable: false),
                    DescriptionOfItem = table.Column<string>(maxLength: 300, nullable: false),
                    ItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Description", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Description_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bid_Bid",
                table: "Bid",
                column: "Bid");

            migrationBuilder.CreateIndex(
                name: "IX_Description_ItemId",
                table: "Description",
                column: "ItemId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bid");

            migrationBuilder.DropTable(
                name: "Description");

            migrationBuilder.DropTable(
                name: "Item");
        }
    }
}
