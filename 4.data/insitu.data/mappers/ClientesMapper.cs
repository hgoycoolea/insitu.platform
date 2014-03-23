using cl.maia.data.mappers;
using insitu.data.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insitu.data.mappers
{
    public class ClientesMapper : IEntityMapper<Clientes>
    {
        public Clientes Map(System.Data.IDataRecord parent)
        {
            return new Clientes()
            {
                Apellido = parent["Apellido"].ToString(),
                Email = parent["Email"].ToString(),
                ID = int.Parse(parent["ID"].ToString()),
                Nombre = parent["Nombre"].ToString(),
                NumeroTelefono = parent["NumeroTelefono"].ToString(),
                UUID = parent["UUID"].ToString()
            };
        }
    }
}
