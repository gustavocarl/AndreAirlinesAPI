using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AndreAirlinesAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aeronave",
                columns: table => new
                {
                    Codigo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capacidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aeronave", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Localidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Aeroporto",
                columns: table => new
                {
                    Sigla = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnderecoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aeroporto", x => x.Sigla);
                    table.ForeignKey(
                        name: "FK_Aeroporto_Endereco_EnderecoID",
                        column: x => x.EnderecoID,
                        principalTable: "Endereco",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Passageiro",
                columns: table => new
                {
                    CPF = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnderecoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passageiro", x => x.CPF);
                    table.ForeignKey(
                        name: "FK_Passageiro_Endereco_EnderecoID",
                        column: x => x.EnderecoID,
                        principalTable: "Endereco",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Voo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiglaDestinoSigla = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SiglaOrigemSigla = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Codigo1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    HorarioEmbarque = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HorarioDesembarque = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CPF1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voo", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Voo_Aeronave_Codigo1",
                        column: x => x.Codigo1,
                        principalTable: "Aeronave",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Voo_Aeroporto_SiglaDestinoSigla",
                        column: x => x.SiglaDestinoSigla,
                        principalTable: "Aeroporto",
                        principalColumn: "Sigla",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Voo_Aeroporto_SiglaOrigemSigla",
                        column: x => x.SiglaOrigemSigla,
                        principalTable: "Aeroporto",
                        principalColumn: "Sigla",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Voo_Passageiro_CPF1",
                        column: x => x.CPF1,
                        principalTable: "Passageiro",
                        principalColumn: "CPF",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aeroporto_EnderecoID",
                table: "Aeroporto",
                column: "EnderecoID");

            migrationBuilder.CreateIndex(
                name: "IX_Passageiro_EnderecoID",
                table: "Passageiro",
                column: "EnderecoID");

            migrationBuilder.CreateIndex(
                name: "IX_Voo_Codigo1",
                table: "Voo",
                column: "Codigo1");

            migrationBuilder.CreateIndex(
                name: "IX_Voo_CPF1",
                table: "Voo",
                column: "CPF1");

            migrationBuilder.CreateIndex(
                name: "IX_Voo_SiglaDestinoSigla",
                table: "Voo",
                column: "SiglaDestinoSigla");

            migrationBuilder.CreateIndex(
                name: "IX_Voo_SiglaOrigemSigla",
                table: "Voo",
                column: "SiglaOrigemSigla");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Voo");

            migrationBuilder.DropTable(
                name: "Aeronave");

            migrationBuilder.DropTable(
                name: "Aeroporto");

            migrationBuilder.DropTable(
                name: "Passageiro");

            migrationBuilder.DropTable(
                name: "Endereco");
        }
    }
}
