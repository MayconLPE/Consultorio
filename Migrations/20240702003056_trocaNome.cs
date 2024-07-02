using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Consultorio.Migrations
{
    public partial class trocaNome : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Agendamentos",
                table: "Agendamentos");

            migrationBuilder.RenameTable(
                name: "Agendamentos",
                newName: "tb_agendamento");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tb_agendamento",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Horario",
                table: "tb_agendamento",
                newName: "horatio");

            migrationBuilder.AlterColumn<string>(
                name: "NomePaciente",
                table: "tb_agendamento",
                type: "varchar(100",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_agendamento",
                table: "tb_agendamento",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_agendamento",
                table: "tb_agendamento");

            migrationBuilder.RenameTable(
                name: "tb_agendamento",
                newName: "Agendamentos");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Agendamentos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "horatio",
                table: "Agendamentos",
                newName: "Horario");

            migrationBuilder.AlterColumn<string>(
                name: "NomePaciente",
                table: "Agendamentos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Agendamentos",
                table: "Agendamentos",
                column: "Id");
        }
    }
}
