using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace JobEmployeesLogic
{
    public class JobRepository
    {
        public List <Job> GetJobs()
        {
            Database.Instance.Connect();
            string sql = "SELECT * FROM jobs";
            List<Job> jobs = new List<Job>();
            IDataReader dataReader = Database.Instance.GetReader(sql);
            while (dataReader.Read())
            {
                int id = int.Parse(dataReader["job_id"].ToString());
                string description = dataReader["job_desc"].ToString();
                int minlvl =int.Parse( dataReader["min_lvl"].ToString());
                int maxlvl = int.Parse( dataReader["max_lvl"].ToString());
                Job job = new Job()
                {
                    Id= id,
                    Description= description,
                    MinLvl = minlvl,
                    MaxLvl = maxlvl

                };
                jobs.Add(job);
            }

            dataReader.Close();
            Database.Instance.Dissconnect();
            return jobs;
        }

        public void InsertJob(string description, int min, int max)
        {
            Database.Instance.Connect();
            string sql = $"INSERT INTO jobs (job_desc, min_lvl, max_lvl) VALUES ('{description}', {min}, {max})";
            Database.Instance.ExecuteCommand(sql);
            Database.Instance.Dissconnect();

        }
    }
}
