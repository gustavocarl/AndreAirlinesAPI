using Microsoft.EntityFrameworkCore.Migrations;

namespace AndreAirlinesAPI.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EnderecoID",
                table: "Voo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Voo_EnderecoID",
                table: "Voo",
                column: "EnderecoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Voo_Endereco_EnderecoID",
                table: "Voo",
                column: "EnderecoID",
                principalTable: "Endereco",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Voo_Endereco_EnderecoID",
                table: "Voo");

            migrationBuilder.DropIndex(
                name: "IX_Voo_EnderecoID",
                table: "Voo");

            migrationBuilder.DropColumn(
                name: "EnderecoID",
                table: "Voo");
        }
    }
}
