using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HapoTravelRequest.Migrations
{
    /// <inheritdoc />
    public partial class AddBookingFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConfirmationNumber",
                table: "TravelRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ItineraryNumber",
                table: "TravelRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10684443-90ea-4553-86a3-49d08b55dffe",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80f2a83e-f6e1-4b21-be57-1b30ec3e098a", "AQAAAAIAAYagAAAAEC7opg8j4i1D7A3bvegn6TdBYJmslTfEANWMA7teLF2FSZF04ZvDbDop7HoaGpLnHQ==", "57216d8b-4808-47fd-a601-d941d978cf2d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmationNumber",
                table: "TravelRequests");

            migrationBuilder.DropColumn(
                name: "ItineraryNumber",
                table: "TravelRequests");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10684443-90ea-4553-86a3-49d08b55dffe",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5893dbbf-6668-4b1d-a10b-2f8a0033933c", "AQAAAAIAAYagAAAAEL89YuTrg56v3KYTG+zrAD0LiH2zO0oYMmfJHjUxBIY5Ni72EpXMrU8BakpgB1WF5A==", "76154e16-4831-4636-9297-b659e234331b" });
        }
    }
}
