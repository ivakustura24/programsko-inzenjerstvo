using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PristupPodatcima;

namespace TitleLogic
{
    public class TitleRepository
    {
        public List<Title> GetTitlesData(string sql)
        {
            Database.Instance.Connect();
            IDataReader dataReader = Database.Instance.GetDataReader(sql);
            List<Title> titles = new List<Title>();
            while(dataReader.Read())
            {
                string id = dataReader["title_id"].ToString();
                string name = dataReader["title"].ToString();
                string type = dataReader["type"].ToString();
                string publisher_id = dataReader["pub_id"].ToString();
                DateTime publishDate = DateTime.Parse(dataReader["pubdate"].ToString());

                Title title = new Title()
                {
                    Id = id,
                    Name = name,
                    Type = type,
                    PublisherId = publisher_id,
                    PublishDate = publishDate
                };
                titles.Add(title);
            }
            dataReader.Close();
            Database.Instance.Disconnect();
            return titles;
        }


        public List<Title> GetTitles()
        {
            string sql = "SELECT * FROM titles";
            List<Title> titles = new List<Title>();
            titles = GetTitlesData(sql);
            return titles;

        }
        public List<Title> GetTitles(string pub_id)
        {
            string sql = $"SELECT * FROM titles WHERE pub_id ='{pub_id}'";
            List<Title> titles = new List<Title>();
            titles = GetTitlesData(sql);
            return titles;
        }

        public int InsertTitle (string id, string name, string type, string pubid)
        {
            
            Database.Instance.Connect();
            string sql = $"INSERT INTO titles (title_id, title, type, pub_id, pubdate)  VALUES ('{id}', '{name}', '{type}', '{pubid}', GETDATE() )";

            int i = Database.Instance.ExecuteCommand(sql);
           
            Database.Instance.Disconnect(); 
            return i;

        }
    }
}
           
