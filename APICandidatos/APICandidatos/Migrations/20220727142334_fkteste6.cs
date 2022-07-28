using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICandidatos.Migrations
{
    public partial class fkteste6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CandidatoIdCandidato",
                table: "CV",
                type: "int",
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "CandidatoIdCandidato",
                table: "AplicacaoTrabalho");

            migrationBuilder.DropColumn(
                name: "OfertaEmpregoIdOferta",
                table: "AplicacaoTrabalho");
        }
    }
}
