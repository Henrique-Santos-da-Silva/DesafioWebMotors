using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteBackendWebMotors.Data.Migrations
{
    public partial class Implement_Database_Mapper_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Anuncios",
                table: "Anuncios");

            migrationBuilder.DropColumn(
                name: "MarcaId",
                table: "Anuncios");

            migrationBuilder.DropColumn(
                name: "ModeloId",
                table: "Anuncios");

            migrationBuilder.DropColumn(
                name: "VersaoId",
                table: "Anuncios");

            migrationBuilder.RenameTable(
                name: "Anuncios",
                newName: "tb_AnuncioWebmotors");

            migrationBuilder.RenameColumn(
                name: "Versao",
                table: "tb_AnuncioWebmotors",
                newName: "versao");

            migrationBuilder.RenameColumn(
                name: "Quilometragem",
                table: "tb_AnuncioWebmotors",
                newName: "quilometragem");

            migrationBuilder.RenameColumn(
                name: "Observacao",
                table: "tb_AnuncioWebmotors",
                newName: "observacao");

            migrationBuilder.RenameColumn(
                name: "Modelo",
                table: "tb_AnuncioWebmotors",
                newName: "modelo");

            migrationBuilder.RenameColumn(
                name: "Marca",
                table: "tb_AnuncioWebmotors",
                newName: "marca");

            migrationBuilder.RenameColumn(
                name: "Ano",
                table: "tb_AnuncioWebmotors",
                newName: "ano");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tb_AnuncioWebmotors",
                newName: "ID");

            migrationBuilder.AlterColumn<string>(
                name: "versao",
                table: "tb_AnuncioWebmotors",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "observacao",
                table: "tb_AnuncioWebmotors",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "modelo",
                table: "tb_AnuncioWebmotors",
                type: "varchar(45)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "marca",
                table: "tb_AnuncioWebmotors",
                type: "varchar(45)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_AnuncioWebmotors",
                table: "tb_AnuncioWebmotors",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_AnuncioWebmotors",
                table: "tb_AnuncioWebmotors");

            migrationBuilder.RenameTable(
                name: "tb_AnuncioWebmotors",
                newName: "Anuncios");

            migrationBuilder.RenameColumn(
                name: "versao",
                table: "Anuncios",
                newName: "Versao");

            migrationBuilder.RenameColumn(
                name: "quilometragem",
                table: "Anuncios",
                newName: "Quilometragem");

            migrationBuilder.RenameColumn(
                name: "observacao",
                table: "Anuncios",
                newName: "Observacao");

            migrationBuilder.RenameColumn(
                name: "modelo",
                table: "Anuncios",
                newName: "Modelo");

            migrationBuilder.RenameColumn(
                name: "marca",
                table: "Anuncios",
                newName: "Marca");

            migrationBuilder.RenameColumn(
                name: "ano",
                table: "Anuncios",
                newName: "Ano");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Anuncios",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Versao",
                table: "Anuncios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Observacao",
                table: "Anuncios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Anuncios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(45)");

            migrationBuilder.AlterColumn<string>(
                name: "Marca",
                table: "Anuncios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(45)");

            migrationBuilder.AddColumn<int>(
                name: "MarcaId",
                table: "Anuncios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ModeloId",
                table: "Anuncios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VersaoId",
                table: "Anuncios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Anuncios",
                table: "Anuncios",
                column: "Id");
        }
    }
}
