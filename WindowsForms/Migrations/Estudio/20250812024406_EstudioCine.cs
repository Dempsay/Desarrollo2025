using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WindowsForms.Migrations.Estudio
{
    /// <inheritdoc />
    public partial class EstudioCine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Actores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PaisId = table.Column<int>(type: "int", nullable: false),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Actores_Paises_PaisId",
                        column: x => x.PaisId,
                        principalTable: "Paises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Estudios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    direccion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ActorId = table.Column<int>(type: "int", nullable: true),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudios", x => x.id);
                    table.ForeignKey(
                        name: "FK_Estudios_Actores_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actores",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "Id", "Eliminado", "Nombre" },
                values: new object[,]
                {
                    { 1, false, "Estados Unidos" },
                    { 2, false, "Reino Unido" },
                    { 3, false, "Alemania" },
                    { 4, false, "Francia" },
                    { 5, false, "Italia" },
                    { 6, false, "España" },
                    { 7, false, "Japón" },
                    { 8, false, "Canadá" },
                    { 9, false, "Australia" },
                    { 10, false, "México" }
                });

            migrationBuilder.InsertData(
                table: "Actores",
                columns: new[] { "Id", "Eliminado", "Nombre", "PaisId" },
                values: new object[,]
                {
                    { 1, false, "Leonardo DiCaprio", 1 },
                    { 2, false, "Meryl Streep", 1 },
                    { 3, false, "Denzel Washington", 1 },
                    { 4, false, "Tom Hanks", 1 },
                    { 5, false, "Scarlett Johansson", 1 },
                    { 6, false, "Brad Pitt", 1 },
                    { 7, false, "Natalie Portman", 2 },
                    { 8, false, "Morgan Freeman", 1 },
                    { 9, false, "Robert De Niro", 1 },
                    { 10, false, "Emma Stone", 1 }
                });

            migrationBuilder.InsertData(
                table: "Estudios",
                columns: new[] { "id", "ActorId", "Eliminado", "direccion", "nombre" },
                values: new object[,]
                {
                    { 1, 1, false, "4000 Warner Blvd, Burbank, CA, USA", "Warner Bros." },
                    { 2, 2, false, "5555 Melrose Ave, Los Angeles, CA, USA", "Paramount Pictures" },
                    { 3, 3, false, "100 Universal City Plaza, Universal City, CA, USA", "Universal Pictures" },
                    { 4, 4, false, "10202 W Washington Blvd, Culver City, CA, USA", "Columbia Pictures" },
                    { 5, 5, false, "10201 W Pico Blvd, Los Angeles, CA, USA", "20th Century Studios" },
                    { 6, 6, false, "Pinewood Rd, Iver Heath, Buckinghamshire, UK", "Pinewood Studios" },
                    { 7, 7, false, "August-Bebel-Str. 26-53, 14482 Potsdam, Alemania", "Studio Babelsberg" },
                    { 8, 8, false, "30 Avenue Charles de Gaulle, 92200 Neuilly-sur-Seine, Francia", "Gaumont Film Company" },
                    { 9, 9, false, "Via Tuscolana, 1055, 00173 Roma RM, Italia", "Cinecittà" },
                    { 10, 10, false, "1-2-2 Yurakucho, Chiyoda City, Tokio, Japón", "Toho Co., Ltd." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actores_PaisId",
                table: "Actores",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IX_Estudios_ActorId",
                table: "Estudios",
                column: "ActorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estudios");

            migrationBuilder.DropTable(
                name: "Pais");

            migrationBuilder.DropTable(
                name: "Actores");

            migrationBuilder.DropTable(
                name: "Paises");
        }
    }
}
