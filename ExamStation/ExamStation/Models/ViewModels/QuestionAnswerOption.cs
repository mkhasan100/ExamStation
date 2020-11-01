using System.Collections.Generic;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamStation.Models.ViewModels
{
    public class QuestionAnswerOption
    {
        public QuestionBank QuestionBank { get; set; }

        public List<AnswersOption> answersOptionList { get; set; }
    }
}
