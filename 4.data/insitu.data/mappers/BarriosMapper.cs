using cl.maia.data.mappers;
using insitu.data.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insitu.data.mappers
{
    public class BarriosMapper : IEntityMapper<Barrios>
    {
        public Barrios Map(System.Data.IDataRecord parent)
        {
            return new Barrios()
            {
                ID = int.Parse(parent["ID"].ToString()),
                Nombre = parent["Nombre"].ToString(),
                AxisCentro = parent["AxisCentro"].ToString(),
                Ciudad = int.Parse(parent["Ciudad"].ToString()),
                Pais = int.Parse(parent["Pais"].ToString()),
                Radio = parent["Radio"].ToString()
            };
        }
    }
}
