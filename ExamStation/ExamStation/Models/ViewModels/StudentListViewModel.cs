using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamStation.Models.ViewModels
{
    public class StudentListViewModel
    {
        [Key]
        public int KeywordId { get; set; }
        public int Keyword { get; set; }
        public List<Student> StudentList { get; set; }
    }
}
