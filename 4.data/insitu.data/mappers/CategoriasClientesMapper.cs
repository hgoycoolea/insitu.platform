using cl.maia.data.mappers;
using insitu.data.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insitu.data.mappers
{
    public class CategoriasClientesMapper : IEntityMapper<CategoriasClientes>
    {
        public CategoriasClientes Map(System.Data.IDataRecord parent)
        {
            return new CategoriasClientes()
            {
                Categoria = int.Parse(parent["Categoria"].ToString()),
                Cliente = int.Parse(parent["Cliente"].ToString()),
                ID = int.Parse(parent["ID"].ToString())
            };
        }
    }
}
