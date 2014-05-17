using cl.maia.business.facades;
using insitu.data.entities;
using insitu.data.mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insitu.business.concrete
{
    public static class ComprasPromocionesLogics
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static ComprasPromociones Get(int id)
        {
            using (MsSqlFacade<ComprasPromociones, ComprasPromocionesMapper> facade = new MsSqlFacade<ComprasPromociones, ComprasPromocionesMapper>())
            {
                //// we use the Collection to build the broker entity on an abstract phase to manage it as a all
                return facade.Read().Single(p => p.ID == id);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Broker"></param>
        /// <returns></returns>
        public static int Create(ComprasPromociones Broker)
        {
            using (MsSqlFacade<ComprasPromociones, ComprasPromocionesMapper> facade = new MsSqlFacade<ComprasPromociones, ComprasPromocionesMapper>())
            {
                //// we use the Collection to build the broker entity on an abstract phase to manage it as a all
                return facade.Create(Broker);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<ComprasPromociones> Read()
        {
            using (MsSqlFacade<ComprasPromociones, ComprasPromocionesMapper> facade = new MsSqlFacade<ComprasPromociones, ComprasPromocionesMapper>())
            {
                //// we use the Collection to build the broker entity on an abstract phase to manage it as a all
                return facade.Read();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Broker"></param>
        /// <returns></returns>
        public static int Update(ComprasPromociones Broker)
        {
            using (MsSqlFacade<ComprasPromociones, ComprasPromocionesMapper> facade = new MsSqlFacade<ComprasPromociones, ComprasPromocionesMapper>())
            {
                //// we use the Collection to build the broker entity on an abstract phase to manage it as a all
                return facade.Update(Broker);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int Delete(int id)
        {
            using (MsSqlFacade<ComprasPromociones, ComprasPromocionesMapper> facade = new MsSqlFacade<ComprasPromociones, ComprasPromocionesMapper>())
            {
                //// we use the Collection to build the broker entity on an abstract phase to manage it as a all
                return facade.Delete(id);
            }
        }
    }
}
