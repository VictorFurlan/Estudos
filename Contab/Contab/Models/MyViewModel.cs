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
    public class MyViewModel
    {
        public Employee employee { get; set; }
        public List<Employee> lstemployee { get; set; }

        public Departament departments { get; set; }

        public Profession profession { get; set; }

        public Gender gender { get; set; }
        public List<Gender> lstgender { get; set; }
    }
}
