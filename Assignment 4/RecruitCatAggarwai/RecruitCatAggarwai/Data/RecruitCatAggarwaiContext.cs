using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatAggarwai.Models;

namespace RecruitCatAggarwai.Data
{
    public class RecruitCatAggarwaiContext : DbContext
    {
        public RecruitCatAggarwaiContext (DbContextOptions<RecruitCatAggarwaiContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatAggarwai.Models.Candidate> Candidate { get; set; } = default!;

        public DbSet<RecruitCatAggarwai.Models.Company> Company { get; set; }

        public DbSet<RecruitCatAggarwai.Models.Industry> Industry { get; set; }

        public DbSet<RecruitCatAggarwai.Models.JobTitle> JobTitle { get; set; }
    }
}
