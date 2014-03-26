using insitu.business.partial;
using insitu.contracts.open;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insitu.services.open
{
    public class MerchantService : IMerchantContract
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="broker"></param>
        /// <returns></returns>
        int IMerchantContract.CreateMercantes(data.entities.Mercantes broker)
        {
            return MerchantLogics.CreateMercantes(broker);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<data.entities.Mercantes> IMerchantContract.ReadMercantes()
        {
            return MerchantLogics.ReadMercantes();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="broker"></param>
        /// <returns></returns>
        int IMerchantContract.UpdateMercantes(data.entities.Mercantes broker)
        {
            return MerchantLogics.UpdateMercantes(broker);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int IMerchantContract.DeleteMercantes(int id)
        {
            return MerchantLogics.DeleteMercantes(id);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="broker"></param>
        /// <returns></returns>
        int IMerchantContract.CreateProductos(data.entities.Productos broker)
        {
            return MerchantLogics.CreateProductos(broker);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<data.entities.Productos> IMerchantContract.ReadProductos()
        {
            return MerchantLogics.ReadProductos();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="broker"></param>
        /// <returns></returns>
        int IMerchantContract.UpdateProductos(data.entities.Productos broker)
        {
            return MerchantLogics.UpdateProductos(broker);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int IMerchantContract.DeleteProductos(int id)
        {
            return MerchantLogics.DeleteProductos(id);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="broker"></param>
        /// <returns></returns>
        int IMerchantContract.CreatePromociones(data.entities.Promociones broker)
        {
            return MerchantLogics.CreatePromociones(broker);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<data.entities.Promociones> IMerchantContract.ReadPromociones()
        {
            return MerchantLogics.ReadPromociones();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Collection"></param>
        /// <returns></returns>
        List<data.entities.Promociones> IMerchantContract.ReadPromocionesPorCategorias(List<int> Collection)
        {
            return MerchantLogics.ReadPromocionesPorCategorias(Collection);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="broker"></param>
        /// <returns></returns>
        int IMerchantContract.UpdatePromociones(data.entities.Promociones broker)
        {
            return MerchantLogics.UpdatePromociones(broker);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int IMerchantContract.DeletePromociones(int id)
        {
            return MerchantLogics.DeletePromociones(id);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="broker"></param>
        /// <returns></returns>
        int IMerchantContract.CreateItemProductos(data.entities.ItemProductos broker)
        {
            return MerchantLogics.CreateItemProductos(broker);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mercante"></param>
        /// <returns></returns>
        List<data.entities.ItemProductos> IMerchantContract.ReadItemProductos(int Venta)
        {
            return MerchantLogics.ReadItemProductos(Venta);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="broker"></param>
        /// <returns></returns>
        int IMerchantContract.UpdateItemProductos(data.entities.ItemProductos broker)
        {
            return MerchantLogics.UpdateItemProductos(broker) ;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int IMerchantContract.DeleteItemProductos(int id)
        {
            return MerchantLogics.DeleteItemProductos(id);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="broker"></param>
        /// <returns></returns>
        int IMerchantContract.CreateClientesMercantes(data.entities.ClientesMercantes broker)
        {
            return MerchantLogics.CreateClientesMercantes(broker);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int IMerchantContract.DeleteClientesMercantes(int id)
        {
            return MerchantLogics.DeleteClientesMercantes(id);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mercante"></param>
        /// <returns></returns>
        List<data.entities.ClientesMercantes> IMerchantContract.ReadClientesMercantes(int Mercante)
        {
            return MerchantLogics.ReadClientesMercantes(Mercante);
        }
    }
}
