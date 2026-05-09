using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace COMP003B.SP26.FinalProject.GonzalezA.Migrations
{
    /// <inheritdoc />
    public partial class AddAppointmentStatusToAppointment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AppointmentStatus",
                table: "Appointments",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppointmentStatus",
                table: "Appointments");
        }
    }
}
