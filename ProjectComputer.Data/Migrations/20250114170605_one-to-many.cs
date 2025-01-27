using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectComputer.Data.Migrations
{
    public partial class onetomany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Listrentin_customers_CustomerId",
                table: "Listrentin");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Listrentin",
                newName: "customerId");

            migrationBuilder.RenameColumn(
                name: "IdRenting",
                table: "Listrentin",
                newName: "computerId");

            migrationBuilder.RenameIndex(
                name: "IX_Listrentin_CustomerId",
                table: "Listrentin",
                newName: "IX_Listrentin_customerId");

            migrationBuilder.CreateIndex(
                name: "IX_Listrentin_computerId",
                table: "Listrentin",
                column: "computerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Listrentin_computers_computerId",
                table: "Listrentin",
                column: "computerId",
                principalTable: "computers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Listrentin_customers_customerId",
                table: "Listrentin",
                column: "customerId",
                principalTable: "customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Listrentin_computers_computerId",
                table: "Listrentin");

            migrationBuilder.DropForeignKey(
                name: "FK_Listrentin_customers_customerId",
                table: "Listrentin");

            migrationBuilder.DropIndex(
                name: "IX_Listrentin_computerId",
                table: "Listrentin");

            migrationBuilder.RenameColumn(
                name: "customerId",
                table: "Listrentin",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "computerId",
                table: "Listrentin",
                newName: "IdRenting");

            migrationBuilder.RenameIndex(
                name: "IX_Listrentin_customerId",
                table: "Listrentin",
                newName: "IX_Listrentin_CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Listrentin_customers_CustomerId",
                table: "Listrentin",
                column: "CustomerId",
                principalTable: "customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
