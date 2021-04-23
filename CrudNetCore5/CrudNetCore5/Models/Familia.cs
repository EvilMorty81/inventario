using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNetCore5.Models
{
    public class Familia
    {
        [Key]
        public int FamiliaId { get; set; }
        [Required(ErrorMessage ="Este campo es requerido")]
        [StringLength(100)]
        public string DescFamilia { get; set; }
    }
}
