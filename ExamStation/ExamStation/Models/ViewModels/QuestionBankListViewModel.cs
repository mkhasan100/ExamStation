using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamStation.Models.ViewModels
{
    public class QuestionBankListViewModel
    {
        public int? KeywordId { get; set; }
        public string Keyword { get; set; }
        public int? DificultyLevelId { get; set; }
        public int? QuestionGroupId { get; set; }
        public int? QuestionTypeId { get; set; }
        public List<QuestionBank> QuestionBankList { get; set; }

        
    }
}
