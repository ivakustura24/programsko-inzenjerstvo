using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace EmployeeJobLogic
{
    public class JobRepository
    {
        public List <Job> GetJobs()
        {
            Database.Instance.Connect();
            List<Job> jobs = new List<Job>();
            string sql = $"SELECT * FROM jobs";
            IDataReader dataReader = Database.Instance.GetReader(sql);
            while (dataReader.Read())
            {
                int jobid = int.Parse(dataReader["job_id"].ToString());
                string job_desc = dataReader["job_desc"].ToString();
                int min_lvl = int.Parse(dataReader["min_lvl"].ToString());
                int max_lvl = int.Parse(dataReader["max_lvl"].ToString());

                Job job = new Job()
                {
                    Id = jobid, 
                    Description = job_desc,
                    MinLvl = min_lvl,
                    MaxLvl = max_lvl
                };
                jobs.Add(job);
            }
            dataReader.Close();
            Database.Instance.Dissconnect();
            return jobs;
        }
    }
}
