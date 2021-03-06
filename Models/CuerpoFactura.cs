using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTenStore.Models
{
    public class CuerpoFactura
    {
        [Key]
        public int id { get; set; }
        public int idCabeza { get; set; }
        public int idProducto { get; set; }
        public float valorUni { get; set; }
        public float valorNet { get; set; }
        public float valorIva { get; set; }
        public float valorTotal { get; set; }
        public DateTime fechaEmision { get; set; }
    }
}
