using cl.maia.data.mappers;
using insitu.data.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insitu.data.mappers
{
    public class ItemProductosMapper : IEntityMapper<ItemProductos>
    {
        public ItemProductos Map(System.Data.IDataRecord parent)
        {
            return new ItemProductos()
            {
                ID = int.Parse(parent["ID"].ToString()),
                Productos = int.Parse(parent["Productos"].ToString()),
                Venta = int.Parse(parent["Productos"].ToString())
            };
        }
    }
}
