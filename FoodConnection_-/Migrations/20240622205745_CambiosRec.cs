using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodConnection__.Migrations
{
    /// <inheritdoc />
    public partial class CambiosRec : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PathImagen",
                table: "Recetas",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PathImagen",
                table: "Recetas");
        }
    }
}
