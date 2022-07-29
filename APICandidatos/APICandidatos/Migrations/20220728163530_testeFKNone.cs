using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICandidatos.Migrations
{
    public partial class testeFKNone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CV_Candidato_IdCandidatoCv",
                table: "CV");

            migrationBuilder.DropForeignKey(
                name: "FK_Foto_Candidato_IdCandidatoFoto",
                table: "Foto");

            migrationBuilder.DropIndex(
                name: "IX_Foto_IdCandidatoFoto",
                table: "Foto");

            migrationBuilder.DropIndex(
                name: "IX_CV_IdCandidatoCv",
                table: "CV");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Foto_IdCandidatoFoto",
                table: "Foto",
                column: "IdCandidatoFoto");

            migrationBuilder.CreateIndex(
                name: "IX_CV_IdCandidatoCv",
                table: "CV",
                column: "IdCandidatoCv");

            migrationBuilder.AddForeignKey(
                name: "FK_CV_Candidato_IdCandidatoCv",
                table: "CV",
                column: "IdCandidatoCv",
                principalTable: "Candidato",
                principalColumn: "IdCandidato");

            migrationBuilder.AddForeignKey(
                name: "FK_Foto_Candidato_IdCandidatoFoto",
                table: "Foto",
                column: "IdCandidatoFoto",
                principalTable: "Candidato",
                principalColumn: "IdCandidato",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
