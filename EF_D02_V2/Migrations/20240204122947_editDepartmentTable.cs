using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_D02_V2.Migrations
{
    /// <inheritdoc />
    public partial class editDepartmentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_departments_departments_DepartmentId",
                table: "departments");

            migrationBuilder.DropIndex(
                name: "IX_departments_DepartmentId",
                table: "departments");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "departments");

            migrationBuilder.DropColumn(
                name: "addres",
                table: "departments");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "departments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "addres",
                table: "departments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_departments_DepartmentId",
                table: "departments",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_departments_departments_DepartmentId",
                table: "departments",
                column: "DepartmentId",
                principalTable: "departments",
                principalColumn: "Id");
        }
    }
}
