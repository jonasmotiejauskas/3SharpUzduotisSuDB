﻿using System.Data.SqlClient;
using System.Configuration;
using System;
using System.Data;
using System.Collections.Generic;

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
        void IDisposable.Dispose()
        {
            cn.Close();
            instance = null;
        }

        public void InsertNewCountry(string countryName, DateTime countryStart)
        {
            SqlCommand insert = new SqlCommand();
            insert.Connection = cn;
            insert.CommandType = System.Data.CommandType.Text;
            insert.CommandText = @"INSERT INTO ValstybeSet (Pavadinimas, Susikure) VALUES (@PAV, @DAT)";

            insert.Parameters.Add(new SqlParameter("@PAV", SqlDbType.NVarChar, 20, "Pavadinimas"));
            insert.Parameters.Add(new SqlParameter("@DAT", SqlDbType.DateTime, 20, "Susikure"));

            SqlDataAdapter da = new SqlDataAdapter("Select Id, Pavadinimas, Susikure FROM ValstybeSet", cn);
            da.InsertCommand = insert;

            DataSet ds = new DataSet();
            da.Fill(ds, "ValstybeSet");

            DataRow newRow = ds.Tables[0].NewRow();
            newRow["Pavadinimas"] = countryName;
            newRow["Susikure"] = countryStart;
            ds.Tables[0].Rows.Add(newRow);

            da.Update(ds.Tables[0]);
            da.Dispose();
        }

        public List<string> getAllCountryNames()
        {
            List<string> allNames = new List<string>();
            SqlDataAdapter da = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT Pavadinimas FROM ValstybeSet", cn);

            da.SelectCommand = command;

            DataSet ds = new DataSet();
            da.Fill(ds, "ValstybeSet");

            da.Dispose();

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                allNames.Add(item["Pavadinimas"].ToString());
            }
            return allNames;
        }

        public void DeleteCountry(string name)
        {
            SqlCommand delete = new SqlCommand();
            delete.Connection = cn;
            delete.CommandType = System.Data.CommandType.Text;
            delete.CommandText = "DELETE FROM ValstybeSet WHERE Pavadinimas = @PAV";

            delete.Parameters.AddWithValue("@PAV", name);

            SqlDataAdapter da = new SqlDataAdapter("Select Pavadinimas FROM ValstybeSet", cn);
            da.DeleteCommand = delete;

            DataSet ds = new DataSet();
            da.Fill(ds, "ValstybeSet");

            ds.Tables[0].Rows[0].Delete();

            da.Update(ds.Tables[0]);
            da.Dispose();
        }

        public void UpdateCountrysName(string oldName, string newName)
        {
            SqlCommand update = new SqlCommand();
            update.Connection = cn;
            update.CommandType = System.Data.CommandType.Text;
            update.CommandText = "UPDATE ValstybeSet SET Pavadinimas = @NEWPAV WHERE Pavadinimas = @PAV";

            update.Parameters.AddWithValue("@PAV", oldName);
            update.Parameters.Add(new SqlParameter("@NEWPAV", SqlDbType.NVarChar, 20, "Pavadinimas"));

            SqlDataAdapter da = new SqlDataAdapter("Select Pavadinimas FROM ValstybeSet", cn);
            da.UpdateCommand = update;

            DataSet ds = new DataSet();
            da.Fill(ds, "ValstybeSet");

            ds.Tables[0].Rows[0]["Pavadinimas"] = newName;

            da.Update(ds.Tables[0]);
            da.Dispose();
        }
    }
}
