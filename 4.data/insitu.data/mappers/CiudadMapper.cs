using cl.maia.data.mappers;
using insitu.data.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insitu.data.mappers
{
    public class CiudadMapper : IEntityMapper<Ciudad>
    {
        public Ciudad Map(System.Data.IDataRecord parent)
        {
            return new Ciudad()
            {
                ID = int.Parse(parent["ID"].ToString()),
                Pais = int.Parse(parent["Pais"].ToString()),
                Nombre = parent["Nombre"].ToString()
            };
        }
    }
}
