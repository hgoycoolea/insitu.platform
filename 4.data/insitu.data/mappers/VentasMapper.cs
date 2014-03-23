using cl.maia.data.mappers;
using insitu.data.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insitu.data.mappers
{
    public class VentasMapper : IEntityMapper<Ventas>
    {
        public Ventas Map(System.Data.IDataRecord parent)
        {
            return new Ventas()
            {
                Cliente = int.Parse(parent["Cliente"].ToString()),
                FechaVenta = parent["FechaVenta"].ToString(),
                ID = int.Parse(parent["ID"].ToString()),
                Mercante = int.Parse(parent["Mercante"].ToString()),
                Monto = parent["Monto"].ToString(),
                Promocion = int.Parse(parent["Promocion"].ToString())
            };
        }
    }
}
