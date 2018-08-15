using Microsoft.AspNetCore.Mvc.Rendering;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Contab.Models
{
    public class Departament
    {
        string connectionString = "server=127.0.0.1;uid=root;" + "pwd=123456;database=vj";

        public int DepartamentId { get; set; }
        [DisplayName("Departamento")]
        public string DepartName { get; set; }
        public IEnumerable<Departament> GetAllDepartaments()
        {
            List<Departament> lstDepart = new List<Departament>();

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                //----------------------GET Employee-----------------------------------
                MySqlCommand cmd = new MySqlCommand("spGetAllDepartament", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Departament depart = new Departament();

                    depart.DepartamentId = Convert.ToInt32(rdr["DepartamentId"]);
                    depart.DepartName = rdr["DepartName"].ToString();

                    lstDepart.Add(depart);
                }
                con.Close();
            }
            return lstDepart;
        }
    }
}
