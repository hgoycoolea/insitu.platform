using cl.maia.data.mappers;
using insitu.data.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insitu.data.mappers
{
    public class ComprasPromocionesMapper : IEntityMapper<ComprasPromociones>
    {
        public ComprasPromociones Map(System.Data.IDataRecord parent)
        {
            return new ComprasPromociones()
            {
                ID = int.Parse(parent["ID"].ToString()),
                Cliente = int.Parse(parent["Cliente"].ToString()),
                Estado = int.Parse(parent["Estado"].ToString()),
                FechaCambioEstado = parent["FechaCambioEstado"].ToString(),
                FechaCompra = parent["FechaCompra"].ToString(),
                Guid = parent["Guid"].ToString(),
                Promocion = int.Parse(parent["Promocion"].ToString())
            };
        }
    }
}
