using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectComputer.Data.Migrations
{
    public partial class onetomany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdCustomer",
                table: "Listrentin",
                newName: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Listrentin_CustomerId",
                table: "Listrentin",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Listrentin_customers_CustomerId",
                table: "Listrentin",
                column: "CustomerId",
                principalTable: "customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Listrentin_customers_CustomerId",
                table: "Listrentin");

            migrationBuilder.DropIndex(
                name: "IX_Listrentin_CustomerId",
                table: "Listrentin");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Listrentin",
                newName: "IdCustomer");
        }
    }
}
