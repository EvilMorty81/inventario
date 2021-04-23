using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNetCore5.Models
{
    public class ContratoServicios
    {
        [Key]
        public int NumContrato { get; set; }
        [Required (ErrorMessage ="Nombre empresa es requerido")]
        public string Empresa { get; set; }
        [Required(ErrorMessage = "Rut contratista es requerido")]
        public string RutContratista { get; set; }
        public string DescServicio { get; set; }
        [Required(ErrorMessage = "Fecha inicio es requerido")]
        public DateTime FechaInicio { get; set; }
        public DateTime FechaTermino { get; set; }
        public string Rut { get; set; }
    }
}
