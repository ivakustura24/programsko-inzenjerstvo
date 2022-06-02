using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PristupPodatcima
{
    public class Database
    {
        private static Database instance;
        private string connectionString= @"Data Source = 31.147.204.119\PISERVER,1433; Initial Catalog = pubs; User=LabUser21; Password=Lab2021";

        private SqlConnection Connection { get; set; }

        public void Connect()
        {
            Connection = new SqlConnection(connectionString);
            Connection.Open();
        }
        
        public void Disconnect()
        {
            if(Connection.State != ConnectionState.Closed)
            {
                Connection.Close();
            }
        }

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

        public IDataReader GetDataReader (string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            return command.ExecuteReader();
        }

        public object GetValue(string sqlUpit)
        {
            SqlCommand command= new SqlCommand(sqlUpit, Connection);
            return command.ExecuteScalar();
        }

        public int ExecuteCommand(string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            return command.ExecuteNonQuery();
        }
    }
}
