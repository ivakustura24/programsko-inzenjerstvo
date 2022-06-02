using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataLayer;

namespace ADO_Titles
{
    public class PublisherRepository
    {
        public List <Publisher> GetPublisher()
        {
            Database.Instance.Connect();
            List<Publisher> publishers = new List<Publisher>();
            string sql = $"SELECT * FROM publishers";
            IDataReader dataReader = Database.Instance.GetReader(sql);
            while (dataReader.Read())
            {
                string pubid = dataReader["pub_id"].ToString();
                string pubname = dataReader["pub_name"].ToString();

                Publisher pub = new Publisher()
                {
                    PubId = pubid,
                    PubName = pubname
                };
                publishers.Add(pub);
            }
            dataReader.Close();
            Database.Instance.Disconnect();
            return publishers;
        }
    }
}
