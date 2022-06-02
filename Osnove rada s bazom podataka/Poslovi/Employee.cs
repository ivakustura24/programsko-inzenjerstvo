using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobEmployeesLogic
{
    public class Employee
    {
        public string Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int JobId { get; set; }

        public string PublisherId { get; set; }
        public DateTime HireDate { get; set; }

        public Employee()
        {

        }
    }
}
