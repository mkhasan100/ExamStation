using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamStation.Models.ViewModels
{
    public class QuestionTypeListViewModel
    {
        public int? KeywordId { get; set; }
        public string Keyword { get; set; }
        public int? QuestionTypeId { get; set; }
        public List<QuestionType> QuestionTypeList { get; set; }
    }
}
