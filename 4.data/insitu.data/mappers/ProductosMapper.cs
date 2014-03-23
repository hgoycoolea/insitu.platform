using cl.maia.data.mappers;
using insitu.data.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insitu.data.mappers
{
    public class ProductosMapper : IEntityMapper<Productos>
    {
        public Productos Map(System.Data.IDataRecord parent)
        {
            return new Productos() { 
                Cliente = int.Parse(parent["Cliente"].ToString()),
                Descripcion = parent["Descripcion"].ToString(),
                FechaCreacion = parent["FechaCreacion"].ToString(),
                ID = int.Parse(parent["ID"].ToString()),
                Precio = parent["Precio"].ToString(),
                Stock = int.Parse(parent["Stock"].ToString()),
                Titulo = parent["Titulo"].ToString(),
                UrlImagen = parent["UrlImagen"].ToString()
            };
        }
    }
}
