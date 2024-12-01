using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetCoreTodo.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        // (... some code)

    migrationBuilder.CreateTable(
            name: "Items",
            columns: table => new
            {
            Id = table.Column<Guid>(nullable: false),
            DueAt = table.Column<DateTimeOffset>(nullable: true),
            IsDone = table.Column<bool>(nullable: false),
            Title = table.Column<string>(nullable: true)
            },
            constraints: table =>
            {
            table.PrimaryKey("PK_Items", x => x.Id);
            });

            // (some code...)
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // (... some code)

            migrationBuilder.DropTable(
            name: "Items");

            // (some code...)
        }
    }
}
