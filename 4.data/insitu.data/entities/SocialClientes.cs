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
    public class SocialClientes : Entity
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int ID { get; set; }
        /// <summary>
        /// ScreenName de la red
        /// </summary>
        [DataMember]
        public string UsuarioSocial { get; set; }
        /// <summary>
        /// Tipo de red social 
        /// Twitter 0 
        /// Facebook 1
        /// </summary>
        [DataMember]
        public int TipoSocial { get; set; }
        /// <summary>
        /// Nombre social o Nombre que aparece en la red
        /// </summary>
        [DataMember]
        public string NombreSocial { get; set; }
        /// <summary>
        /// Lugar de ubicacion social
        /// </summary>
        [DataMember]
        public string Locacion { get; set; }
        /// <summary>
        /// Descripcion social
        /// </summary>
        [DataMember]
        public string Descripcion { get; set; }
        /// <summary>
        /// Url de la imagen social
        /// </summary>
        [DataMember]
        public string UrlImagen { get; set; }
    }
}
