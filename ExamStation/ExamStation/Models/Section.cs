using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamStation.Models
{
    public class Section
    {
        [Key]
        public int Id { get; set; }
        public string SectionName { get; set; }
        public string Category { get; set; }
        public int Capacity { get; set; }
        public string Class { get; set; }
        public string TeacherName { get; set; }
        public string Note { get; set; }
    }
}
