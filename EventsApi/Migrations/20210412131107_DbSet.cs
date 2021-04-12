using Microsoft.EntityFrameworkCore.Migrations;

namespace EventsApi.Migrations
{
    public partial class DbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventDay_Location_LocationId",
                table: "EventDay");

            migrationBuilder.DropForeignKey(
                name: "FK_Lecture_EventDay_EventDayId",
                table: "Lecture");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventDay",
                table: "EventDay");

            migrationBuilder.RenameTable(
                name: "EventDay",
                newName: "EventDays");

            migrationBuilder.RenameIndex(
                name: "IX_EventDay_LocationId",
                table: "EventDays",
                newName: "IX_EventDays_LocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventDays",
                table: "EventDays",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EventDays_Location_LocationId",
                table: "EventDays",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lecture_EventDays_EventDayId",
                table: "Lecture",
                column: "EventDayId",
                principalTable: "EventDays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventDays_Location_LocationId",
                table: "EventDays");

            migrationBuilder.DropForeignKey(
                name: "FK_Lecture_EventDays_EventDayId",
                table: "Lecture");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventDays",
                table: "EventDays");

            migrationBuilder.RenameTable(
                name: "EventDays",
                newName: "EventDay");

            migrationBuilder.RenameIndex(
                name: "IX_EventDays_LocationId",
                table: "EventDay",
                newName: "IX_EventDay_LocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventDay",
                table: "EventDay",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EventDay_Location_LocationId",
                table: "EventDay",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lecture_EventDay_EventDayId",
                table: "Lecture",
                column: "EventDayId",
                principalTable: "EventDay",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
