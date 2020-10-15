using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamStation.Models.ViewModels
{
    public class ParentListViewModel
    {
        public int? KeywordId { get; set; }
        public string Keyword { get; set; }
        public List<Parent> ParentList { get; set; }
    }
}
