using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_D02_V2.Migrations
{
    /// <inheritdoc />
    public partial class editStudentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_departments_deptId",
                table: "students");

            migrationBuilder.RenameColumn(
                name: "deptId",
                table: "students",
                newName: "D_Id");

            migrationBuilder.RenameIndex(
                name: "IX_students_deptId",
                table: "students",
                newName: "IX_students_D_Id");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "students",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_students_departments_D_Id",
                table: "students",
                column: "D_Id",
                principalTable: "departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_departments_D_Id",
                table: "students");

            migrationBuilder.RenameColumn(
                name: "D_Id",
                table: "students",
                newName: "deptId");

            migrationBuilder.RenameIndex(
                name: "IX_students_D_Id",
                table: "students",
                newName: "IX_students_deptId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddForeignKey(
                name: "FK_students_departments_deptId",
                table: "students",
                column: "deptId",
                principalTable: "departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
