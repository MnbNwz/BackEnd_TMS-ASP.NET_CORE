using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tms.Server.Migrations
{
    /// <inheritdoc />
    public partial class role1Removed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role1",
                table: "User");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "1",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPjuz6GmiXeH7ExlNUZIBaV/BLieYU0cPkyzKpxYrXC2nclSR4eS/pq6tzjLK5i3vw==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Role1",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "PasswordHash", "Role1" },
                values: new object[] { "AQAAAAIAAYagAAAAEKB6caicDmP/ZM6wAakT+jzTUtxLfN6R0UfYMSBBUAeJlqpn9iXVnMtRWEZtDAHmiA==", 0 });
        }
    }
}
