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

        public DbSet<ExamStation.Models.QuestionBank> QuestionBank { get; set; }





    }
}

