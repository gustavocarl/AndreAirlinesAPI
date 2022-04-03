using Microsoft.EntityFrameworkCore.Migrations;

namespace AndreAirlinesAPI.Migrations
{
    public partial class InitialCreatev2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Passagem_PrecoBase_PrecoBaseId",
                table: "Passagem");

            migrationBuilder.DropForeignKey(
                name: "FK_PrecoBase_Voo_VooID",
                table: "PrecoBase");

            migrationBuilder.DropIndex(
                name: "IX_PrecoBase_VooID",
                table: "PrecoBase");

            migrationBuilder.DropColumn(
                name: "VooID",
                table: "PrecoBase");

            migrationBuilder.RenameColumn(
                name: "PrecoBaseId",
                table: "Passagem",
                newName: "ClasseId");

            migrationBuilder.RenameIndex(
                name: "IX_Passagem_PrecoBaseId",
                table: "Passagem",
                newName: "IX_Passagem_ClasseId");

            migrationBuilder.AddColumn<string>(
                name: "DestinoSigla",
                table: "PrecoBase",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrigemSigla",
                table: "PrecoBase",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Valor",
                table: "Passagem",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_PrecoBase_DestinoSigla",
                table: "PrecoBase",
                column: "DestinoSigla");

            migrationBuilder.CreateIndex(
                name: "IX_PrecoBase_OrigemSigla",
                table: "PrecoBase",
                column: "OrigemSigla");

            migrationBuilder.AddForeignKey(
                name: "FK_Passagem_Classe_ClasseId",
                table: "Passagem",
                column: "ClasseId",
                principalTable: "Classe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PrecoBase_Aeroporto_DestinoSigla",
                table: "PrecoBase",
                column: "DestinoSigla",
                principalTable: "Aeroporto",
                principalColumn: "Sigla",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PrecoBase_Aeroporto_OrigemSigla",
                table: "PrecoBase",
                column: "OrigemSigla",
                principalTable: "Aeroporto",
                principalColumn: "Sigla",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Passagem_Classe_ClasseId",
                table: "Passagem");

            migrationBuilder.DropForeignKey(
                name: "FK_PrecoBase_Aeroporto_DestinoSigla",
                table: "PrecoBase");

            migrationBuilder.DropForeignKey(
                name: "FK_PrecoBase_Aeroporto_OrigemSigla",
                table: "PrecoBase");

            migrationBuilder.DropIndex(
                name: "IX_PrecoBase_DestinoSigla",
                table: "PrecoBase");

            migrationBuilder.DropIndex(
                name: "IX_PrecoBase_OrigemSigla",
                table: "PrecoBase");

            migrationBuilder.DropColumn(
                name: "DestinoSigla",
                table: "PrecoBase");

            migrationBuilder.DropColumn(
                name: "OrigemSigla",
                table: "PrecoBase");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Passagem");

            migrationBuilder.RenameColumn(
                name: "ClasseId",
                table: "Passagem",
                newName: "PrecoBaseId");

            migrationBuilder.RenameIndex(
                name: "IX_Passagem_ClasseId",
                table: "Passagem",
                newName: "IX_Passagem_PrecoBaseId");

            migrationBuilder.AddColumn<int>(
                name: "VooID",
                table: "PrecoBase",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PrecoBase_VooID",
                table: "PrecoBase",
                column: "VooID");

            migrationBuilder.AddForeignKey(
                name: "FK_Passagem_PrecoBase_PrecoBaseId",
                table: "Passagem",
                column: "PrecoBaseId",
                principalTable: "PrecoBase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PrecoBase_Voo_VooID",
                table: "PrecoBase",
                column: "VooID",
                principalTable: "Voo",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
