using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecruitCatAggarwai.Migrations
{
    public partial class Try6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandidateJobTitle");

            migrationBuilder.CreateIndex(
                name: "IX_JobTitle_CandidateId",
                table: "JobTitle",
                column: "CandidateId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobTitle_Candidate_CandidateId",
                table: "JobTitle",
                column: "CandidateId",
                principalTable: "Candidate",
                principalColumn: "CandidateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobTitle_Candidate_CandidateId",
                table: "JobTitle");

            migrationBuilder.DropIndex(
                name: "IX_JobTitle_CandidateId",
                table: "JobTitle");

            migrationBuilder.CreateTable(
                name: "CandidateJobTitle",
                columns: table => new
                {
                    CandidateId = table.Column<int>(type: "int", nullable: false),
                    JobTitleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateJobTitle", x => new { x.CandidateId, x.JobTitleId });
                    table.ForeignKey(
                        name: "FK_CandidateJobTitle_Candidate_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidate",
                        principalColumn: "CandidateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandidateJobTitle_JobTitle_JobTitleId",
                        column: x => x.JobTitleId,
                        principalTable: "JobTitle",
                        principalColumn: "JobTitleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CandidateJobTitle_JobTitleId",
                table: "CandidateJobTitle",
                column: "JobTitleId");
        }
    }
}
