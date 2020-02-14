using Microsoft.EntityFrameworkCore.Migrations;

namespace FromAeApi.Migrations
{
    public partial class ModelMarka : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Markas_Products_ProductId",
                table: "Markas");

            migrationBuilder.DropIndex(
                name: "IX_Markas_ProductId",
                table: "Markas");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Markas");

            migrationBuilder.AddColumn<int>(
                name: "ModelId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ModelId",
                table: "Products",
                column: "ModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Models_ModelId",
                table: "Products",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Models_ModelId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ModelId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ModelId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Markas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Markas_ProductId",
                table: "Markas",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Markas_Products_ProductId",
                table: "Markas",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
