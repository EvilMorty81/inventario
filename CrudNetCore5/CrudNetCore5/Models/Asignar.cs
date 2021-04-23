using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNetCore5.Models
{
    public class Asignar
    {
        [Key]
        public int AsignarId { get; set; }
        [Required(ErrorMessage ="La fecha es un campo requerido")]
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "La fecha de vencimiento es un campo requerido")]
        public DateTime FechaVenc { get; set; }
        [Required(ErrorMessage = "La cantidad es un campo requerido")]
        public int Cantidad { get; set; }
        public string DescAsignacion { get; set; }
        public int Rut { get; set; }
    }
}
