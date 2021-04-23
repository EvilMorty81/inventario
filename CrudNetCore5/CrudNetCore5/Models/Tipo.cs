using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNetCore5.Models
{
    public class Tipo
    {
        [Key]
        public int TipoId { get; set; }
        [Required(ErrorMessage ="Descripción es un campo requerido")]
        [StringLength(100)]
        public string Descripcion { get; set; }
        public int FamiliaId { get; set; }
    }
}
