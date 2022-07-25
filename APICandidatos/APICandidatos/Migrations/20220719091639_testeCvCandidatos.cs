using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICandidatos.Migrations
{
    public partial class testeCvCandidatos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidato_CV_IdCV",
                table: "Candidato");

            migrationBuilder.AlterColumn<int>(
                name: "IdCV",
                table: "Candidato",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidato_CV_IdCV",
                table: "Candidato",
                column: "IdCV",
                principalTable: "CV",
                principalColumn: "IdCV");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidato_CV_IdCV",
                table: "Candidato");

            migrationBuilder.AlterColumn<int>(
                name: "IdCV",
                table: "Candidato",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Candidato_CV_IdCV",
                table: "Candidato",
                column: "IdCV",
                principalTable: "CV",
                principalColumn: "IdCV",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
