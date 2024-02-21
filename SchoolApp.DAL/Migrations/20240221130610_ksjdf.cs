using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ksjdf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FeeStructure_Standard_StandardId",
                table: "FeeStructure");

            migrationBuilder.AlterColumn<int>(
                name: "StandardId",
                table: "FeeStructure",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_FeeStructure_Standard_StandardId",
                table: "FeeStructure",
                column: "StandardId",
                principalTable: "Standard",
                principalColumn: "StandardId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FeeStructure_Standard_StandardId",
                table: "FeeStructure");

            migrationBuilder.AlterColumn<int>(
                name: "StandardId",
                table: "FeeStructure",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FeeStructure_Standard_StandardId",
                table: "FeeStructure",
                column: "StandardId",
                principalTable: "Standard",
                principalColumn: "StandardId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
