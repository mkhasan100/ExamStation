using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamStation.Models.ViewModels
{
    public class QuestionGroupListViewModel
    {
        public int? KeywordId { get; set; }
        public string Keyword { get; set; }
        public List<QuestionGroup> QuestionGroupList { get; set; }
    }
   
}
