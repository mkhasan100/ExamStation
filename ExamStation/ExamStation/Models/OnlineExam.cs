using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamStation.Models
{
    public class OnlineExam
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        public string ExamTitle { get; set; }
        public string Description { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }
        [DisplayName("Student Group")]
        public string StudentGroup { get; set; }
        public string Subject { get; set; }
        public string Instruction { get; set; }
        [Required]
        [DisplayName("Exam Status")]
        public string ExamStatus { get; set; }
        [Required]
        [DisplayName("Exam Type")]
        public string ExamType { get; set; }
        
        //[DataType(DataType.Time)]
        public string Duration { get; set; }
        [Required]
        [DisplayName("Mark Type")]
        public string MarkType { get; set; }
        [Required]
        [DisplayName("Pass Value")]
        public double PassValue { get; set; }
        [Required]
        [DisplayName("Payment Status")]
        public string PaymentStatus { get; set; }
        public double Cost { get; set; }
        [Required]
        public string Published { get; set; }


    }
}
