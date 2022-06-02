using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data;

namespace JobEmployeesLogic
{
    public class EmployeeRepository
    {
        public List <Employee> GetEmployees(int job_id)
        {
            Database.Instance.Connect();
            List<Employee> employees = new List<Employee>();
            string sql = $"SELECT * FROM employee WHERE job_id = {job_id}";
            IDataReader dataReader = Database.Instance.GetReader(sql);
            while (dataReader.Read())
            {
                string id = dataReader["emp_id"].ToString();
                string fname = dataReader["fname"].ToString();
                string lname = dataReader["lname"].ToString();
                int jobid = int.Parse(dataReader["job_id"].ToString());
                string pubid = dataReader["pub_id"].ToString();
                DateTime date = DateTime.Parse(dataReader["hire_date"].ToString());

                Employee employee = new Employee()
                {
                    Id = id,
                    FName = fname,
                    LName = lname,
                    JobId = jobid,
                    PublisherId = pubid,
                    HireDate = date
                };
                employees.Add(employee);
            }
            dataReader.Close();
            Database.Instance.Dissconnect();
            return employees;
       }
    }
}
