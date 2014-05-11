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
    public class Ciudad : Entity
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Nombre { get; set; }

        [DataMember]
        public int Pais { get; set; }
    }
}
