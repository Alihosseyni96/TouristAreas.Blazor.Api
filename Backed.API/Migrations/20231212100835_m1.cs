using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backed.API.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TouristAreas_Cities_CityId",
                table: "TouristAreas");

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "TouristAreas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_TouristAreas_Cities_CityId",
                table: "TouristAreas",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TouristAreas_Cities_CityId",
                table: "TouristAreas");

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "TouristAreas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TouristAreas_Cities_CityId",
                table: "TouristAreas",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
