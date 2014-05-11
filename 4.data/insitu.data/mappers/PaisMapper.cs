using cl.maia.data.mappers;
using insitu.data.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insitu.data.mappers
{
    public class PaisMapper : IEntityMapper<Pais>
    {
        public Pais Map(System.Data.IDataRecord parent)
        {
            return new Pais()
            {
                ID = int.Parse(parent["ID"].ToString()),
                Nombre = parent["Nombre"].ToString(),
                Codigo = parent["Codigo"].ToString()
            };
        }
    }
}
