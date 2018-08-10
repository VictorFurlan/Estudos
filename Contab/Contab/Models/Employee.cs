using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Contab.Models
{
    public class Employee
    {
        public int ID { get; set; }
        [Required]
        [DisplayName("Nome")]
        public string Name { get; set; }

        public int GenderId { get; set; }
        [Required]
        [DisplayName("Gênero")]
        public string GenderName { get; set; }

        [Required]
        [DisplayName("Salário")]
        [DataType(DataType.Currency)]
        public float Salary { get; set; }
        [Required]
        [DisplayName("E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DisplayName("Telefone")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        public int DepartamentId { get; set; }
        [Required]
        [DisplayName("Departamento")]
        public string DepartamentName { get; set; }


        public int ProfessionId { get; set; }
        [Required]
        [DisplayName("Cargo")]
        public String ProfessionName { get; set; }

    }
}
