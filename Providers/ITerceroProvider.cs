using ApiTenStore.Interfaces;
using ApiTenStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTenStore.Providers
{
    public class ITerceroProvider : ITercero
    {
        private readonly AppDbContext context;

        public ITerceroProvider(AppDbContext context)
        {
            this.context = context;
        }

        public (int status, string message) AddTercero(Tercero tercero)
        {
            try
            {
                if (tercero != null)
                    return (400, "Por favor agrege un producto valido");
                context.Terceros.Add(tercero);
                context.SaveChanges();
                return (200, "Tercero agregado correctamente");
            }
            catch(Exception exc)
            {
                return (400, "Ocurrio un error al agregar el terero:" + exc.ToString());
            }

            
        }

        public (int status, string message) DeleteTercero(int idTercero)
        {
            try
            {
                var terDb = context.Terceros.FirstOrDefault(ter => ter.id == idTercero);
                if (terDb == null)
                    return (400, "El tercero a eliminar no fue encontrado");
                context.Terceros.Remove(terDb);
                context.SaveChanges();
                return (200, "Tercero eliminado correctamente");
            }
            catch(Exception exc)
            {
                return (400, "Ocurrio un error al eliminar el tercero:" + exc.ToString());
            }
        }

        public (int status, string message, Tercero) GetTercero(int idTercero)
        {
            try
            {
                var terDb = context.Terceros.FirstOrDefault(ter => ter.id == idTercero);
                if (terDb == null)
                    return (400, "El tercero a consultar no existe", new Tercero());
                
                return (200, "Tercero consultado correctamente", terDb);
            }
            catch (Exception exc)
            {
                return (400, "Ocurrio un error al consultar el tercero:" + exc.ToString(), new Tercero());
            }
        }

        public (int status, string message, List<Tercero>) GetTerceros()
        {
            try
            {
                var terDb = context.Terceros.ToList();
                if (terDb == null)
                    return (400, "No hay terceros para consultar", null);

                return (200, "Tercero consultado correctamente", terDb);
            }
            catch (Exception exc)
            {
                return (400, "Ocurrio un error al consultar el tercero:" + exc.ToString(), null);
            }
        }

        public (int status, string message) UpdateTercero(int idTercero, Tercero tercero)
        {
            try
            {
                var terDb = context.Terceros.FirstOrDefault(ter => ter.id == idTercero);
                if (terDb == null)
                    return (400, "No se encuentra el tercero a actualizar");

                return (200, "Tercero actualizado correctamente");
            }
            catch (Exception exc)
            {
                return (400, "Ocurrio un error al consultar el tercero:" + exc.ToString());
            }
        }
    }
}
