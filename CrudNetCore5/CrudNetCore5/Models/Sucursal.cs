using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNetCore5.Models
{
    public class Sucursal
    {
        [Key]
        public int CodCaja { get; set; }
        [Required(ErrorMessage ="El nombre de la caja es un campo requerido")]
        [StringLength(30)]
        [Display(Name ="Nombre Caja")]
        public string NombreCaja { get; set; }
        
    }
}
