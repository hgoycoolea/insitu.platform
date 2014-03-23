using cl.maia.data.mappers;
using insitu.data.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insitu.data.mappers
{
    public class PromocionesMapper: IEntityMapper<Promociones>
    {
        public Promociones Map(System.Data.IDataRecord parent)
        {
            return new Promociones()
            {
                Barra = parent["Barra"].ToString(),
                Cliente = int.Parse(parent["Cliente"].ToString()),
                Cuerpo = parent["Cuerpo"].ToString(),
                FechaComienzo = parent["FechaComienzo"].ToString(),
                FechaTermino = parent["FechaTermino"].ToString(),
                ID = int.Parse(parent["ID"].ToString()),
                Porcentaje = int.Parse(parent["Porcentaje"].ToString()),
                Producto = int.Parse(parent["Producto"].ToString()),
                Titulo = parent["Titulo"].ToString(),
                UrlImage = parent["UrlImage"].ToString()
            };
        }
    }
}
