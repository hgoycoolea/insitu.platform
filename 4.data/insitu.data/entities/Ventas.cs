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
    public class Ventas : Entity
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int ID { get; set; }
        /// <summary>
        /// Cliente que esta comprando
        /// </summary>
        [DataMember]
        public int Cliente { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int Mercante { get; set; }
        /// <summary>
        /// Promocion en caso de ser usada
        /// </summary>
        [DataMember]
        public int Promocion { get; set; }
        /// <summary>
        /// Monto de la Venta
        /// </summary>
        [DataMember]
        public string Monto { get; set; }
        /// <summary>
        /// Fecha de Venta
        /// </summary>
        [DataMember]
        public string FechaVenta { get; set; }
    }
}
