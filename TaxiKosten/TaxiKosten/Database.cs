using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiKosten
{
    internal class Database
    {
        /// <summary>
        /// een functie om connectie te maken met de database.
        /// </summary>
        /// <returns></returns>
        public static SqlConnection OpenSqlConnection()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS01\MSSQL\DATA\taxiKosten.mdf;Integrated Security=True;Connect Timeout=30");
            connection.Open();

            return connection;
        }

        /// <summary>
        /// een functie om een dataset te krijgen van een select String.
        /// </summary>
        /// <param name="query"></param>
        /// <returns>Dataset met informatie</returns>
        public static DataSet krijgDataVanDatabase(string query)
        {
            DataSet results = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(query, OpenSqlConnection());
            adapter.Fill(results);

            return results;
        }
    }
}
