using Microsoft.EntityFrameworkCore.Migrations;

namespace EventsApi.Migrations
{
    public partial class Lectures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lecture_EventDays_EventDayId",
                table: "Lecture");

            migrationBuilder.DropForeignKey(
                name: "FK_Lecture_Speaker_SpeakerId",
                table: "Lecture");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lecture",
                table: "Lecture");

            migrationBuilder.RenameTable(
                name: "Lecture",
                newName: "Lectures");

            migrationBuilder.RenameIndex(
                name: "IX_Lecture_SpeakerId",
                table: "Lectures",
                newName: "IX_Lectures_SpeakerId");

            migrationBuilder.RenameIndex(
                name: "IX_Lecture_EventDayId",
                table: "Lectures",
                newName: "IX_Lectures_EventDayId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lectures",
                table: "Lectures",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lectures_EventDays_EventDayId",
                table: "Lectures",
                column: "EventDayId",
                principalTable: "EventDays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lectures_Speaker_SpeakerId",
                table: "Lectures",
                column: "SpeakerId",
                principalTable: "Speaker",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lectures_EventDays_EventDayId",
                table: "Lectures");

            migrationBuilder.DropForeignKey(
                name: "FK_Lectures_Speaker_SpeakerId",
                table: "Lectures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lectures",
                table: "Lectures");

            migrationBuilder.RenameTable(
                name: "Lectures",
                newName: "Lecture");

            migrationBuilder.RenameIndex(
                name: "IX_Lectures_SpeakerId",
                table: "Lecture",
                newName: "IX_Lecture_SpeakerId");

            migrationBuilder.RenameIndex(
                name: "IX_Lectures_EventDayId",
                table: "Lecture",
                newName: "IX_Lecture_EventDayId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lecture",
                table: "Lecture",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lecture_EventDays_EventDayId",
                table: "Lecture",
                column: "EventDayId",
                principalTable: "EventDays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lecture_Speaker_SpeakerId",
                table: "Lecture",
                column: "SpeakerId",
                principalTable: "Speaker",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
