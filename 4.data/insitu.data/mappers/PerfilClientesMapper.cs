using cl.maia.data.mappers;
using insitu.data.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insitu.data.mappers
{
    public class PerfilClientesMapper : IEntityMapper<PerfilClientes>
    {
        public PerfilClientes Map(System.Data.IDataRecord parent)
        {
            return new PerfilClientes()
            {
                Cliente = int.Parse(parent["Cliente"].ToString()),
                ID = int.Parse(parent["ID"].ToString()),
                AprendizajeCompras = int.Parse(parent["AprendizajeCompras"].ToString()),
                TipoAlerta = int.Parse(parent["TipoAlerta"].ToString()),
                ToleranciaDistancia = int.Parse(parent["ToleranciaDistancia"].ToString())
            };
        }
    }
}
