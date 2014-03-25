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
    [ServiceContract(Namespace = "http://insitu.com/", Name = "IClientContract", ProtectionLevel = ProtectionLevel.None)]
    public interface IClientContract
    {
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
        /// <param name="axis"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Promociones> ReadPromocionesPorGeolocation(string axis);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="broker"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int CreateVisita(Visitas broker);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Membresias> ReadMembresias();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="broker"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int CreateCategoriasClientes(CategoriasClientes broker);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cliente"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<CategoriasClientes> ReadCategoriasClientes(int Cliente);
    }
}
