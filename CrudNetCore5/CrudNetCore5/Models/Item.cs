using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNetCore5.Models
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        [Required]
        [StringLength(30)]
        public string Marca { get; set; }
        [Required (ErrorMessage ="El nombre del producto es obligatorio")]
        [StringLength(30)]
        public string NombreProd { get; set; }
        public string DescripcionProd { get; set; }
        [Required(ErrorMessage = "El Stock es obligatorio")]
        public int Stock { get; set; }
        public int NroSerie { get; set; }
        public string Ram { get; set; }
        [Required(ErrorMessage = "El código inventario es obligatorio")]
        [Display(Name="Código Inventario")]
        public int CodigoInventario { get; set; }
        public string Procesador { get; set; }
        public string DiscoDuro { get; set; }
        public string SistemaOper { get; set; }
        public int TipoId { get; set; }
        public int AsignarId { get; set; }
    }
}
