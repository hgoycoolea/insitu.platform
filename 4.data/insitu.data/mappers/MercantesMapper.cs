using cl.maia.data.mappers;
using insitu.data.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insitu.data.mappers
{
    public class MercantesMapper : IEntityMapper<Mercantes>
    {
        public Mercantes Map(System.Data.IDataRecord parent)
        {
            return new Mercantes() {
                Apellido = parent["Apellido"].ToString(),
                Calle = parent["Calle"].ToString(),
                Ciudad = int.Parse(parent["Ciudad"].ToString()),
                Email = parent["Email"].ToString(),
                ID = int.Parse(parent["ID"].ToString()),
                Local = parent["Local"].ToString(),
                Nombre = parent["Nombre"].ToString(),
                NombreTienda = parent["NombreTienda"].ToString(),
                Numero = parent["Numero"].ToString(),
                Pais = int.Parse(parent["Pais"].ToString()),
                Telefono = parent["Telefono"].ToString(),
                UrlImageBanner = parent["UrlImageBanner"].ToString(),
                UrlImageBiografia = parent["UrlImageBiografia"].ToString(),
                UrlImageLogo = parent["UrlImageLogo"].ToString(),
                UrlImageHome = parent["UrlImageHome"].ToString(),
                Membresia = int.Parse(parent["Membresia"].ToString()),
                UUID = parent["UUID"].ToString(),
                WebSite = parent["WebSite"].ToString()
            };
        }
    }
}
