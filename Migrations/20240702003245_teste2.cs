using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Consultorio.Migrations
{
    public partial class teste2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "horatio",
                table: "tb_agendamento",
                newName: "horario");

            migrationBuilder.RenameColumn(
                name: "NomePaciente",
                table: "tb_agendamento",
                newName: "nome_paciente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nome_paciente",
                table: "tb_agendamento",
                newName: "NomePaciente");

            migrationBuilder.RenameColumn(
                name: "horario",
                table: "tb_agendamento",
                newName: "horatio");
        }
    }
}
