using System.Data.SqlClient;
using System.Configuration;
using System;
using System.Data;

namespace _3SharpUzduotisSuDB
{
    class DatabaseInterface : IDisposable
    {
        static private SqlConnection cn = new SqlConnection();

        private static DatabaseInterface instance;

        private DatabaseInterface() { }

        public static DatabaseInterface Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseInterface();
                    cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Vartotojas\Documents\KaraiIrMusiai.mdf;Integrated Security=True;Connect Timeout=30";
                    cn.Open();
                }
                return instance;
            }
        }

        public void Dispose()
        {
            cn.Close();
            instance = null;
        }

        void InsertNewCountry(string countryName, DateTime countryStart)
        {
            SqlCommand insert = new SqlCommand();
            insert.Connection = cn;
            insert.CommandType = System.Data.CommandType.Text;
            insert.CommandText = @"INSERT INTO Valstybe (Pavadinimas, Susikure) VALUES (@PAV, @DAT)";

            insert.Parameters.Add(new SqlParameter("@PAV", SqlDbType.NVarChar, 50, "Pavadinimas"));
            insert.Parameters.Add(new SqlParameter("@DAT", SqlDbType.DateTime, 50, "Susikure"));


        }

    }
}
