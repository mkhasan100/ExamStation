using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamStation.Models.ViewModels
{
    public class ParentCreateViewModel
    {
        [Key]
        public int GuardianId { get; set; }
        [DisplayName("Guardian Name")]
        public string GuardianName { get; set; }
        [DisplayName("Father Name")]
        public string FatherName { get; set; }
        [DisplayName("Mother Name")]
        public string MotherName { get; set; }
        [DisplayName("Father Profession")]
        public string FatherProfession { get; set; }
        [DisplayName("Mother Profession")]
        public string MotherProfession { get; set; }
        public string Email { get; set; }
        public int? Phone { get; set; }
        public string Address { get; set; }
        public IFormFile Photo { get; set; }
    }
}
