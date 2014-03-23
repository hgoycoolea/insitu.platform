using cl.maia.data.mappers;
using insitu.data.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insitu.data.mappers
{
    public class RutasMapper : IEntityMapper<Rutas>
    {
        public Rutas Map(System.Data.IDataRecord parent)
        {
            return new Rutas()
            {
                Axis = parent["Axis"].ToString(),
                Cliente = int.Parse(parent["Cliente"].ToString()),
                Fecha = parent["Fecha"].ToString(),
                ID = int.Parse(parent["ID"].ToString())
            };
        }
    }
}
