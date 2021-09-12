using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sparcpoint.DataLayer.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryOfCategory_Category_CategoryInstanceId",
                table: "CategoryOfCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_CatergoryAttributes_Category_InstanceId",
                table: "CatergoryAttributes");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductAttribute_Products_InstanceId",
                table: "ProductAttribute");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_Category_CategoryInstanceId",
                table: "ProductCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_Products_InstanceId",
                table: "ProductCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductsInstanceId",
                table: "ProductCategories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProductsInstanceId",
                table: "ProductAttribute",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryInstanceId",
                table: "CatergoryAttributes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "InstanceId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_ProductsInstanceId",
                table: "ProductCategories",
                column: "ProductsInstanceId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttribute_ProductsInstanceId",
                table: "ProductAttribute",
                column: "ProductsInstanceId");

            migrationBuilder.CreateIndex(
                name: "IX_CatergoryAttributes_CategoryInstanceId",
                table: "CatergoryAttributes",
                column: "CategoryInstanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryOfCategory_Categories_CategoryInstanceId",
                table: "CategoryOfCategory",
                column: "CategoryInstanceId",
                principalTable: "Categories",
                principalColumn: "InstanceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CatergoryAttributes_Categories_CategoryInstanceId",
                table: "CatergoryAttributes",
                column: "CategoryInstanceId",
                principalTable: "Categories",
                principalColumn: "InstanceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductAttribute_Products_ProductsInstanceId",
                table: "ProductAttribute",
                column: "ProductsInstanceId",
                principalTable: "Products",
                principalColumn: "InstanceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_Categories_CategoryInstanceId",
                table: "ProductCategories",
                column: "CategoryInstanceId",
                principalTable: "Categories",
                principalColumn: "InstanceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_Products_ProductsInstanceId",
                table: "ProductCategories",
                column: "ProductsInstanceId",
                principalTable: "Products",
                principalColumn: "InstanceId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryOfCategory_Categories_CategoryInstanceId",
                table: "CategoryOfCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_CatergoryAttributes_Categories_CategoryInstanceId",
                table: "CatergoryAttributes");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductAttribute_Products_ProductsInstanceId",
                table: "ProductAttribute");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_Categories_CategoryInstanceId",
                table: "ProductCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_Products_ProductsInstanceId",
                table: "ProductCategories");

            migrationBuilder.DropIndex(
                name: "IX_ProductCategories_ProductsInstanceId",
                table: "ProductCategories");

            migrationBuilder.DropIndex(
                name: "IX_ProductAttribute_ProductsInstanceId",
                table: "ProductAttribute");

            migrationBuilder.DropIndex(
                name: "IX_CatergoryAttributes_CategoryInstanceId",
                table: "CatergoryAttributes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ProductsInstanceId",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "ProductsInstanceId",
                table: "ProductAttribute");

            migrationBuilder.DropColumn(
                name: "CategoryInstanceId",
                table: "CatergoryAttributes");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "InstanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryOfCategory_Category_CategoryInstanceId",
                table: "CategoryOfCategory",
                column: "CategoryInstanceId",
                principalTable: "Category",
                principalColumn: "InstanceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CatergoryAttributes_Category_InstanceId",
                table: "CatergoryAttributes",
                column: "InstanceId",
                principalTable: "Category",
                principalColumn: "InstanceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductAttribute_Products_InstanceId",
                table: "ProductAttribute",
                column: "InstanceId",
                principalTable: "Products",
                principalColumn: "InstanceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_Category_CategoryInstanceId",
                table: "ProductCategories",
                column: "CategoryInstanceId",
                principalTable: "Category",
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
    }
}
