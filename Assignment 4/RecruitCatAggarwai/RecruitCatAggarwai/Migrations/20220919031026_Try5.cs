using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecruitCatAggarwai.Migrations
{
    public partial class Try5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Industry_Candidate_CandidateId",
                table: "Industry");

            migrationBuilder.DropForeignKey(
                name: "FK_JobTitle_Candidate_CandidateId",
                table: "JobTitle");

            migrationBuilder.DropTable(
                name: "CompanyJobTitle");

            migrationBuilder.DropIndex(
                name: "IX_JobTitle_CandidateId",
                table: "JobTitle");

            migrationBuilder.DropIndex(
                name: "IX_Industry_CandidateId",
                table: "Industry");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "JobTitle");

            migrationBuilder.RenameColumn(
                name: "JobTitleId",
                table: "Company",
                newName: "CandidateId");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Candidate",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CandidateCompany",
                columns: table => new
                {
                    CandidateId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateCompany", x => new { x.CandidateId, x.CompanyId });
                    table.ForeignKey(
                        name: "FK_CandidateCompany_Candidate_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidate",
                        principalColumn: "CandidateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandidateCompany_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CandidateIndustry",
                columns: table => new
                {
                    CandidateId = table.Column<int>(type: "int", nullable: false),
                    IndustryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateIndustry", x => new { x.CandidateId, x.IndustryId });
                    table.ForeignKey(
                        name: "FK_CandidateIndustry_Candidate_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidate",
                        principalColumn: "CandidateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandidateIndustry_Industry_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industry",
                        principalColumn: "IndustryId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_CandidateCompany_CompanyId",
                table: "CandidateCompany",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CandidateIndustry_IndustryId",
                table: "CandidateIndustry",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_CandidateJobTitle_JobTitleId",
                table: "CandidateJobTitle",
                column: "JobTitleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandidateCompany");

            migrationBuilder.DropTable(
                name: "CandidateIndustry");

            migrationBuilder.DropTable(
                name: "CandidateJobTitle");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Candidate");

            migrationBuilder.RenameColumn(
                name: "CandidateId",
                table: "Company",
                newName: "JobTitleId");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "JobTitle",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CompanyJobTitle",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    JobTitleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyJobTitle", x => new { x.CompanyId, x.JobTitleId });
                    table.ForeignKey(
                        name: "FK_CompanyJobTitle_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyJobTitle_JobTitle_JobTitleId",
                        column: x => x.JobTitleId,
                        principalTable: "JobTitle",
                        principalColumn: "JobTitleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobTitle_CandidateId",
                table: "JobTitle",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_Industry_CandidateId",
                table: "Industry",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyJobTitle_JobTitleId",
                table: "CompanyJobTitle",
                column: "JobTitleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Industry_Candidate_CandidateId",
                table: "Industry",
                column: "CandidateId",
                principalTable: "Candidate",
                principalColumn: "CandidateId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobTitle_Candidate_CandidateId",
                table: "JobTitle",
                column: "CandidateId",
                principalTable: "Candidate",
                principalColumn: "CandidateId");
        }
    }
}
