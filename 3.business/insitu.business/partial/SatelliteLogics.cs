using cl.maia.business.facades;
using insitu.business.concrete;
using insitu.data.entities;
using insitu.data.mappers;
using System;
using System.Collections.Generic;
using System.Device.Location;
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
        public static string getPaisPorID(int id)
        {
            try
            {
                using (MsSqlFacade<Pais, PaisMapper> facade = new MsSqlFacade<Pais, PaisMapper>())
                {
                    //// we use the Collection to build the broker entity on an abstract phase to manage it as a all
                    return facade.Read().Single(p => p.ID == id).Nombre;
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
        /// <param name="axis"></param>
        /// <param name="cliente"></param>
        public static string getCiudadPorID(int id)
        {
            try
            {
                using (MsSqlFacade<Ciudad, CiudadMapper> facade = new MsSqlFacade<Ciudad, CiudadMapper>())
                {
                    //// we use the Collection to build the broker entity on an abstract phase to manage it as a all
                    return facade.Read().Single(p => p.ID == id).Nombre;
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
        public static List<data.entities.Categorias> ReadCategories()
        {
            try
            {
                using (MsSqlFacade<Categorias, CategoriasMapper> facade = new MsSqlFacade<Categorias, CategoriasMapper>())
                {
                    //// we use the Collection to build the broker entity on an abstract phase to manage it as a all
                    return facade.Read();
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
        /// <param name="client"></param>
        /// <returns></returns>
        public static List<data.entities.CategoriasClientes> ReadClientCategories(int client)
        {
            try
            {
                using (MsSqlFacade<CategoriasClientes, CategoriasClientesMapper> facade = new MsSqlFacade<CategoriasClientes, CategoriasClientesMapper>())
                {
                    //// we use the Collection to build the broker entity on an abstract phase to manage it as a all
                    return facade.Read().Where(p=>p.Cliente == client).ToList<CategoriasClientes>();
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
        public static List<data.entities.Barrios> ReadBarriosPorCiudad(int Ciudad)
        {
            try
            {
                using (MsSqlFacade<Barrios, BarriosMapper> facade = new MsSqlFacade<Barrios, BarriosMapper>())
                {
                    //// we use the Collection to build the broker entity on an abstract phase to manage it as a all
                    return facade.Read().Where(p => p.Ciudad == Ciudad).ToList<Barrios>();
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
        /// <param name="axis"></param>
        /// <param name="cliente"></param>
        public static double getDistanceToPromociones(int mercante, string axis)
        {
            try
            {

                /// this is the full collection for the merchants positions
                List<Positions> PositionsCollection = new List<Positions>();
                /// first we get the lat and lon in terms of (x,y) -> (lat, lon)
                string[] geo = axis.Split(',');
                string[] geo1 = null;
                /// latitude
                double lat1 = double.Parse(geo[0]);
                /// longitude
                double lon1 = double.Parse(geo[1]);
                /// Geo Location for the one we are looking for 
                GeoCoordinate coord1 = new GeoCoordinate(lat1, lon1);
                /// facade call so it's O(n) = n^2
                using (MsSqlFacade<Positions, PositionsMapper> facade = new MsSqlFacade<Positions, PositionsMapper>())
                {
                    /// this is the full collection for the merchants positions
                    geo1 = facade.Read().Single(p=>p.Mercante == mercante).Axis.Split(',');
                }
                /// latitude
                double lat2 = double.Parse(geo1[0]);
                /// longitude
                double lon2 = double.Parse(geo1[1]);
                /// Geo Location for the one we are looking for 
                GeoCoordinate coord2 = new GeoCoordinate(lat2, lon2);

                return coord1.GetDistanceTo(coord2);;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="cliente"></param>
        public static string getLogoMercantePorID(int mercante)
        {
            try
            {
                return MercantesLogics.Get(mercante).UrlImageLogo;
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
        }
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
        public static List<data.entities.Positions> ReadPositionsPorMercante(int Mercante)
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
        public static List<data.entities.Positions> ReadPositions()
        {
            try
            {
                using (MsSqlFacade<Positions, PositionsMapper> facade = new MsSqlFacade<Positions, PositionsMapper>())
                {
                    //// we use the Collection to build the broker entity on an abstract phase to manage it as a all
                    return facade.Read().ToList<Positions>();
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
