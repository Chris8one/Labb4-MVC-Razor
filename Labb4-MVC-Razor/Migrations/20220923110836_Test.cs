using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb4_MVC_Razor.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCustomer_Book_BookId",
                table: "BookCustomer");

            migrationBuilder.DropForeignKey(
                name: "FK_BookCustomer_Customer_CustomerId",
                table: "BookCustomer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookCustomer",
                table: "BookCustomer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Book",
                table: "Book");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            migrationBuilder.RenameTable(
                name: "BookCustomer",
                newName: "BookCustomers");

            migrationBuilder.RenameTable(
                name: "Book",
                newName: "Books");

            migrationBuilder.RenameIndex(
                name: "IX_BookCustomer_CustomerId",
                table: "BookCustomers",
                newName: "IX_BookCustomers_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_BookCustomer_BookId",
                table: "BookCustomers",
                newName: "IX_BookCustomers_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookCustomers",
                table: "BookCustomers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookCustomers_Books_BookId",
                table: "BookCustomers",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookCustomers_Customers_CustomerId",
                table: "BookCustomers",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCustomers_Books_BookId",
                table: "BookCustomers");

            migrationBuilder.DropForeignKey(
                name: "FK_BookCustomers_Customers_CustomerId",
                table: "BookCustomers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookCustomers",
                table: "BookCustomers");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "Book");

            migrationBuilder.RenameTable(
                name: "BookCustomers",
                newName: "BookCustomer");

            migrationBuilder.RenameIndex(
                name: "IX_BookCustomers_CustomerId",
                table: "BookCustomer",
                newName: "IX_BookCustomer_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_BookCustomers_BookId",
                table: "BookCustomer",
                newName: "IX_BookCustomer_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Book",
                table: "Book",
                column: "BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookCustomer",
                table: "BookCustomer",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookCustomer_Book_BookId",
                table: "BookCustomer",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookCustomer_Customer_CustomerId",
                table: "BookCustomer",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
