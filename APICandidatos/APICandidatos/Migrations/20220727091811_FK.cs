using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICandidatos.Migrations
{
    public partial class FK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CV_Candidato_CandidatoIdCandidato",
                table: "CV");

            migrationBuilder.DropForeignKey(
                name: "FK_OfertaEmprego_Empresa_IdEmpresa",
                table: "OfertaEmprego");

            migrationBuilder.DropIndex(
                name: "IX_OfertaEmprego_IdEmpresa",
                table: "OfertaEmprego");

            migrationBuilder.DropIndex(
                name: "IX_CV_CandidatoIdCandidato",
                table: "CV");

            migrationBuilder.DropColumn(
                name: "CandidatoIdCandidato",
                table: "CV");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CandidatoIdCandidato",
                table: "CV",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OfertaEmprego_IdEmpresa",
                table: "OfertaEmprego",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_CV_CandidatoIdCandidato",
                table: "CV",
                column: "CandidatoIdCandidato");

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
                principalColumn: "IdEmpresa",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
