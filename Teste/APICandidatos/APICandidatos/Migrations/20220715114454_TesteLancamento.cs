using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICandidatos.Migrations
{
    public partial class TesteLancamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CV",
                columns: table => new
                {
                    IdCV = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Localizacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Educacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpProfissional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Competencias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Interesses = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CV", x => x.IdCV);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    IdEmpresa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Localidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<int>(type: "int", nullable: true),
                    NoFuncionarios = table.Column<int>(type: "int", nullable: true),
                    ZonaAtuacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkedIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Facebook = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.IdEmpresa);
                });

            migrationBuilder.CreateTable(
                name: "Candidato",
                columns: table => new
                {
                    IdCandidato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<int>(type: "int", nullable: true),
                    Morada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdCV = table.Column<int>(type: "int", nullable: false),
                    DataNasc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    LinkedIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Facebook = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidato", x => x.IdCandidato);
                    table.ForeignKey(
                        name: "FK_Candidato_CV_IdCV",
                        column: x => x.IdCV,
                        principalTable: "CV",
                        principalColumn: "IdCV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OfertaEmprego",
                columns: table => new
                {
                    IdOferta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEmpresa = table.Column<int>(type: "int", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salario = table.Column<float>(type: "real", nullable: true),
                    Jornada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Localização = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegimeTrabalho = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoContrato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Requisitos = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfertaEmprego", x => x.IdOferta);
                    table.ForeignKey(
                        name: "FK_OfertaEmprego_Empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "IdEmpresa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AplicacaoTrabalho",
                columns: table => new
                {
                    IdApl = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdOferta = table.Column<int>(type: "int", nullable: false),
                    IdCandidato = table.Column<int>(type: "int", nullable: false),
                    DataAplicacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    aplicacaoAceite = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AplicacaoTrabalho", x => x.IdApl);
                    table.ForeignKey(
                        name: "FK_AplicacaoTrabalho_Candidato_IdCandidato",
                        column: x => x.IdCandidato,
                        principalTable: "Candidato",
                        principalColumn: "IdCandidato",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AplicacaoTrabalho_OfertaEmprego_IdOferta",
                        column: x => x.IdOferta,
                        principalTable: "OfertaEmprego",
                        principalColumn: "IdOferta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AplicacaoTrabalho_IdCandidato",
                table: "AplicacaoTrabalho",
                column: "IdCandidato");

            migrationBuilder.CreateIndex(
                name: "IX_AplicacaoTrabalho_IdOferta",
                table: "AplicacaoTrabalho",
                column: "IdOferta");

            migrationBuilder.CreateIndex(
                name: "IX_Candidato_IdCV",
                table: "Candidato",
                column: "IdCV");

            migrationBuilder.CreateIndex(
                name: "IX_OfertaEmprego_IdEmpresa",
                table: "OfertaEmprego",
                column: "IdEmpresa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AplicacaoTrabalho");

            migrationBuilder.DropTable(
                name: "Candidato");

            migrationBuilder.DropTable(
                name: "OfertaEmprego");

            migrationBuilder.DropTable(
                name: "CV");

            migrationBuilder.DropTable(
                name: "Empresa");
        }
    }
}
