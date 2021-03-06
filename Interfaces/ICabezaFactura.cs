using ApiTenStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTenStore.Interfaces
{
    public interface ICabezaFactura
    {
        public Task<(bool isSuccess, int idCabFac)> AddCabezaFactura(CabezaFactura cabezaFactura);
        public Task<bool> UpdateCabezaFactura(int idCabFac, CabezaFactura cabezaFactura);
        public Task<ICollection<CabezaFactura>> GetCabezaFacturas();
        public Task<ICollection<CabezaFactura>> GetCabezaFactura(int idCabFac);
        public Task<bool> DeleteCabezaFactura(int idCabFac);
    }
}
