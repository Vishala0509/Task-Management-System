using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Board.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaskItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AssignedTo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TaskItems",
                columns: new[] { "Id", "AssignedTo", "CreatedAt", "Description", "Status", "Title" },
                values: new object[,]
                {
                    { 1, "John Doe", new DateTime(2025, 6, 28, 20, 12, 57, 239, DateTimeKind.Utc).AddTicks(6650), "Initialize the TaskBoard project", "Completed", "Setup Project" },
                    { 2, "Jane Smith", new DateTime(2025, 6, 29, 20, 12, 57, 239, DateTimeKind.Utc).AddTicks(6660), "Define TaskItem model", "In Progress", "Create Models" },
                    { 3, "Bob Johnson", new DateTime(2025, 6, 30, 20, 12, 57, 239, DateTimeKind.Utc).AddTicks(6662), "Create the user interface", "To Do", "Build UI" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskItems");
        }
    }
}
