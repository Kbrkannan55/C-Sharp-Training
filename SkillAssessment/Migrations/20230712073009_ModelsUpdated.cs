using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkillAssessment.Migrations
{
    /// <inheritdoc />
    public partial class ModelsUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAssessments_AssessmentHistorys_AssessmentHistoryId",
                table: "UserAssessments");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAssessments_EmailHistory_EmailHistoryId",
                table: "UserAssessments");

            migrationBuilder.DropIndex(
                name: "IX_UserAssessments_EmailHistoryId",
                table: "UserAssessments");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "EmailHistory");

            migrationBuilder.DropColumn(
                name: "DateOfCompletion",
                table: "Assessments");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Assessments");

            migrationBuilder.DropColumn(
                name: "NumberOfQuestions",
                table: "Assessments");

            migrationBuilder.DropColumn(
                name: "NumberOfTopics",
                table: "Assessments");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "AssessmentHistorys");

            migrationBuilder.RenameColumn(
                name: "EmailHistoryId",
                table: "UserAssessments",
                newName: "NumberOfTopics");

            migrationBuilder.AlterColumn<long>(
                name: "PhoneNumber",
                table: "Users",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AssessmentHistoryId",
                table: "UserAssessments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfCompletion",
                table: "UserAssessments",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfCreation",
                table: "UserAssessments",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "UserAssessments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfQuestions",
                table: "UserAssessments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalTime",
                table: "UserAssessments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "QuestionPages",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AssessmentId",
                table: "EmailHistory",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "EmailHistory",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfSubmission",
                table: "AssessmentHistorys",
                type: "Date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AddColumn<int>(
                name: "Points",
                table: "AssessmentHistorys",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "userRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AssessmentId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    NumberOfQuestions = table.Column<int>(type: "int", nullable: false),
                    DateOfCompletion = table.Column<DateTime>(type: "Date", nullable: false),
                    DateOfRequest = table.Column<DateTime>(type: "Date", nullable: false),
                    TotalTime = table.Column<int>(type: "int", nullable: false),
                    IsChecked = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_userRequests_Assessments_AssessmentId",
                        column: x => x.AssessmentId,
                        principalTable: "Assessments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_userRequests_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionPages_UserId",
                table: "QuestionPages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailHistory_AssessmentId",
                table: "EmailHistory",
                column: "AssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailHistory_UserId",
                table: "EmailHistory",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_userRequests_AssessmentId",
                table: "userRequests",
                column: "AssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_userRequests_UserId",
                table: "userRequests",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmailHistory_Assessments_AssessmentId",
                table: "EmailHistory",
                column: "AssessmentId",
                principalTable: "Assessments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmailHistory_Users_UserId",
                table: "EmailHistory",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionPages_Users_UserId",
                table: "QuestionPages",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAssessments_AssessmentHistorys_AssessmentHistoryId",
                table: "UserAssessments",
                column: "AssessmentHistoryId",
                principalTable: "AssessmentHistorys",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmailHistory_Assessments_AssessmentId",
                table: "EmailHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_EmailHistory_Users_UserId",
                table: "EmailHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionPages_Users_UserId",
                table: "QuestionPages");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAssessments_AssessmentHistorys_AssessmentHistoryId",
                table: "UserAssessments");

            migrationBuilder.DropTable(
                name: "userRequests");

            migrationBuilder.DropIndex(
                name: "IX_QuestionPages_UserId",
                table: "QuestionPages");

            migrationBuilder.DropIndex(
                name: "IX_EmailHistory_AssessmentId",
                table: "EmailHistory");

            migrationBuilder.DropIndex(
                name: "IX_EmailHistory_UserId",
                table: "EmailHistory");

            migrationBuilder.DropColumn(
                name: "DateOfCompletion",
                table: "UserAssessments");

            migrationBuilder.DropColumn(
                name: "DateOfCreation",
                table: "UserAssessments");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "UserAssessments");

            migrationBuilder.DropColumn(
                name: "NumberOfQuestions",
                table: "UserAssessments");

            migrationBuilder.DropColumn(
                name: "TotalTime",
                table: "UserAssessments");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "QuestionPages");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "EmailHistory");

            migrationBuilder.DropColumn(
                name: "Points",
                table: "AssessmentHistorys");

            migrationBuilder.RenameColumn(
                name: "NumberOfTopics",
                table: "UserAssessments",
                newName: "EmailHistoryId");

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AssessmentHistoryId",
                table: "UserAssessments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AssessmentId",
                table: "EmailHistory",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "EmailHistory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfCompletion",
                table: "Assessments",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Assessments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfQuestions",
                table: "Assessments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfTopics",
                table: "Assessments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfSubmission",
                table: "AssessmentHistorys",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AssessmentHistorys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_UserAssessments_EmailHistoryId",
                table: "UserAssessments",
                column: "EmailHistoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAssessments_AssessmentHistorys_AssessmentHistoryId",
                table: "UserAssessments",
                column: "AssessmentHistoryId",
                principalTable: "AssessmentHistorys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAssessments_EmailHistory_EmailHistoryId",
                table: "UserAssessments",
                column: "EmailHistoryId",
                principalTable: "EmailHistory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
