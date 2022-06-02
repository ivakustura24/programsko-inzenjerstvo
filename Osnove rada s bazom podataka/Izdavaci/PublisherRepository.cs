using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PristupPodatcima;


namespace PublisherTracker
{
    public class PublisherRepository
    {
        public List<Publisher> GetPublisherData(string sql)
        {
           
            Database.Instance.Connect();
            IDataReader dataReader = Database.Instance.GetDataReader(sql);
            List<Publisher> publishers = new List<Publisher>();
            while (dataReader.Read())
            {
                string id = dataReader["pub_id"].ToString();
                string name = dataReader["pub_name"].ToString();
                string city = dataReader["city"].ToString();
                string state = dataReader["state"].ToString();
                string country = dataReader["country"].ToString();

                Publisher publisher = new Publisher()
                {
                    Id = id,
                    Name = name,
                    City = city,
                    State = state,
                    Country = country

                };
                publishers.Add(publisher);

            }
            dataReader.Close();
            Database.Instance.Disconnect();
            return publishers;

            
        }
       

        public List <Publisher> GetPublishers()
        {
            List<Publisher> Publishers = new List<Publisher>();
            string sql = "SELECT * FROM publishers";
            Publishers = GetPublisherData(sql);
            return Publishers;
        }

        

        
     }
 }   

