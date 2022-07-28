using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICandidatos.Migrations
{
    public partial class fk104 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CV_Candidato_CandidatoIdCandidato",
                table: "CV");

            migrationBuilder.DropForeignKey(
                name: "FK_OfertaEmprego_Empresa_EmpresaIdEmpresa",
                table: "OfertaEmprego");

            migrationBuilder.DropIndex(
                name: "IX_OfertaEmprego_EmpresaIdEmpresa",
                table: "OfertaEmprego");

            migrationBuilder.DropIndex(
                name: "IX_CV_CandidatoIdCandidato",
                table: "CV");

            migrationBuilder.DropColumn(
                name: "EmpresaIdEmpresa",
                table: "OfertaEmprego");

            migrationBuilder.DropColumn(
                name: "CandidatoIdCandidato",
                table: "CV");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmpresaIdEmpresa",
                table: "OfertaEmprego",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CandidatoIdCandidato",
                table: "CV",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OfertaEmprego_EmpresaIdEmpresa",
                table: "OfertaEmprego",
                column: "EmpresaIdEmpresa");

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
                name: "FK_OfertaEmprego_Empresa_EmpresaIdEmpresa",
                table: "OfertaEmprego",
                column: "EmpresaIdEmpresa",
                principalTable: "Empresa",
                principalColumn: "IdEmpresa");
        }
    }
}
