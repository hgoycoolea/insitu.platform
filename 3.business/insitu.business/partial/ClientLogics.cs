using cl.maia.business.facades;
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
    public class ClientLogics
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static int UpdatePerfilCliente(PerfilClientes cliente)
        {
            try
            {
                using (MsSqlFacade<PerfilClientes, PerfilClientesMapper> facade = new MsSqlFacade<PerfilClientes, PerfilClientesMapper>())
                {
                    return facade.Update(cliente);
                }
            }
            catch
            {
                /// in case that fails, we give an empty list
                return -1;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static PerfilClientes getPerfilCliente(int Cliente)
        {
            try
            {
                using (MsSqlFacade<PerfilClientes, PerfilClientesMapper> facade = new MsSqlFacade<PerfilClientes, PerfilClientesMapper>())
                {
                    return facade.Get(Cliente);
                }
            }
            catch
            {
                /// in case that fails, we give an empty list
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static int UpdateCliente(Clientes cliente)
        {
            try
            {
                using (MsSqlFacade<Clientes, ClientesMapper> facade = new MsSqlFacade<Clientes, ClientesMapper>())
                {
                    return facade.Update(cliente);
                }
            }
            catch
            {
                /// in case that fails, we give an empty list
                return -1;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static int CreateCliente(Clientes cliente)
        {
            try
            {
                using (MsSqlFacade<Clientes, ClientesMapper> facade = new MsSqlFacade<Clientes, ClientesMapper>())
                {
                    
                    int id =  facade.Create(cliente);

                    using (MsSqlFacade<PerfilClientes, PerfilClientesMapper> facade1 = new MsSqlFacade<PerfilClientes, PerfilClientesMapper>())
                    {
                        facade1.Create(new PerfilClientes() { AprendizajeCompras = 0, ToleranciaDistancia = 0, TipoAlerta = 0, Cliente = id });
                    }

                    return id;
                }
            }
            catch
            {
                /// in case that fails, we give an empty list
                return -1;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cliente"></param>
        /// <returns></returns>
        public static List<ComprasPromociones> getComprasPorCliente(int Cliente)
        {
            try
            {
                using (MsSqlFacade<ComprasPromociones, ComprasPromocionesMapper> facade = new MsSqlFacade<ComprasPromociones, ComprasPromocionesMapper>())
                {
                    return facade.Read().Where(p => p.Cliente == Cliente).ToList<ComprasPromociones>();
                }
            }
            catch
            {
                /// in case that fails, we give an empty list
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Compra"></param>
        /// <param name="Estado"></param>
        /// <returns></returns>
        public static int EstadoPromocion(int Compra, int Estado)
        {
            try
            {
                using (MsSqlFacade<ComprasPromociones, ComprasPromocionesMapper> facade = new MsSqlFacade<ComprasPromociones, ComprasPromocionesMapper>())
                {
                    /// we now get the entity
                    ComprasPromociones entity = facade.Get(Compra);
                    /// this entity we now update
                    entity.Estado = Estado;
                    entity.FechaCambioEstado = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    /// this will return the entity update
                    return facade.Update(entity);
                }
            }
            catch
            {
                /// in case that fails, we give an empty list
                return -1;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Promocion"></param>
        /// <param name="Cliente"></param>
        /// <returns></returns>
        public static string ComprarPromocion(int Promocion, int Cliente)
        {
            try
            {
                using (MsSqlFacade<ComprasPromociones, ComprasPromocionesMapper> facade = new MsSqlFacade<ComprasPromociones, ComprasPromocionesMapper>())
                {
                    /// this is the guid
                    string guid = Guid.NewGuid().ToString();
                    //// we select all the promotion that are active first
                    facade.Create(new ComprasPromociones() { Cliente = Cliente, Promocion = Promocion, Estado = 0, FechaCambioEstado = "", FechaCompra = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") , Guid = guid});
                    /// return the guid
                    return guid;
                }
            }
            catch
            {
                /// in case that fails, we give an empty list
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<data.entities.Promociones> ReadPromociones(int estado)
        {
            try
            {
                using (MsSqlFacade<Promociones, PromocionesMapper> facade = new MsSqlFacade<Promociones, PromocionesMapper>())
                {
                    //// we select all the promotion that are active first
                    return facade.Read().Where(p=>p.Estado == estado).ToList<Promociones>();
                }
            }
            catch
            {
                /// in case that fails, we give an empty list
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Collection"></param>
        /// <returns></returns>
        public static List<data.entities.Promociones> ReadPromocionesPorMercante(int Mercante)
        {
            try
            {
                using (MsSqlFacade<Promociones, PromocionesMapper> facade = new MsSqlFacade<Promociones, PromocionesMapper>())
                {
                    // we now select all the promotions that are active but we make it into a linear research
                    // thus is not woow efficient is enought for it's end. 
                    return facade.Read().Where(p => p.Mercante == Mercante).ToList<Promociones>();
                }
            }
            catch
            {
                /// in case that fails, we give an empty list
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Collection"></param>
        /// <returns></returns>
        public static List<data.entities.Promociones> ReadPromocionesPorCategorias(List<int> Collection, int Barrio)
        {
            try
            {
                using (MsSqlFacade<Promociones, PromocionesMapper> facade = new MsSqlFacade<Promociones, PromocionesMapper>())
                {
                    // we now select all the promotions that are active but we make it into a linear research
                    // thus is not woow efficient is enought for it's end. 
                    return facade.Read().Where(p => Collection.Contains(p.Categoria) && p.Barrio == Barrio).ToList<Promociones>();
                }
            }
            catch
            {
                /// in case that fails, we give an empty list
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="axis"></param>
        /// <returns></returns>
        public static List<data.entities.Promociones> ReadPromocionesPorGeolocation(string axis, double tolerance, int Barrio)
        {
            try
            {
                /// this is the list of merchants near my location
                List<int> MerchantCandidatesNear = new List<int>();
                /// this is the full collection for the merchants positions
                List<Positions> PositionsCollection = new List<Positions>();
                /// first we get the lat and lon in terms of (x,y) -> (lat, lon)
                string[] geo = axis.Split(',');
                /// latitude
                double lat1 = double.Parse(geo[0]);
                /// longitude
                double lon1 = double.Parse(geo[1]);
                /// Geo Location for the one we are looking for 
                GeoCoordinate coord1 = new GeoCoordinate(lat1, lon1);
                /// we now prepare the object to be used
                GeoCoordinate coord2;
                /// facade call so it's O(n) = n^2
                using (MsSqlFacade<Positions, PositionsMapper> facade = new MsSqlFacade<Positions, PositionsMapper>())
                {
                    /// this is the full collection for the merchants positions
                    PositionsCollection = facade.Read();
                }
                /// this is only valid if the number of monkey is higher than zero
                if (PositionsCollection.Count > 0)
                {
                    /// now we iterate to search the candidates
                    foreach (Positions parent in PositionsCollection)
                    {
                        /// we now get the axis comma separated
                        string[] g = parent.Axis.Split(',');
                        /// latitude
                        double lat2 = double.Parse(g[0]);
                        /// longitude
                        double lon2 = double.Parse(g[1]);
                        /// we now set the object
                        coord2 = new GeoCoordinate(lat2, lon2);
                        /// this gives me the distance of 
                        /// how long is the current actor's position to it destination
                        /// this distance is measured in meters !! 
                        double distance = coord1.GetDistanceTo(coord2);
                        /// if my candidate is near my location
                        if (distance <= tolerance)
                        {
                            MerchantCandidatesNear.Add(parent.Mercante);
                        }
                        else
                        {
                            /// DO NOTHING ::
                        }
                    }
                    if (MerchantCandidatesNear.Count >= 0)
                    {
                        /// another facade call O(n) = n^2 + 1
                        using (MsSqlFacade<Promociones, PromocionesMapper> facade = new MsSqlFacade<Promociones, PromocionesMapper>())
                        {
                            /// this returns the promotions whre the merchant are near the tolerance given by the user
                            return facade.Read().Where(p => MerchantCandidatesNear.Contains(p.Mercante) && p.Barrio == Barrio).ToList<Promociones>();
                        }
                    }
                    else
                    {
                        /// we only open the facade if the candidates are higher than zero, else 
                        /// we get out
                        return null;
                    }
                }
                else
                {
                    /// no candidates near so you are so fucked !!
                    /// Maybe should reduce tolerance
                    return null;
                }
            }
            catch(Exception ex)
            {
                /// in case that fails, we give an empty list
                return new List<Promociones>() { new Promociones(){ Mercante = -1, Cuerpo = ex.ToString() }};
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="broker"></param>
        /// <returns></returns>
        public static int CreateVisita(data.entities.Visitas broker)
        {
            try
            {
                using (MsSqlFacade<Visitas, VisitasMapper> facade = new MsSqlFacade<Visitas, VisitasMapper>())
                {
                    // we now select all the promotions that are active but we make it into a linear research
                    // thus is not woow efficient is enought for it's end. 
                    return facade.Create(broker);
                }
            }
            catch
            {
                /// in case that fails, we give an empty list
                return -1;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<data.entities.Membresias> ReadMembresias()
        {
            try
            {
                using (MsSqlFacade<Membresias, MembresiasMapper> facade = new MsSqlFacade<Membresias, MembresiasMapper>())
                {
                    // we now select all the promotions that are active but we make it into a linear research
                    // thus is not woow efficient is enought for it's end. 
                    return facade.Read();
                }
            }
            catch
            {
                /// in case that fails, we give an empty list
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="broker"></param>
        /// <returns></returns>
        public static int CreateCategoriasClientes(data.entities.CategoriasClientes broker)
        {
            try
            {
                using (MsSqlFacade<CategoriasClientes, CategoriasClientesMapper> facade = new MsSqlFacade<CategoriasClientes, CategoriasClientesMapper>())
                {
                    // we now select all the promotions that are active but we make it into a linear research
                    // thus is not woow efficient is enought for it's end. 
                    return facade.Create(broker);
                }
            }
            catch
            {
                /// in case that fails, we give an empty list
                return -1;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cliente"></param>
        /// <returns></returns>
        public static List<data.entities.CategoriasClientes> ReadCategoriasClientes(int Cliente)
        {
            try
            {
                using (MsSqlFacade<CategoriasClientes, CategoriasClientesMapper> facade = new MsSqlFacade<CategoriasClientes, CategoriasClientesMapper>())
                {
                    // we now select all the promotions that are active but we make it into a linear research
                    // thus is not woow efficient is enought for it's end. 
                    return facade.Read().Where(p => p.Cliente == Cliente).ToList<CategoriasClientes>();
                }
            }
            catch
            {
                /// in case that fails, we give an empty list
                return null;
            }
        }
    }
}
