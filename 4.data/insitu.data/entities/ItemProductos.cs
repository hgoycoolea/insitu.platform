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
    public class ItemProductos: Entity
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int Productos { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int Venta { get; set; }
    }
}
