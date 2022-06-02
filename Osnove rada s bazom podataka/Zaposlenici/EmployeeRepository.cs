using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace EmployeeJobLogic
{
    public class EmployeeRepository
    {
        public List<Employee> GetEmployees()
        {
            Database.Instance.Connect();
            List<Employee> employees = new List<Employee>();
            string sql = $"SELECT * FROM employee";
            IDataReader dataReader = Database.Instance.GetReader(sql);
            while (dataReader.Read())
            {
                string id =dataReader["emp_id"].ToString();
                string fname = dataReader["fname"].ToString();
                string lname = dataReader["lname"].ToString();
                int jobid = int.Parse(dataReader["job_id"].ToString());
                string pubid = dataReader["pub_id"].ToString();
                DateTime date = DateTime.Parse(dataReader["hire_date"].ToString());

                Employee employee = new Employee()
                {
                    Id = id,
                    Fname = fname,
                    Lname = lname,
                    JobId = jobid,
                    PubId = pubid,
                    HireDate = date
                };
                employees.Add(employee);
                
            }
            dataReader.Close();
            Database.Instance.Dissconnect();
            return employees;
        }

        public int Update (Employee emp, Job job)
        {
            Database.Instance.Connect();
            
            string sql = $"UPDATE employee SET job_id = {job.Id} WHERE emp_id='{emp.Id}'";
            int i = Database.Instance.ExecuteComande(sql);
            Database.Instance.Dissconnect();
            return i;

        }
    }
}
