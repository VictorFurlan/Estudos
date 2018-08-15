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
    public class Profession
    {
        string connectionString = "server=127.0.0.1;uid=root;" + "pwd=123456;database=vj";

        public int ProfessionId { get; set; }
        [Required]
        [DisplayName("Cargo")]
        public String ProfName { get; set; }
        public IEnumerable<Profession> GetAllProfessions()
        {
            List<Profession> lstProf = new List<Profession>();

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                //----------------------GET Employee-----------------------------------
                MySqlCommand cmd = new MySqlCommand("spGetAllProfession", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Profession prof = new Profession();

                    prof.ProfessionId = Convert.ToInt32(rdr["ProfessionId"]);
                    prof.ProfName = rdr["ProfName"].ToString();

                    lstProf.Add(prof);
                }
                con.Close();
            }
            return lstProf;
        }
    }
}
