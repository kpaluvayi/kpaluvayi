using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sparcpoint.DataLayer.Migrations
{
    public partial class oio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductAttribute_Products_InstanceId",
                table: "ProductAttribute");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_Products_ProductsInstanceId",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "ProductsInstanceId",
                table: "ProductCategories");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductAttribute_Products_InstanceId",
                table: "ProductAttribute",
                column: "InstanceId",
                principalTable: "Products",
                principalColumn: "InstanceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_Products_InstanceId",
                table: "ProductCategories",
                column: "InstanceId",
                principalTable: "Products",
                principalColumn: "InstanceId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductAttribute_Products_InstanceId",
                table: "ProductAttribute");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_Products_InstanceId",
                table: "ProductCategories");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductsInstanceId",
                table: "ProductCategories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductAttribute_Products_InstanceId",
                table: "ProductAttribute",
                column: "InstanceId",
                principalTable: "Products",
                principalColumn: "InstanceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_Products_ProductsInstanceId",
                table: "ProductCategories",
                column: "ProductsInstanceId",
                principalTable: "Products",
                principalColumn: "InstanceId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
