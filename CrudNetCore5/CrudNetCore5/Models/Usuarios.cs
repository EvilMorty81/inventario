using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNetCore5.Models
{
    public class Usuarios
    {
        [Key]
        [Display(Name ="Número")]
        public int Numero { get; set; }
        public string Vigente { get; set; }
        public string Rut { get; set; }
    }
}
