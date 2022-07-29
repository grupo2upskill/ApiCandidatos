using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICandidatos.Migrations
{
    public partial class testeFoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AplicacaoTrabalho_Candidato_CandidatoIdCandidato",
                table: "AplicacaoTrabalho");

            migrationBuilder.DropForeignKey(
                name: "FK_AplicacaoTrabalho_OfertaEmprego_OfertaEmpregoIdOferta",
                table: "AplicacaoTrabalho");

            migrationBuilder.DropForeignKey(
                name: "FK_CV_Candidato_CandidatoIdCandidato",
                table: "CV");

            migrationBuilder.DropForeignKey(
                name: "FK_OfertaEmprego_Empresa_IdEmpresa",
                table: "OfertaEmprego");

            migrationBuilder.DropIndex(
                name: "IX_CV_CandidatoIdCandidato",
                table: "CV");

            migrationBuilder.DropIndex(
                name: "IX_AplicacaoTrabalho_CandidatoIdCandidato",
                table: "AplicacaoTrabalho");

            migrationBuilder.DropIndex(
                name: "IX_AplicacaoTrabalho_OfertaEmpregoIdOferta",
                table: "AplicacaoTrabalho");

            migrationBuilder.DropColumn(
                name: "CandidatoIdCandidato",
                table: "CV");

            migrationBuilder.DropColumn(
                name: "Foto",
                table: "Candidato");

            migrationBuilder.DropColumn(
                name: "CandidatoIdCandidato",
                table: "AplicacaoTrabalho");

            migrationBuilder.DropColumn(
                name: "OfertaEmpregoIdOferta",
                table: "AplicacaoTrabalho");

            migrationBuilder.RenameColumn(
                name: "IdCandidato",
                table: "CV",
                newName: "IdCandidatoCv");

            migrationBuilder.CreateTable(
                name: "Foto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCandidatoFoto = table.Column<int>(type: "int", nullable: false),
                    FotoPerfil = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Foto_Candidato_IdCandidatoFoto",
                        column: x => x.IdCandidatoFoto,
                        principalTable: "Candidato",
                        principalColumn: "IdCandidato",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CV_IdCandidatoCv",
                table: "CV",
                column: "IdCandidatoCv");

            migrationBuilder.CreateIndex(
                name: "IX_Foto_IdCandidatoFoto",
                table: "Foto",
                column: "IdCandidatoFoto");

            migrationBuilder.AddForeignKey(
                name: "FK_CV_Candidato_IdCandidatoCv",
                table: "CV",
                column: "IdCandidatoCv",
                principalTable: "Candidato",
                principalColumn: "IdCandidato");

            migrationBuilder.AddForeignKey(
                name: "FK_OfertaEmprego_Empresa_IdEmpresa",
                table: "OfertaEmprego",
                column: "IdEmpresa",
                principalTable: "Empresa",
                principalColumn: "IdEmpresa",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CV_Candidato_IdCandidatoCv",
                table: "CV");

            migrationBuilder.DropForeignKey(
                name: "FK_OfertaEmprego_Empresa_IdEmpresa",
                table: "OfertaEmprego");

            migrationBuilder.DropTable(
                name: "Foto");

            migrationBuilder.DropIndex(
                name: "IX_CV_IdCandidatoCv",
                table: "CV");

            migrationBuilder.RenameColumn(
                name: "IdCandidatoCv",
                table: "CV",
                newName: "IdCandidato");

            migrationBuilder.AddColumn<int>(
                name: "CandidatoIdCandidato",
                table: "CV",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Foto",
                table: "Candidato",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CandidatoIdCandidato",
                table: "AplicacaoTrabalho",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OfertaEmpregoIdOferta",
                table: "AplicacaoTrabalho",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CV_CandidatoIdCandidato",
                table: "CV",
                column: "CandidatoIdCandidato");

            migrationBuilder.CreateIndex(
                name: "IX_AplicacaoTrabalho_CandidatoIdCandidato",
                table: "AplicacaoTrabalho",
                column: "CandidatoIdCandidato");

            migrationBuilder.CreateIndex(
                name: "IX_AplicacaoTrabalho_OfertaEmpregoIdOferta",
                table: "AplicacaoTrabalho",
                column: "OfertaEmpregoIdOferta");

            migrationBuilder.AddForeignKey(
                name: "FK_AplicacaoTrabalho_Candidato_CandidatoIdCandidato",
                table: "AplicacaoTrabalho",
                column: "CandidatoIdCandidato",
                principalTable: "Candidato",
                principalColumn: "IdCandidato");

            migrationBuilder.AddForeignKey(
                name: "FK_AplicacaoTrabalho_OfertaEmprego_OfertaEmpregoIdOferta",
                table: "AplicacaoTrabalho",
                column: "OfertaEmpregoIdOferta",
                principalTable: "OfertaEmprego",
                principalColumn: "IdOferta");

            migrationBuilder.AddForeignKey(
                name: "FK_CV_Candidato_CandidatoIdCandidato",
                table: "CV",
                column: "CandidatoIdCandidato",
                principalTable: "Candidato",
                principalColumn: "IdCandidato");

            migrationBuilder.AddForeignKey(
                name: "FK_OfertaEmprego_Empresa_IdEmpresa",
                table: "OfertaEmprego",
                column: "IdEmpresa",
                principalTable: "Empresa",
                principalColumn: "IdEmpresa");
        }
    }
}
