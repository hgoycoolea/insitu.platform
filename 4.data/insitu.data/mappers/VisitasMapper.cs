using cl.maia.data.mappers;
using insitu.data.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insitu.data.mappers
{
    public class VisitasMapper : IEntityMapper<Visitas>
    {
        public Visitas Map(System.Data.IDataRecord parent)
        {
            return new Visitas()
            {
                Cliente = int.Parse(parent["Cliente"].ToString()),
                ID = int.Parse(parent["ID"].ToString()),
                Producto = int.Parse(parent["Producto"].ToString()),
                Promocion = int.Parse(parent["Promocion"].ToString()),
                Fecha = parent["Fecha"].ToString()
            };
        }
    }
}
