using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataLayer;

namespace ADO_Employees
{
    public class JobRepository
    {
        public List<Job> GetJobs()
        {
            Database.Instance.Connect();
            List<Job> jobs = new List<Job>();
            string sql = $"SELECT * FROM jobs";
            IDataReader dataReader = Database.Instance.GetReader(sql);
            while (dataReader.Read())
            {
                int job_id = int.Parse(dataReader["job_id"].ToString());
                string job_desc = dataReader["job_desc"].ToString();
                Job job = new Job()
                {
                    JobId = job_id,
                    JobDesc = job_desc,
                  
                };
                jobs.Add(job);
            }
            dataReader.Close();
            Database.Instance.Dissconnect();
            return jobs;
        }
    }
}
