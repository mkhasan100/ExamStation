using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamStation.Models.ViewModels
{
    public class StudentCreateViewModel
    {
        [Key]
        public int StudentId { get; set; }
        [DisplayName("Student Name")]
        public string StudentName { get; set; }
        public string Guardian { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Date Of Birth")]
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        [DisplayName("Blood Group")]
        public string BloodGroup { get; set; }
        public string Religion { get; set; }
        public string Email { get; set; }
        public int? Phone { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }
        public string Group { get; set; }
        [DisplayName("Optional Subject")]
        public string OptionalSubject { get; set; }
        [DisplayName("Register No")]
        public int? RegisterNo { get; set; }
        public int Roll { get; set; }
        public IFormFile Photo { get; set; }
        [DisplayName("Extra Activities")]
        public string ExtraActivities { get; set; }
        public string Remarks { get; set; }
    }
}
