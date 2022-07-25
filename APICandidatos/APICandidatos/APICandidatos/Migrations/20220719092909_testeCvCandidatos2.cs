using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICandidatos.Migrations
{
    public partial class testeCvCandidatos2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidato_CV_IdCV",
                table: "Candidato");

            migrationBuilder.DropIndex(
                name: "IX_Candidato_IdCV",
                table: "Candidato");

            migrationBuilder.DropColumn(
                name: "IdCV",
                table: "Candidato");

            migrationBuilder.AddColumn<int>(
                name: "CandidatoIdCandidato",
                table: "CV",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCandidato",
                table: "CV",
                type: "int",
                nullable: true);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CV_Candidato_CandidatoIdCandidato",
                table: "CV");

            migrationBuilder.DropIndex(
                name: "IX_CV_CandidatoIdCandidato",
                table: "CV");

            migrationBuilder.DropColumn(
                name: "CandidatoIdCandidato",
                table: "CV");

            migrationBuilder.DropColumn(
                name: "IdCandidato",
                table: "CV");

            migrationBuilder.AddColumn<int>(
                name: "IdCV",
                table: "Candidato",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Candidato_IdCV",
                table: "Candidato",
                column: "IdCV");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidato_CV_IdCV",
                table: "Candidato",
                column: "IdCV",
                principalTable: "CV",
                principalColumn: "IdCV");
        }
    }
}
