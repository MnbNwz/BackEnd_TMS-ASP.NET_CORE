using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tms.Server.Migrations
{
    /// <inheritdoc />
    public partial class Task_TaskAssignee_TaskAssignedByAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Assignee",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TaskAssignedBy",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Assignee",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "TaskAssignedBy",
                table: "Tasks");
        }
    }
}
