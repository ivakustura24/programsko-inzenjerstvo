using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data;
namespace ADO_Employees
{
    public class PublisherRepository
    {
        public List<Publisher> GetPublishers()
        {
            Database.Instance.Connect();
            List<Publisher> publishers = new List<Publisher>();
            string sql = "SELECT * FROM publishers";
            IDataReader dataReader = Database.Instance.GetReader(sql);
            while (dataReader.Read())
            {
                string pub_id = dataReader["pub_id"].ToString();
                string pub_name = dataReader["pub_name"].ToString();


                Publisher publisher = new Publisher()
                {
                    PubId = pub_id,
                    PubName = pub_name
               
                };
                publishers.Add(publisher);
            }
            dataReader.Close();
            Database.Instance.Dissconnect();
            return publishers;
        }
    }
}
