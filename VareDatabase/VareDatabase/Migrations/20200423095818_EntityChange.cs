using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VareDatabase.Migrations
{
    public partial class EntityChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bid_Item_ItemId",
                table: "Bid");

            migrationBuilder.DropTable(
                name: "Time");

            migrationBuilder.DropIndex(
                name: "IX_Bid_ItemId",
                table: "Bid");

            migrationBuilder.DropColumn(
                name: "title",
                table: "Description");

            migrationBuilder.DropColumn(
                name: "UserId_forLastBid",
                table: "Bid");

            migrationBuilder.DropColumn(
                name: "UserId_forSeller",
                table: "Bid");

            migrationBuilder.DropColumn(
                name: "price",
                table: "Bid");

            migrationBuilder.RenameColumn(
                name: "imageOfItem",
                table: "Description",
                newName: "ImageOfItem");

            migrationBuilder.RenameColumn(
                name: "descriptionOfItem",
                table: "Description",
                newName: "DescriptionOfItem");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Item",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BuyOutPrice",
                table: "Item",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Item",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpirationDate",
                table: "Item",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Item",
                maxLength: 120,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UserIdSeller",
                table: "Item",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "ImageOfItem",
                table: "Description",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DescriptionOfItem",
                table: "Description",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Bid",
                table: "Bid",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserIdBuyer",
                table: "Bid",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Bid_Bid",
                table: "Bid",
                column: "Bid");

            migrationBuilder.AddForeignKey(
                name: "FK_Bid_Item_Bid",
                table: "Bid",
                column: "Bid",
                principalTable: "Item",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bid_Item_Bid",
                table: "Bid");

            migrationBuilder.DropIndex(
                name: "IX_Bid_Bid",
                table: "Bid");

            migrationBuilder.DropColumn(
                name: "BuyOutPrice",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "ExpirationDate",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "UserIdSeller",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Bid",
                table: "Bid");

            migrationBuilder.DropColumn(
                name: "UserIdBuyer",
                table: "Bid");

            migrationBuilder.RenameColumn(
                name: "ImageOfItem",
                table: "Description",
                newName: "imageOfItem");

            migrationBuilder.RenameColumn(
                name: "DescriptionOfItem",
                table: "Description",
                newName: "descriptionOfItem");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "imageOfItem",
                table: "Description",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "descriptionOfItem",
                table: "Description",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 300);

            migrationBuilder.AddColumn<string>(
                name: "title",
                table: "Description",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId_forLastBid",
                table: "Bid",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId_forSeller",
                table: "Bid",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "price",
                table: "Bid",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Time",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    timeOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Time", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Time_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bid_ItemId",
                table: "Bid",
                column: "ItemId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Time_ItemId",
                table: "Time",
                column: "ItemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Bid_Item_ItemId",
                table: "Bid",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
