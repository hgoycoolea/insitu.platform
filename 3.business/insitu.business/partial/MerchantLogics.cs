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
    public static class MerchantLogics
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Collection"></param>
        /// <returns></returns>
        public static List<data.entities.Mercantes> ReadMercantesPorMembresias(List<int> Membresias)
        {
            try
            {
                using (MsSqlFacade<Mercantes, MercantesMapper> facade = new MsSqlFacade<Mercantes, MercantesMapper>())
                {
                    // we now select all the promotions that are active but we make it into a linear research
                    // thus is not woow efficient is enought for it's end. 
                    return facade.Read().Where(p => Membresias.Contains(p.Membresia)).ToList<Mercantes>();
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
        public static data.entities.Mercantes getMercantePorID(int Mercante)
        {
            try
            {
                using (MsSqlFacade<Mercantes, MercantesMapper> facade = new MsSqlFacade<Mercantes, MercantesMapper>())
                {
                    // we now select all the promotions that are active but we make it into a linear research
                    // thus is not woow efficient is enought for it's end. 
                    return facade.Get(Mercante);
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
        public static int CreateMercantes(data.entities.Mercantes broker)
        {
            try
            {
                using (MsSqlFacade<Mercantes, MercantesMapper> facade = new MsSqlFacade<Mercantes, MercantesMapper>())
                {
                    //// we select all the promotion that are active first
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
        public static List<data.entities.Mercantes> ReadMercantes()
        {
            try
            {
                using (MsSqlFacade<Mercantes, MercantesMapper> facade = new MsSqlFacade<Mercantes, MercantesMapper>())
                {
                    //// we select all the promotion that are active first
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
        public static int UpdateMercantes(data.entities.Mercantes broker)
        {
            try
            {
                using (MsSqlFacade<Mercantes, MercantesMapper> facade = new MsSqlFacade<Mercantes, MercantesMapper>())
                {
                    //// we select all the promotion that are active first
                    return facade.Update(broker);
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
        /// <param name="id"></param>
        /// <returns></returns>
        public static int DeleteMercantes(int id)
        {
            try
            {
                using (MsSqlFacade<Mercantes, MercantesMapper> facade = new MsSqlFacade<Mercantes, MercantesMapper>())
                {
                    //// we select all the promotion that are active first
                    return facade.Delete(id);
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
        /// <param name="broker"></param>
        /// <returns></returns>
        public static int CreateProductos(data.entities.Productos broker)
        {
            try
            {
                using (MsSqlFacade<Productos, ProductosMapper> facade = new MsSqlFacade<Productos, ProductosMapper>())
                {
                    //// we select all the promotion that are active first
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
        public static List<data.entities.Productos> ReadProductos()
        {
            try
            {
                using (MsSqlFacade<Productos, ProductosMapper> facade = new MsSqlFacade<Productos, ProductosMapper>())
                {
                    //// we select all the promotion that are active first
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
        public static int UpdateProductos(data.entities.Productos broker)
        {
            try
            {
                using (MsSqlFacade<Productos, ProductosMapper> facade = new MsSqlFacade<Productos, ProductosMapper>())
                {
                    //// we select all the promotion that are active first
                    return facade.Update(broker);
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
        /// <param name="id"></param>
        /// <returns></returns>
        public static int DeleteProductos(int id)
        {
            try
            {
                using (MsSqlFacade<Productos, ProductosMapper> facade = new MsSqlFacade<Productos, ProductosMapper>())
                {
                    //// we select all the promotion that are active first
                    return facade.Delete(id);
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
        /// <param name="broker"></param>
        /// <returns></returns>
        public static int CreatePromociones(data.entities.Promociones broker)
        {
            try
            {
                using (MsSqlFacade<Promociones, PromocionesMapper> facade = new MsSqlFacade<Promociones, PromocionesMapper>())
                {
                    //// we select all the promotion that are active first
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
        public static List<data.entities.Promociones> ReadPromociones()
        {
            try
            {
                using (MsSqlFacade<Promociones, PromocionesMapper> facade = new MsSqlFacade<Promociones, PromocionesMapper>())
                {
                    //// we select all the promotion that are active first
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
        /// <param name="Collection"></param>
        /// <returns></returns>
        public static List<data.entities.Promociones> ReadPromocionesPorCategorias(List<int> Collection)
        {
            try
            {
                using (MsSqlFacade<Promociones, PromocionesMapper> facade = new MsSqlFacade<Promociones, PromocionesMapper>())
                {
                    //// we select all the promotion that are active first
                    return facade.Read().Where(p=> Collection.Contains(p.Categoria)).ToList<Promociones>();
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
        public static int UpdatePromociones(data.entities.Promociones broker)
        {
            try
            {
                using (MsSqlFacade<Promociones, PromocionesMapper> facade = new MsSqlFacade<Promociones, PromocionesMapper>())
                {
                    //// we select all the promotion that are active first
                    return facade.Update(broker);
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
        /// <param name="id"></param>
        /// <returns></returns>
        public static int DeletePromociones(int id)
        {
            try
            {
                using (MsSqlFacade<Promociones, PromocionesMapper> facade = new MsSqlFacade<Promociones, PromocionesMapper>())
                {
                    //// we select all the promotion that are active first
                    return facade.Delete(id);
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
        /// <param name="broker"></param>
        /// <returns></returns>
        public static int CreateItemProductos(data.entities.ItemProductos broker)
        {
            try
            {
                using (MsSqlFacade<ItemProductos, ItemProductosMapper> facade = new MsSqlFacade<ItemProductos, ItemProductosMapper>())
                {
                    //// we select all the promotion that are active first
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
        /// <param name="Mercante"></param>
        /// <returns></returns>
        public static List<data.entities.ItemProductos> ReadItemProductos(int Venta)
        {
            try
            {
                using (MsSqlFacade<ItemProductos, ItemProductosMapper> facade = new MsSqlFacade<ItemProductos, ItemProductosMapper>())
                {
                    //// we select all the promotion that are active first
                    return facade.Read().Where(p=>p.Venta == Venta).ToList<ItemProductos>();
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
        public static int UpdateItemProductos(data.entities.ItemProductos broker)
        {
            try
            {
                using (MsSqlFacade<ItemProductos, ItemProductosMapper> facade = new MsSqlFacade<ItemProductos, ItemProductosMapper>())
                {
                    //// we select all the promotion that are active first
                    return facade.Update(broker);
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
        /// <param name="id"></param>
        /// <returns></returns>
        public static int DeleteItemProductos(int id)
        {
            try
            {
                using (MsSqlFacade<ItemProductos, ItemProductosMapper> facade = new MsSqlFacade<ItemProductos, ItemProductosMapper>())
                {
                    //// we select all the promotion that are active first
                    return facade.Delete(id);
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
        /// <param name="broker"></param>
        /// <returns></returns>
        public static int CreateClientesMercantes(data.entities.ClientesMercantes broker)
        {
            try
            {
                using (MsSqlFacade<ClientesMercantes, ClientesMercantesMapper> facade = new MsSqlFacade<ClientesMercantes, ClientesMercantesMapper>())
                {
                    //// we select all the promotion that are active first
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
        /// <param name="id"></param>
        /// <returns></returns>
        public static int DeleteClientesMercantes(int id)
        {
            try
            {
                using (MsSqlFacade<ClientesMercantes, ClientesMercantesMapper> facade = new MsSqlFacade<ClientesMercantes, ClientesMercantesMapper>())
                {
                    //// we select all the promotion that are active first
                    return facade.Delete(id);
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
        /// <param name="Mercante"></param>
        /// <returns></returns>
        public static List<data.entities.ClientesMercantes> ReadClientesMercantes(int Mercante)
        {
            try
            {
                using (MsSqlFacade<ClientesMercantes, ClientesMercantesMapper> facade = new MsSqlFacade<ClientesMercantes, ClientesMercantesMapper>())
                {
                    //// we select all the promotion that are active first
                    return facade.Read().Where(p=>p.Mercante == Mercante).ToList<ClientesMercantes>();
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
