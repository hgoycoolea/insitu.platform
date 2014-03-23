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
    public class Mercantes : Entity
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
        public string Telefono { get; set; }
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
        public string NombreTienda { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string UUID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Calle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Numero { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Local { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string WebSite { get; set; }
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
        public string UrlLogo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string UrlBanner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string UrlBiografia { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int Categoria { get; set; }
    }
}
