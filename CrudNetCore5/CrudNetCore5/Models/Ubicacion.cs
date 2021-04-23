using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNetCore5.Models
{
    public class Ubicacion
    {
        [Key]
        public int UbicacionId { get; set; }
        [Required(ErrorMessage ="La fecha es un campo requerido")]
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "La fecha de vencimiento es un campo requerido")]
        [Display(Name ="Fecha Vencimiento")]
        public DateTime FechaVenc { get; set; }
        [Required(ErrorMessage = "Detalle es un campo requerido")]
        [StringLength(100)]
        public string Detalle { get; set; }
        public int ItemId { get; set; }
    }
}
