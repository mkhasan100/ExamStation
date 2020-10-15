using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamStation.Models.ViewModels
{
    public class QuestionLevelListViewModel
    {
        public int? KeywordId { get; set; }
        public string Keyword { get; set; }
        public List<QuestionLevel> QuestionLevelList { get; set; }
    }
}
