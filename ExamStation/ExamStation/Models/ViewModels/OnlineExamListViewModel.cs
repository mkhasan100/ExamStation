using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamStation.Models.ViewModels
{
    public class OnlineExamListViewModel
    {
        public int? KeywordId { get; set; }
        public string Keyword { get; set; }
        public List<OnlineExam> OnlineExamList { get; set; }
    }
}
