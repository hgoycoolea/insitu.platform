using cl.maia.data.mappers;
using insitu.data.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insitu.data.mappers
{
    public class PositionsMapper : IEntityMapper<Positions>
    {
        public Positions Map(System.Data.IDataRecord parent)
        {
            return new Positions()
            {
                Axis = parent["Axis"].ToString(),
                ID = int.Parse(parent["ID"].ToString()),
                Mercante = int.Parse(parent["Mercante"].ToString())
            };
        }
    }
}
