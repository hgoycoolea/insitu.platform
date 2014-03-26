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
    public class Rutas : Entity
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
        public int Cliente { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Fecha { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Axis { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Speed { get; set; }
    }
}
