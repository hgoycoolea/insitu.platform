using cl.maia.data.mappers;
using insitu.data.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insitu.data.mappers
{
    public class ClientesMercantesMapper : IEntityMapper<ClientesMercantes>
    {
        public ClientesMercantes Map(System.Data.IDataRecord parent)
        {
            return new ClientesMercantes()
            {
                Cliente = int.Parse(parent["Cliente"].ToString()),
                ID = int.Parse(parent["ID"].ToString()),
                Mercante = int.Parse(parent["Mercante"].ToString())
            };
        }
    }
}
