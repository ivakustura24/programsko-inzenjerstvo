using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data.SqlClient;
using System.Data;
namespace Inventura2
{
    public class InventuraRepository
    {
        private string connectionString = @"Data Source=31.147.204.119\PISERVER,1433; Initial Catalog = Labs; User=labUser; Password = lab2020 ";
        private SqlConnection connection;

        public InventuraRepository()
        {

        }
        private void OtvoriKonekciju()
        {
            connection = new SqlConnection (connectionString);
            connection.Open ();
        }
        private void ZatvoriKonekciju()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }
        public List<InventurniZapis> DohvatiZapise()
        {
            string sql = $"SELECT * FROM InventurniZapisi";
            return DohvatiInventurneZapisePodatci(sql);
        }
        public List<InventurniZapis> DohvatiZapise(string zaduzen)
        {
            string sql = $"SELECT * FROM InventurniZapisi WHERE Zaduzen='{zaduzen}'";
            return DohvatiInventurneZapisePodatci(sql);
        }
        private List<InventurniZapis> DohvatiInventurneZapisePodatci(string sql)
        {
            OtvoriKonekciju();
            List<InventurniZapis> zapisi = new List<InventurniZapis>();
            
            IDataReader dataReader = Database.Instance.GetReader(sql, connection);
            while (dataReader.Read())
            {
                int id = int.Parse(dataReader["Id"].ToString());
                string artikl = dataReader["Artikl"].ToString();
                int kolicina = int.Parse(dataReader["Kolicina"].ToString());
                int stvKolicina = int.Parse(dataReader["StvarnaKolicina"].ToString());
                string zaduzen = dataReader["Zaduzen"].ToString();

                InventurniZapis inventurniZapis = new InventurniZapis()
                {
                    Id = id,
                    Artikl = artikl,
                    Kolicina = kolicina,
                    StvarnaKolicina = stvKolicina,
                    Razlika = stvKolicina - kolicina,
                    Zaduzen = zaduzen
                };
                zapisi.Add(inventurniZapis);

            }
            dataReader.Close();
            ZatvoriKonekciju();
            return zapisi;
        }

        public int DodajZapis(InventurniZapis zapis)
        {
            OtvoriKonekciju();
            string sql = $"INSERT INTO InventurniZapisi (Artikl, Kolicina, StvarnaKolicina, Zaduzen) VALUES ('{zapis.Artikl}',{zapis.Kolicina}, {zapis.StvarnaKolicina}, '{zapis.Zaduzen}')";
            int i = Database.Instance.ExecuteCommand(sql, connection);

            ZatvoriKonekciju();
            return i;
        }
    }
}
