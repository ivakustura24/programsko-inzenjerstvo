using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataLayer
{
    public class Database
    {
        private static Database instance;
        private string connectionString = @"Data Source = 31.147.204.119\PISERVER,1433; Initial Catalog = pubs; User = LabUser21; Password=Lab2021";
        private SqlConnection Connection { get; set; }

        public static Database Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Database();
                }
                return instance;
            }
        }
        private Database()
        {

        }
        public void Connect()
        {
            Connection = new SqlConnection(connectionString);
            Connection.Open();
        }
        public void Dissconnect()
        {
            if(Connection.State != ConnectionState.Closed)
            {
                Connection.Close();
            }
        }

        public IDataReader GetReader(string upit)
        {
            SqlCommand cmd = new SqlCommand(upit, Connection);
            return cmd.ExecuteReader();
        }

        public object GetValue (string upit)
        {
            SqlCommand cmd = new SqlCommand(upit, Connection);
            return cmd.ExecuteScalar();
        }
        public int ExecuteCommand (string upit)
        {
            SqlCommand cmd = new SqlCommand(upit, Connection);
            return cmd.ExecuteNonQuery();
        }
    }
}
