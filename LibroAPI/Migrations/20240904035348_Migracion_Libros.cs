using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibroAPI.Migrations
{
    /// <inheritdoc />
    public partial class Migracion_Libros : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LibroSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnioPublicacion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibroSet", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "LibroSet",
                columns: new[] { "Id", "AnioPublicacion", "Autor", "Titulo" },
                values: new object[,]
                {
                    { 1, 1967, "Gabriel Garcia Marquez", "Cien años de soledad" },
                    { 2, 1605, "Miguel de Cervantes", "Don Quijote de la Mancha" },
                    { 3, 1985, "Gabriel Garcia Marquez", "El amor en los tiempos de colera" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LibroSet");
        }
    }
}
