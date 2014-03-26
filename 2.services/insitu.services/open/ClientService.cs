using insitu.business.partial;
using insitu.contracts.open;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insitu.services.open
{
    public class ClientService : IClientContract
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<data.entities.Promociones> IClientContract.ReadPromociones(int estado)
        {
            return ClientLogics.ReadPromociones(estado);
        }
        /// <summary> 
        /// 
        /// </summary>
        /// <param name="Collection"></param>
        /// <returns></returns>
        List<data.entities.Promociones> IClientContract.ReadPromocionesPorCategorias(List<int> Collection)
        {
            return ClientLogics.ReadPromocionesPorCategorias(Collection);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="axis"></param>
        /// <returns></returns>
        List<data.entities.Promociones> IClientContract.ReadPromocionesPorGeolocation(string axis, double tolerance)
        {
            return ClientLogics.ReadPromocionesPorGeolocation(axis, tolerance);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="broker"></param>
        /// <returns></returns>
        int IClientContract.CreateVisita(data.entities.Visitas broker)
        {
            return ClientLogics.CreateVisita(broker);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<data.entities.Membresias> IClientContract.ReadMembresias()
        {
            return ClientLogics.ReadMembresias();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="broker"></param>
        /// <returns></returns>
        int IClientContract.CreateCategoriasClientes(data.entities.CategoriasClientes broker)
        {
            return ClientLogics.CreateCategoriasClientes(broker);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cliente"></param>
        /// <returns></returns>
        List<data.entities.CategoriasClientes> IClientContract.ReadCategoriasClientes(int Cliente)
        {
            return ClientLogics.ReadCategoriasClientes(Cliente);
        }
    }
}
