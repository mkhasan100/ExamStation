using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamStation.Models
{
    public class MenuMaster
    {
        [Key]
        public int ID { get; set; }
        public int ParentID { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public int SerialNo { get; set; }
        public int isActive { get; set; }
        public DateTime CreatedDate { get; set; }

        public int isAdmin { get; set; }
    }
}
