using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamStation.Models
{
    public class AnswersOption
    {
        public AnswersOption()
        {
            IsAnswer = 0;
        }

        [Key]
        public int Id { get; set; }
        public virtual QuestionBank QuestionBank { get; set; }
        public string Option { get; set; }
        public int IsAnswer { get; set; }
    }
}
