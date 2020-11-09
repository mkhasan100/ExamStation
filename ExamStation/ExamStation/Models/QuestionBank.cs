using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExamStation.Models
{
    public class QuestionBank
    {
        [Key]
        public int Id { get; set; }
        public virtual QuestionGroup  QuestionGroup{ get; set; }
        [DisplayName("Difficulty Level")]
        public int? DifficultyLevelId { get; set; }
        [NotMapped]
        public string DifficultyLevel { get; set; }
        [Required]
        public string Question { get; set; }
        public string Explanation { get; set; }
        public byte[] Upload { get; set; }
        public string Hints { get; set; }
        public double Mark { get; set; }
        [NotMapped]
        [DisplayName("Question Type")]
        public string QuestionType { get; set; }

        public int QuestionTypeId { get; set; }
        public int? TotalOption { get; set; }
        [NotMapped]
        public string QuestionGroupName { get; set; }

        [NotMapped]
        public string Answers { get; set; }

    }
}
