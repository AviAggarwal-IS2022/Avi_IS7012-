﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecruitCatAggarwai.Data;

#nullable disable

namespace RecruitCatAggarwai.Migrations
{
    [DbContext(typeof(RecruitCatAggarwaiContext))]
    [Migration("20220919005557_Try4")]
    partial class Try4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CompanyIndustry", b =>
                {
                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("IndustryId")
                        .HasColumnType("int");

                    b.HasKey("CompanyId", "IndustryId");

                    b.HasIndex("IndustryId");

                    b.ToTable("CompanyIndustry");
                });

            modelBuilder.Entity("CompanyJobTitle", b =>
                {
                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("JobTitleId")
                        .HasColumnType("int");

                    b.HasKey("CompanyId", "JobTitleId");

                    b.HasIndex("JobTitleId");

                    b.ToTable("CompanyJobTitle");
                });

            modelBuilder.Entity("RecruitCatAggarwai.Models.Candidate", b =>
                {
                    b.Property<int?>("CandidateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("CandidateId"), 1L, 1);

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpectedStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IndustryId")
                        .HasColumnType("int");

                    b.Property<int?>("JobTitleId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("TargetSalary")
                        .HasColumnType("real");

                    b.Property<float>("YearsOfExperience")
                        .HasColumnType("real");

                    b.HasKey("CandidateId");

                    b.ToTable("Candidate");
                });

            modelBuilder.Entity("RecruitCatAggarwai.Models.Company", b =>
                {
                    b.Property<int?>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("CompanyId"), 1L, 1);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpectedStartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IndustryId")
                        .HasColumnType("int");

                    b.Property<string>("IndustryType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("JobTitleId")
                        .HasColumnType("int");

                    b.Property<float>("MaxSalary")
                        .HasColumnType("real");

                    b.Property<float>("MinSalary")
                        .HasColumnType("real");

                    b.Property<string>("PositionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("RecruitCatAggarwai.Models.Industry", b =>
                {
                    b.Property<int?>("IndustryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("IndustryId"), 1L, 1);

                    b.Property<int?>("CandidateId")
                        .HasColumnType("int");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("IndustryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IndustryType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoOfCompanies")
                        .HasColumnType("int");

                    b.HasKey("IndustryId");

                    b.HasIndex("CandidateId");

                    b.ToTable("Industry");
                });

            modelBuilder.Entity("RecruitCatAggarwai.Models.JobTitle", b =>
                {
                    b.Property<int?>("JobTitleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("JobTitleId"), 1L, 1);

                    b.Property<int?>("CandidateId")
                        .HasColumnType("int");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("JobType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Job_Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("MaxSalary")
                        .HasColumnType("real");

                    b.Property<float>("MinSalary")
                        .HasColumnType("real");

                    b.Property<float?>("YearsofExperienceReqd")
                        .HasColumnType("real");

                    b.HasKey("JobTitleId");

                    b.HasIndex("CandidateId");

                    b.ToTable("JobTitle");
                });

            modelBuilder.Entity("CompanyIndustry", b =>
                {
                    b.HasOne("RecruitCatAggarwai.Models.Company", null)
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecruitCatAggarwai.Models.Industry", null)
                        .WithMany()
                        .HasForeignKey("IndustryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CompanyJobTitle", b =>
                {
                    b.HasOne("RecruitCatAggarwai.Models.Company", null)
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecruitCatAggarwai.Models.JobTitle", null)
                        .WithMany()
                        .HasForeignKey("JobTitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RecruitCatAggarwai.Models.Industry", b =>
                {
                    b.HasOne("RecruitCatAggarwai.Models.Candidate", null)
                        .WithMany("Industry")
                        .HasForeignKey("CandidateId");
                });

            modelBuilder.Entity("RecruitCatAggarwai.Models.JobTitle", b =>
                {
                    b.HasOne("RecruitCatAggarwai.Models.Candidate", null)
                        .WithMany("JobTitle")
                        .HasForeignKey("CandidateId");
                });

            modelBuilder.Entity("RecruitCatAggarwai.Models.Candidate", b =>
                {
                    b.Navigation("Industry");

                    b.Navigation("JobTitle");
                });
#pragma warning restore 612, 618
        }
    }
}