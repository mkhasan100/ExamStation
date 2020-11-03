using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using ExamStation.Areas.Identity.Data;
using ExamStation.Models;
using ExamStation.Extesions;

namespace ExamStation.Data
{
    public class ExamStationDbContext : IdentityDbContext<ExamStationUser>
    {
        public ExamStationDbContext()
        {

        }
        public ExamStationDbContext(DbContextOptions<ExamStationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                var connectionString = configuration.GetConnectionString("ExamStationConnection");

                optionsBuilder.UseSqlServer(connectionString);
            }
        }


        public DbSet<ExamStation.Models.Event> Event { get; set; }

        public DbSet<ExamStation.Models.Notice> Notice { get; set; }

        public DbSet<ExamStation.Models.OnlineExam> OnlineExam { get; set; }

        public DbSet<ExamStation.Models.Parent> Parent { get; set; }

        public DbSet<ExamStation.Models.QuestionGroup> QuestionGroup { get; set; }

        public DbSet<ExamStation.Models.QuestionLevel> QuestionLevel { get; set; }

        public DbSet<ExamStation.Models.Student> Student { get; set; }

        public DbSet<ExamStation.Models.Teacher> Teacher { get; set; }

        public DbSet<ExamStation.Models.Instruction> Instruction { get; set; }

        public DbSet<ExamStation.Models.QuestionBank> QuestionBank { get; set; }

        public DbSet<ExamStation.Models.QuestionType> QuestionType { get; set; }

        public DbSet<ExamStation.Models.Class> Class { get; set; }

        public DbSet<ExamStation.Models.Subject> Subject { get; set; }

        public DbSet<ExamStation.Models.Section> Section { get; set; }

        public DbSet<ExamStation.Models.TakeExamMapper> TakeExamMapper { get; set; }

        public DbSet<MenuMaster> MenuMaster { get; set; }

        public DbSet<ExamStation.Models.Answer> Answers { get; set; }

        public DbSet<ExamStation.Models.AnswersOption> AnswersOptions { get; set; }




    }
}

