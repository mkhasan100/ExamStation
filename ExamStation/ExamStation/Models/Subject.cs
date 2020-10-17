using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamStation.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        public string ClassName  { get; set; }
        public string TeacherName { get; set; }
        public string Type { get; set; }
        public int PassMark { get; set; }
        public string FinalMark { get; set; }
        public string SubjectName { get; set; }
        public string SubjectAuthor { get; set; }
        public string SubjectCode { get; set; }
    }
}
