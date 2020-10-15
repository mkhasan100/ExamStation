using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamStation.Models
{
    public class QuestionBank
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Question Group")]
        public string QuestionGroup { get; set; }
        [DisplayName("Difficulty Level")]
        public string DifficultyLevel { get; set; }
        [Required]
        public string Question { get; set; }
        public string Explanation { get; set; }
        public byte[] Upload { get; set; }
        public string Hints { get; set; }
        public double Mark { get; set; }
        [DisplayName("Question Type")]
        public string QuestionType { get; set; }
    }
}
