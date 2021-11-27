using Microsoft.EntityFrameworkCore.Migrations;

namespace EMigrant2.Persistencia.Migrations
{
    public partial class PrimeraMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsuariosMigrantes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(maxLength: 50, nullable: false),
                    Apellidos = table.Column<string>(maxLength: 50, nullable: false),
                    TipoDeDocumento = table.Column<string>(maxLength: 50, nullable: false),
                    NumeroDeDocumento = table.Column<string>(maxLength: 50, nullable: false),
                    PaisDeOrigen = table.Column<string>(maxLength: 50, nullable: false),
                    FechaDeNacimiento = table.Column<int>(maxLength: 50, nullable: false),
                    Correo = table.Column<string>(maxLength: 50, nullable: true),
                    Telefono = table.Column<string>(maxLength: 50, nullable: true),
                    DireccionActual = table.Column<string>(maxLength: 50, nullable: true),
                    Ciudad = table.Column<string>(maxLength: 50, nullable: true),
                    SituacionLaboral = table.Column<string>(maxLength: 50, nullable: true),
                    Username = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuariosMigrantes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsuariosMigrantes");
        }
    }
}
