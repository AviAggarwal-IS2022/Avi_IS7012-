using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecruitCatAggarwai.Migrations
{
    public partial class Try2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "JobTitle",
                newName: "Job_Title");

            migrationBuilder.AddColumn<int>(
                name: "CandidateId",
                table: "JobTitle",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "JobTitle",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CandidateId",
                table: "Industry",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Industry",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CandidateId",
                table: "Company",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IndustryId",
                table: "Company",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "JobTitleId",
                table: "Company",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Candidate",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IndustryId",
                table: "Candidate",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "JobTitleId",
                table: "Candidate",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CandidateId",
                table: "JobTitle");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "JobTitle");

            migrationBuilder.DropColumn(
                name: "CandidateId",
                table: "Industry");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Industry");

            migrationBuilder.DropColumn(
                name: "CandidateId",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "IndustryId",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "JobTitleId",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "IndustryId",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "JobTitleId",
                table: "Candidate");

            migrationBuilder.RenameColumn(
                name: "Job_Title",
                table: "JobTitle",
                newName: "Title");
        }
    }
}
