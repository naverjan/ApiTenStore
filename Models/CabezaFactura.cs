using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTenStore.Models
{
    public class CabezaFactura
    {
        [Key]
        public int id { get; set; }
        public string consecutivo { get; set; }
        public int idTercero { get; set; }
    }
}
