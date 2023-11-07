using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace airLineReservationTry.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Bookings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Bookings",
                type: "int",
                nullable: true);
        }
    }
}
