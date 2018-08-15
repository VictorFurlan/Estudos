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
    public class Gender
    {
        public class GenderObj
        {
            public int GenderId { get; set; }
            [Required]
            [DisplayName("Gênero")]
            public string GenderName { get; set; }
        }
        public IEnumerable<GenderObj> Genderoptions = new List<GenderObj>
        {
            new GenderObj { GenderId = 1, GenderName = "Masculino" },
            new GenderObj { GenderId = 2, GenderName = "Feminino" }
        };
        public int GenderId { get; set; }
    }
}
