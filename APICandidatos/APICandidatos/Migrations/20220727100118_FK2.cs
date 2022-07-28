using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICandidatos.Migrations
{
    public partial class FK2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AplicacaoTrabalho_Candidato_IdCandidato",
                table: "AplicacaoTrabalho");

            migrationBuilder.DropForeignKey(
                name: "FK_AplicacaoTrabalho_OfertaEmprego_IdOferta",
                table: "AplicacaoTrabalho");

            migrationBuilder.DropIndex(
                name: "IX_AplicacaoTrabalho_IdCandidato",
                table: "AplicacaoTrabalho");

            migrationBuilder.DropIndex(
                name: "IX_AplicacaoTrabalho_IdOferta",
                table: "AplicacaoTrabalho");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_AplicacaoTrabalho_IdCandidato",
                table: "AplicacaoTrabalho",
                column: "IdCandidato");

            migrationBuilder.CreateIndex(
                name: "IX_AplicacaoTrabalho_IdOferta",
                table: "AplicacaoTrabalho",
                column: "IdOferta");

            migrationBuilder.AddForeignKey(
                name: "FK_AplicacaoTrabalho_Candidato_IdCandidato",
                table: "AplicacaoTrabalho",
                column: "IdCandidato",
                principalTable: "Candidato",
                principalColumn: "IdCandidato",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AplicacaoTrabalho_OfertaEmprego_IdOferta",
                table: "AplicacaoTrabalho",
                column: "IdOferta",
                principalTable: "OfertaEmprego",
                principalColumn: "IdOferta",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
