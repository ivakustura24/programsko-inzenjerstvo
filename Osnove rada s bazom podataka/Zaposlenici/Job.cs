using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace EmployeeJobLogic
{
    public class Job
    {
        public int Id { get; set; }
        public string Description { get; set; } 

        public int MinLvl { get; set; }
        public int MaxLvl { get; set; } 

        public Job()
        {

        }
    }
}
