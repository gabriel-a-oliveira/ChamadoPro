using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChamadoPro.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DataCreatedTicket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date_created",
                table: "Tickets",
                newName: "DateCreated");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Tickets",
                newName: "Date_created");
        }
    }
}
