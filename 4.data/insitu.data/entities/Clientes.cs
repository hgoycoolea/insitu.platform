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
    public class Clientes : Entity
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
        public string NumeroTelefono { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Nombre { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Apellido { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string UUID { get; set; }
    }
}
