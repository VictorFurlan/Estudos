using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Contab.Data;

namespace Contab.Models
{
    public class DepartamentDataAccessLayer
    {
        Connection_Query conn = new Connection_Query();

        public IEnumerable<Departament> GetAllDepartaments()
        {
            List<Departament> lstDepartament = new List<Departament>();

            MySqlDataReader rdr = conn.DataReader("spGetAllDepartaments");
            conn.Open();

            while (rdr.Read())
            {
                Departament departament = new Departament();

                departament.ID = Convert.ToInt32(rdr["DepartamentId"]);
                departament.Name = rdr["Name"].ToString();

                lstDepartament.Add(departament);
            }
            conn.Close();
            
        return lstDepartament;
        }
        public void AddDepartaments(Departament departament)
        {
            MySqlCommand cmd = new MySqlCommand("spAddDepartament", conn.Connection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("p_Name", departament.Name);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}