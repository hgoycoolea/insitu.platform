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
    public class PerfilClientes : Entity
    {
        /// <summary>
        /// Numero de tabla
        /// </summary>
        [DataMember]
        public int ID { get; set; }
        /// <summary>
        /// Numero de Cliente Asociado
        /// </summary>
        [DataMember]
        public int Cliente { get; set; }
        /// <summary>
        /// Tolerancia Larga : 0
        /// Tolerancia Corta : 1
        /// </summary>
        [DataMember]
        public int ToleranciaDistancia { get; set; }
        /// <summary>
        /// Aprendisaje no : 0
        /// Aprendisaje si : 1
        /// </summary>
        [DataMember]
        public int AprendizajeCompras { get; set; }
        /// <summary>
        /// Tipo de Alerta
        /// Todos 0 
        /// Favoritos 1
        /// </summary>
        [DataMember]
        public int TipoAlerta { get; set; }
    }
}
