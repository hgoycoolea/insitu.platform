using cl.maia.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace insitu.data.entities
{
    [DataContract]
    public class ComprasPromociones : Entity
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int ID { get; set; }
        /// <summary>
        /// Id de la Promocion comprada
        /// </summary>
        [DataMember]
        public int Promocion { get; set; }
        /// <summary>
        /// Id del cliente que compro la promocion
        /// </summary>
        [DataMember]
        public int Cliente { get; set; }
        /// <summary>
        /// 0 : Recien Comprado
        /// 1 : Compra Aceptada
        /// 2 : Compra Rechazada
        /// 3 : Compra Caducada
        /// 4 : Compra Reciclada
        /// 5 : Usuario Arrepiente Compra
        /// </summary>
        [DataMember]
        public int Estado { get; set; }
        /// <summary>
        /// Serial de la compra para motivos de cuadratura
        /// </summary>
        [DataMember]
        public string Guid { get; set; }
        /// <summary>
        /// Fecha de la compra
        /// </summary>
        [DataMember]
        public string FechaCompra { get; set; }
        /// <summary>
        /// Fecha cambio de estado 
        /// </summary>
        [DataMember]
        public string FechaCambioEstado { get; set; }
    }
}
