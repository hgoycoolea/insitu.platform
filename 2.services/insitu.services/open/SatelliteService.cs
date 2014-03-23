using insitu.business.partial;
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
        /// <param name="mercante"></param>
        public void AcknowledgePosition(string axis, int mercante)
        {
            SatelliteLogics.AcknowledgePosition(axis, mercante);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="cliente"></param>
        public void AcknowledgeRutas(string axis, int cliente)
        {
            SatelliteLogics.AcknowledgeRutas(axis, cliente);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public data.entities.Rutas GetRutas(int ID)
        {
            return SatelliteLogics.GetRutas(ID);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public data.entities.Positions GetPositions(int ID)
        {
            return SatelliteLogics.GetPositions(ID);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mercante"></param>
        /// <returns></returns>
        public List<data.entities.Positions> ReadPositions(int Mercante)
        {
            return SatelliteLogics.ReadPositions(Mercante);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cliente"></param>
        /// <returns></returns>
        public List<data.entities.Rutas> ReadRutas(int Cliente)
        {
            return SatelliteLogics.ReadRutas(Cliente);
        }
    }
}
