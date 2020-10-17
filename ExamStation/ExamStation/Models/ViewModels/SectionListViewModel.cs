using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamStation.Models.ViewModels
{
    public class SectionListViewModel
    {
        public int KeywordId { get; set; }
        public int Keyword { get; set; }
        public List<Section> SectionList { get; set; }
    }
}
