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
    public class Productos : Entity
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
        public string Precio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Titulo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Descripcion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string UrlImagen { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string FechaCreacion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int Stock { get; set; }
    }
}
