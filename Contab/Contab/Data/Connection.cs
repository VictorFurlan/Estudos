using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Web;

namespace Contab.Data
{
    /// <summary>
    /// This is a class Name "Connection_Class" to perform Insert, Update Delete Serch options
    /// Show Data in DataGridView and also Perform SqlDataReader Options.
    /// </summary>
    public class Connection_Query
    {

        string ConnectionString = "server=127.0.0.1;uid=root;" + "pwd=123456;database=vj";
        MySqlConnection con;

        public MySqlConnection Connection()
        {
            MySqlConnection conn = new MySqlConnection();
            return conn;
        }

        public void Open()
        {
            con = new MySqlConnection(ConnectionString);
            con.Open();
        }


        public void Close()
        {
            con.Close();
        }


        public void ExecuteQueries(string Query_)
        {
            MySqlCommand cmd = new MySqlCommand(Query_, con);
            cmd.ExecuteNonQuery();
        }


        public MySqlDataReader DataReader(string Query_)
        {
            MySqlCommand cmd = new MySqlCommand(Query_, con);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public object ShowDataInGridView(string Query_)
        {
            MySqlDataAdapter dr = new MySqlDataAdapter(Query_, ConnectionString);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }
    }
}
