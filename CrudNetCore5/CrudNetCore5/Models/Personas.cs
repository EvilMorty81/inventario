using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNetCore5.Models
{
    public class Personas
    {
        [Key]
        public string Rut { get; set; }

        public string Nombres { get; set; }

        public string Paterno { get; set; }

        public string Materno { get; set; }

        public string Email { get; set; }

    }
}
