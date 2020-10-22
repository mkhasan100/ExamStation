using ExamStation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamStation.Services
{
    public interface IMenuMasterService
    {
        IEnumerable<MenuMaster> GetMenuMaster();
    }
}
