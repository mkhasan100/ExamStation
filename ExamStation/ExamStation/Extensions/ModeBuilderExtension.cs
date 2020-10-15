using ExamStation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamStation.Extesions
{
    public static class ModeBuilderExtension
    {
        public static void Seed(this ModelBuilder modeBuilder)
        {
            modeBuilder.Entity<QuestionGroup>().HasData(
                new QuestionGroup {Id = 1, Title = "Science"},
                new QuestionGroup {Id = 2, Title = "Math" },
                new QuestionGroup {Id = 3, Title = "Chemistry" },
                new QuestionGroup {Id = 4, Title = "General Knowledge" },
                new QuestionGroup {Id = 5, Title = "Computer Science" }
            );
        }
    }
}
    