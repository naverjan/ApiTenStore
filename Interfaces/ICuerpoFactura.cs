using ApiTenStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTenStore.Interfaces
{
    public interface ICuerpoFactura
    {
        public Task<(bool isSuccess, int idCueFac)> AddCuerpoFactura(CuerpoFactura cuerpoFactura);
        public Task<bool> UpdateCuerpoFactura(int idCueFac, CuerpoFactura cuerpoFactura);
        public Task<ICollection<CuerpoFactura>> GetCuerpoFacturas();
        public Task<ICollection<CuerpoFactura>> GetCuerpoFactura(int idCueFac);
        public Task<bool> DeleteCuerpoFactura(int idCueFac);

    }
}
