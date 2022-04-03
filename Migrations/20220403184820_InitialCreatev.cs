using Microsoft.EntityFrameworkCore.Migrations;

namespace AndreAirlinesAPI.Migrations
{
    public partial class InitialCreatev : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VooID",
                table: "Passagem",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Passagem_VooID",
                table: "Passagem",
                column: "VooID");

            migrationBuilder.AddForeignKey(
                name: "FK_Passagem_Voo_VooID",
                table: "Passagem",
                column: "VooID",
                principalTable: "Voo",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Passagem_Voo_VooID",
                table: "Passagem");

            migrationBuilder.DropIndex(
                name: "IX_Passagem_VooID",
                table: "Passagem");

            migrationBuilder.DropColumn(
                name: "VooID",
                table: "Passagem");
        }
    }
}
