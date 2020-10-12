using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExamStation.Models;

namespace ExamStation.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext (DbContextOptions<AppDBContext> options)
            : base(options)
        {
        }

        public DbSet<ExamStation.Models.Instruction> Instruction { get; set; }

        public DbSet<ExamStation.Models.QuestionBank> QuestionBank { get; set; }
    }
}
