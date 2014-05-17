using cl.maia.data.mappers;
using insitu.data.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insitu.data.mappers
{
    public class SocialClientesMapper : IEntityMapper<SocialClientes>
    {
        public SocialClientes Map(System.Data.IDataRecord parent)
        {
            return new SocialClientes()
            {
                ID = int.Parse(parent["ID"].ToString()),
                Descripcion = parent["Descripcion"].ToString(),
                Locacion = parent["Locacion"].ToString(),
                NombreSocial = parent["NombreSocial"].ToString(),
                TipoSocial = int.Parse(parent["TipoSocial"].ToString()),
                UrlImagen = parent["UrlImagen"].ToString(),
                UsuarioSocial = parent["UsuarioSocial"].ToString()
            };
        }
    }
}
