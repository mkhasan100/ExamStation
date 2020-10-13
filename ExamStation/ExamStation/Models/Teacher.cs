using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamStation.Models
{
    public class Teacher    
    {
    [Key]
    public int TeacherId { get; set; }
    [DisplayName("Teacher Name")]
    public string TeacherName { get; set; }
    public string Designation { get; set; }
    [DataType(DataType.Date)]
    [DisplayName("Date Of Birth")]
    public DateTime DateOfBirth { get; set; }
    public string Gender { get; set; }
    public string Religion { get; set; }
    public string Email { get; set; }
    public int? Phone { get; set; }
    public string Address { get; set; }
    [DataType(DataType.Date)]
    [DisplayName("Joining Date")]
    public DateTime JoiningDate { get; set; }
    public byte[] Photo { get; set; }
}
}
