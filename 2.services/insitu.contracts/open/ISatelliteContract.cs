﻿using insitu.data.entities;
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
    [ServiceContract(Namespace = "http://insitu.com/", Name = "ISatelliteContract", ProtectionLevel = ProtectionLevel.None)]
    public interface ISatelliteContract
    {
        /// <summary>
        /// Ingresa la posicion desde un celular
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="cliente"></param>
        [OperationContract()]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void AcknowledgePosition(string axis, int mercante);
        /// <summary>
        /// Ingresa la rutas desde un celular
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="cliente"></param>
        [OperationContract()]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void AcknowledgeRutas(string axis, string speed, int cliente);
        /// <summary>
        /// Metodo que obtiene la ruta de un Mercante
        /// </summary>
        /// <param name="Mercante"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Rutas GetRutas(int ID);
        /// <summary>
        /// Metodo que obtiene la positions de un Mercante
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Positions GetPositions(int ID);
        /// <summary>
        /// Lee todas las posiciones dado un mercante
        /// </summary>
        /// <param name="Cliente"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Positions> ReadPositions(int Mercante);
        /// <summary>
        /// Lee todas las rutas de un cliente
        /// </summary>
        /// <param name="Cliente"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Rutas> ReadRutas(int Cliente);
    }
}
