using insitu.data.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace insitu.contracts.open
{
    [ServiceContract(Namespace = "http://insitu.com/", Name = "IMerchantContract", ProtectionLevel = ProtectionLevel.None)]
    public interface IMerchantContract
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="broker"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int CreateMercantes(Mercantes broker);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Mercantes> ReadMercantes();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="broker"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int UpdateMercantes(Mercantes broker);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int DeleteMercantes(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="broker"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int CreateProductos(Productos broker);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Productos> ReadProductos();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="broker"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int UpdateProductos(Productos broker);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int DeleteProductos(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="broker"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int CreatePromociones(Promociones broker);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Promociones> ReadPromociones();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Categoria"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Promociones> ReadPromocionesPorCategorias(List<int> Collection);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="broker"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int UpdatePromociones(Promociones broker);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int DeletePromociones(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="broker"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int CreateItemProductos(ItemProductos broker);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mercante"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<ItemProductos> ReadItemProductos(int Mercante);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="broker"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int UpdateItemProductos(ItemProductos broker);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int DeleteItemProductos(int id);
        /// <summary>
        /// Creo un cliente dentro dela base de mercantes
        /// </summary>
        /// <param name="broker"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int CreateClientesMercantes(ClientesMercantes broker);
        /// <summary>
        /// Borramos un cliente de un mercante en especifico
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int DeleteClientesMercantes(int id);
        /// <summary>
        /// Obtiene todos los clientes de un mercante
        /// </summary>
        /// <param name="Mercante"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<ClientesMercantes> ReadClientesMercantes(int Mercante);
    }
}
