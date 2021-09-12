using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sparcpoint.DataLayer.Migrations
{
    public partial class jkj : Migration
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
                name: "FK_ProductCategories_Category_CategoryInstanceId",
                table: "ProductCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

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
                name: "FK_ProductCategories_Categories_CategoryInstanceId",
                table: "ProductCategories",
                column: "CategoryInstanceId",
                principalTable: "Categories",
                principalColumn: "InstanceId",
                onDelete: ReferentialAction.Cascade);
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
                name: "FK_ProductCategories_Categories_CategoryInstanceId",
                table: "ProductCategories");

            migrationBuilder.DropIndex(
                name: "IX_CatergoryAttributes_CategoryInstanceId",
                table: "CatergoryAttributes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

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
                name: "FK_ProductCategories_Category_CategoryInstanceId",
                table: "ProductCategories",
                column: "CategoryInstanceId",
                principalTable: "Category",
                principalColumn: "InstanceId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
