using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNetCore5.Models
{
    public class Sector
    {
        [Key]
        public int SectorId { get; set; }
        [Required(ErrorMessage ="El campo descripción es requerido")]
        [StringLength(100)]
        public string Descripcion { get; set; }
        public int CodCaja { get; set; }
        public int UbicacionId { get; set; }
    }
}
