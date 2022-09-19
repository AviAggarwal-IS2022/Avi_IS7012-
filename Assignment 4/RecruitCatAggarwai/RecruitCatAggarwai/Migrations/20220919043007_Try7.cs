using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecruitCatAggarwai.Migrations
{
    public partial class Try7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Industry",
                newName: "Company_Id");

            migrationBuilder.RenameColumn(
                name: "CandidateId",
                table: "Industry",
                newName: "Candidate_Id");

            migrationBuilder.RenameColumn(
                name: "IndustryId",
                table: "Company",
                newName: "Industry_Id");

            migrationBuilder.RenameColumn(
                name: "CandidateId",
                table: "Company",
                newName: "Candidate_Id");

            migrationBuilder.RenameColumn(
                name: "JobTitleId",
                table: "Candidate",
                newName: "JobTitle_Id");

            migrationBuilder.RenameColumn(
                name: "IndustryId",
                table: "Candidate",
                newName: "Industry_Id");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Candidate",
                newName: "Company_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Company_Id",
                table: "Industry",
                newName: "CompanyId");

            migrationBuilder.RenameColumn(
                name: "Candidate_Id",
                table: "Industry",
                newName: "CandidateId");

            migrationBuilder.RenameColumn(
                name: "Industry_Id",
                table: "Company",
                newName: "IndustryId");

            migrationBuilder.RenameColumn(
                name: "Candidate_Id",
                table: "Company",
                newName: "CandidateId");

            migrationBuilder.RenameColumn(
                name: "JobTitle_Id",
                table: "Candidate",
                newName: "JobTitleId");

            migrationBuilder.RenameColumn(
                name: "Industry_Id",
                table: "Candidate",
                newName: "IndustryId");

            migrationBuilder.RenameColumn(
                name: "Company_Id",
                table: "Candidate",
                newName: "CompanyId");
        }
    }
}
