using Microsoft.EntityFrameworkCore.Migrations;

namespace Algoriza2.EF.Migrations
{
    public partial class EditBookingsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_appointmentTimes",
                table: "appointmentTimes");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "FreeTime",
                table: "appointmentTimes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "appointmentTimes",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_appointmentTimes",
                table: "appointmentTimes",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_DoctorId",
                table: "Bookings",
                column: "DoctorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_DoctorId",
                table: "Bookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_appointmentTimes",
                table: "appointmentTimes");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "appointmentTimes");

            migrationBuilder.AlterColumn<string>(
                name: "FreeTime",
                table: "appointmentTimes",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings",
                columns: new[] { "DoctorId", "PatientId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_appointmentTimes",
                table: "appointmentTimes",
                columns: new[] { "FreeDay", "FreeTime" });
        }
    }
}
