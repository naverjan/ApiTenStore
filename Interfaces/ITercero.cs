using ApiTenStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTenStore.Interfaces
{
    public interface ITercero
    {
        public (int status, string message) AddTercero(Tercero tercero);
        public (int status, string message) UpdateTercero(int idTercero, Tercero tercero);
        public (int status, string message, List<Tercero>) GetTerceros();
        public (int status, string message, Tercero) GetTercero(int idTercero);
        public (int status, string message) DeleteTercero(int idTercero);
    }
}
