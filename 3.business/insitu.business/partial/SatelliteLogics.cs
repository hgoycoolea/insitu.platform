using cl.maia.business.facades;
using insitu.data.entities;
using insitu.data.mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insitu.business.partial
{
    public static class SatelliteLogics
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="cliente"></param>
        public static int AcknowledgePosition(string axis, int mercante)
        {
            try
            {
                using (MsSqlFacade<Positions, PositionsMapper> facade = new MsSqlFacade<Positions, PositionsMapper>())
                {
                    //// we use the Collection to build the broker entity on an abstract phase to manage it as a all
                    return facade.Create(new Positions() { Axis = axis, Mercante = mercante });
                }
            }
            catch
            {
                return -1;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static int AcknowledgeRutas(string axis, string speed, int cliente)
        {
            try
            {
                using (MsSqlFacade<Rutas, RutasMapper> facade = new MsSqlFacade<Rutas, RutasMapper>())
                {
                    //// we use the Collection to build the broker entity on an abstract phase to manage it as a all
                    return facade.Create(new Rutas() { Axis = axis, Speed = speed, Cliente = cliente, Fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") });
                }
            }
            catch
            {
                return -1;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mercante"></param>
        /// <returns></returns>
        public static List<data.entities.Rutas> ReadRutas(int Cliente)
        {
            try
            {
                using (MsSqlFacade<Rutas, RutasMapper> facade = new MsSqlFacade<Rutas, RutasMapper>())
                {
                    //// we use the Collection to build the broker entity on an abstract phase to manage it as a all
                    return facade.Read().Where(p=>p.Cliente == Cliente).ToList<Rutas>();
                }
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mercante"></param>
        /// <returns></returns>
        public static List<data.entities.Positions> ReadPositions(int Mercante)
        {
            try
            {
                using (MsSqlFacade<Positions, PositionsMapper> facade = new MsSqlFacade<Positions, PositionsMapper>())
                {
                    //// we use the Collection to build the broker entity on an abstract phase to manage it as a all
                    return facade.Read().Where(p => p.Mercante == Mercante).ToList<Positions>();
                }
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mercante"></param>
        /// <returns></returns>
        public static data.entities.Rutas GetRutas(int id)
        {
            try
            {
                using (MsSqlFacade<Rutas, RutasMapper> facade = new MsSqlFacade<Rutas, RutasMapper>())
                {
                    //// we use the Collection to build the broker entity on an abstract phase to manage it as a all
                    return facade.Get(id);
                }
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mercante"></param>
        /// <returns></returns>
        public static data.entities.Positions GetPositions(int id)
        {
            try
            {
                using (MsSqlFacade<Positions, PositionsMapper> facade = new MsSqlFacade<Positions, PositionsMapper>())
                {
                    //// we use the Collection to build the broker entity on an abstract phase to manage it as a all
                    return facade.Get(id);
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
