using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace ADO_Titles
{
    public class TitleRepository
    {
        public List<Title> GetTitles()
        {
            Database.Instance.Connect();
            List<Title> titles = new List<Title>();
            string sql = $"SELECT * FROM titles";
            IDataReader dataReader = Database.Instance.GetReader(sql);
            while (dataReader.Read())
            {
                string title_id = dataReader["title_id"].ToString();
                string btitle = dataReader["title"].ToString();
                string type = dataReader["type"].ToString();
                string pubid = dataReader["pub_id"].ToString();
                DateTime date = DateTime.Parse(dataReader["pubdate"].ToString());

                Title title = new Title()
                {
                    TitleId = title_id,
                    BookTitle = btitle,
                    Type = type,
                    PubId = pubid,
                    PubDate = date
                };
                titles.Add(title);
            }
            dataReader.Close();
            Database.Instance.Disconnect();
            return titles;
        }

        public List<String> GetTitlesType()
        {
            Database.Instance.Connect();
            List<string> types = new List<string>();
            string sql = $"SELECT DISTINCT Type FROM titles";
            IDataReader dataReader = Database.Instance.GetReader(sql);
            while (dataReader.Read())
            {
                string type = dataReader["type"].ToString();
                types.Add(type);
            }
            dataReader.Close();
            Database.Instance.Disconnect();
            return types;
        }

        public int Insert(string title_id, string title, string type, string pub_id )
        {
            Database.Instance.Connect();
            string sql = $"INSERT INTO titles(title_id, title, type, pub_id, pubdate) VALUES ('{title_id}', '{title}', '{type}', '{pub_id}', GETDATE())";
            int i = Database.Instance.ExecuteComand(sql);
            Database.Instance.Disconnect();
            return i;
        }
    }
}
