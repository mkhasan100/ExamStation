using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamStation.Models
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }
        public string StudentEmail { get; set; }
        public int ExamId { get; set; }
        public int QuestionBankId { get; set; }
        public string StudentAnswer { get; set; }

    }
}
