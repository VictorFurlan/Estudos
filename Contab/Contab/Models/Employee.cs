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
        [Required]
        [DisplayName("Gênero")]
        public int Gender { get; set; }
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
        [Required]
        [DisplayName("Departamento")]
        public int Departament { get; set; }
        [Required]
        [DisplayName("Cargo")]
        public int Profession { get; set; }

    }
}
