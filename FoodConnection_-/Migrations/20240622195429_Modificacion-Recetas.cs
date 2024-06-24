using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodConnection__.Migrations
{
    /// <inheritdoc />
    public partial class ModificacionRecetas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagenReceta",
                table: "Recetas",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagenReceta",
                table: "Recetas");
        }
    }
}
