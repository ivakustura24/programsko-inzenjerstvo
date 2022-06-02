using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data;
namespace ADO_Employees
{
    public class EmployeeRepository
    {
        public List<Employee> GetEmployees()
        {
            Database.Instance.Connect();
            List<Employee> employees = new List<Employee>();
            string sql = "SELECT * FROM employee";
            IDataReader dataReader = Database.Instance.GetReader(sql);
            while (dataReader.Read())
            {
                string emp_id = dataReader["emp_id"].ToString();
                string fname = dataReader["fname"].ToString();
                string lname = dataReader["lname"].ToString();
                int jobid = int.Parse(dataReader["job_id"].ToString());
                string pubid = dataReader["pub_id"].ToString();
                DateTime date = DateTime.Parse(dataReader["hire_date"].ToString());

                Employee emp = new Employee()
                {
                    EmpId = emp_id,
                    FName = fname,
                    LName = lname,
                    JobId = jobid,
                    PubId = pubid,
                    HireDate = date
                };
                employees.Add(emp);
            }
            dataReader.Close();
            Database.Instance.Dissconnect();
            return employees;
        }

        public int Insert(string empid, string fname, string lname, int jobid,  string pubid)
        {
            Database.Instance.Connect();
            string sql = $"INSERT INTO employee(emp_id, fname, minit, lname, job_id, job_lvl, pub_id, hire_date) VALUES ('{empid}','{fname}', 'A', '{lname}', {jobid}, 15,'{pubid}', GETDATE())";
            int i = Database.Instance.ExecuteCommand(sql);
            Database.Instance.Dissconnect();
            return i;
        }
    }
}
