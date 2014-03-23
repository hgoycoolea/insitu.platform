using insitu.data.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace insitu.contracts.close
{
    [ServiceContract(Namespace = "http://goycooleainc.com/", Name = "ISatelliteContract", ProtectionLevel = ProtectionLevel.EncryptAndSign)]
    public interface ISatelliteContract
    {
        /// <summary>
        /// Ingresa la posicion desde un celular
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="cliente"></param>
        [OperationContract()]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void AcknowledgePosition(string axis, int cliente);
        /// <summary>
        /// Metodo que obtiene la ruta de un Mercante
        /// </summary>
        /// <param name="Mercante"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Rutas GetRutas(int Mercante);
        /// <summary>
        /// Lee todas las posiciones de un cliente
        /// </summary>
        /// <param name="Cliente"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Positions> ReadPositions(int Cliente);
    }
}
