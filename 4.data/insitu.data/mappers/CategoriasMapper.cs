using cl.maia.data.mappers;
using insitu.data.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insitu.data.mappers
{
    public class CategoriasMapper : IEntityMapper<Categorias>
    {
        public Categorias Map(System.Data.IDataRecord parent)
        {
            return new Categorias()
            {
                ID = int.Parse(parent["ID"].ToString()),
                Nombre = parent["Nombre"].ToString()
            };
        }
    }
}
