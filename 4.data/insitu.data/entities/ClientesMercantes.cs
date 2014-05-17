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
    public class ClientesMercantes : Entity
    {
        /// <summary>
        /// ID referencia de la tabla
        /// </summary>
        [DataMember]
        public int ID { get; set; }
        /// <summary>
        /// ID del Cliente seguidor
        /// </summary>
        [DataMember]
        public int Cliente { get; set; }
        /// <summary>
        /// ID del comercio o Mercante
        /// </summary>
        [DataMember]
        public int Mercante { get; set; }
    }
}
