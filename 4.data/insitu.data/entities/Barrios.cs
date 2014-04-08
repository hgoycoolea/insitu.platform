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
    public class Barrios : Entity
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
        public string Nombre { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int Pais { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int Ciudad { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Radio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string AxisCentro { get; set; }
    }
}
