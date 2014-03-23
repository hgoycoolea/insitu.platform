using insitu.contracts.open;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insitu.services.open
{
    public class SatelliteService : ISatelliteContract
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="cliente"></param>
        public void AcknowledgePosition(string axis, int cliente)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mercante"></param>
        /// <returns></returns>
        public data.entities.Rutas GetRutas(int Mercante)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cliente"></param>
        /// <returns></returns>
        public List<data.entities.Positions> ReadPositions(int Cliente)
        {
            throw new NotImplementedException();
        }
    }
}
