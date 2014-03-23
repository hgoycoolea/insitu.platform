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
    public class Promociones: Entity
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int ID { get; set; }
        /// <summary>
        /// ID Cliente
        /// </summary>
        [DataMember]
        public int Cliente { get; set; }
        /// <summary>
        /// ID Producto
        /// </summary>
        [DataMember]
        public int Producto { get; set; }
        /// <summary>
        /// Porcentaje de descuento
        /// </summary>
        [DataMember]
        public int Porcentaje { get; set; }
        /// <summary>
        /// Titulo del descuento
        /// </summary>
        [DataMember]
        public string Titulo { get; set; }
        /// <summary>
        /// Descripcion del descuento
        /// </summary>
        [DataMember]
        public string Cuerpo { get; set; }
        /// <summary>
        /// Mensaje en la parte baja
        /// </summary>
        [DataMember]
        public string Barra { get; set; }
        /// <summary>
        /// Imagen del Descuento
        /// </summary>
        [DataMember]
        public string UrlImage { get; set; }
        /// <summary>
        /// Fecha Comienzo Publicacion Descuento
        /// </summary>
        [DataMember]
        public string FechaComienzo { get; set; }
        /// <summary>
        /// Fecha Termino Publicacion Descuento
        /// </summary>
        [DataMember]
        public string FechaTermino { get; set; }
    }
}
