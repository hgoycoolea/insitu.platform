using cl.maia.data.mappers;
using insitu.data.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insitu.data.mappers
{
    public class MembresiasMapper : IEntityMapper<Membresias>
    {
        public Membresias Map(System.Data.IDataRecord parent)
        {
            return new Membresias()
            {
                ID = int.Parse(parent["ID"].ToString()),
                Nombre = parent["Nombre"].ToString(),
                Precio = parent["Precio"].ToString()
            };
        }
    }
}
