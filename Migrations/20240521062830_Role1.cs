using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tms.Server.Migrations
{
    /// <inheritdoc />
    public partial class Role1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role1",
                table: "User");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "1",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEOsrcS7QNa6YI3IM2jnWLbxYoamz2/jUR3u+6LNAW+cfb2gwUL5CCjM55zp1wenEnw==");
        }
    }
}
