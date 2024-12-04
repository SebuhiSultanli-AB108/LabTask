using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MediPlus.Migrations
{
    /// <inheritdoc />
    public partial class department2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "serviceItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_serviceItems_DepartmentId",
                table: "serviceItems",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_serviceItems_departments_DepartmentId",
                table: "serviceItems",
                column: "DepartmentId",
                principalTable: "departments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_serviceItems_departments_DepartmentId",
                table: "serviceItems");

            migrationBuilder.DropIndex(
                name: "IX_serviceItems_DepartmentId",
                table: "serviceItems");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "serviceItems");
        }
    }
}
