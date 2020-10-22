using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamStation.Models
{
    public class TakeExamMapper
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} is required.")]
        public int ExamId { get; set; }
        [Required(ErrorMessage = "{0} is required.")]
        public int QuestionBankId { get; set; }
    }
}
