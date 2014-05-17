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
    public static class SocialClientesLogic
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static SocialClientes Get(int id)
        {
            using (MsSqlFacade<SocialClientes, SocialClientesMapper> facade = new MsSqlFacade<SocialClientes, SocialClientesMapper>())
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
        public static int Create(SocialClientes Broker)
        {
            using (MsSqlFacade<SocialClientes, SocialClientesMapper> facade = new MsSqlFacade<SocialClientes, SocialClientesMapper>())
            {
                //// we use the Collection to build the broker entity on an abstract phase to manage it as a all
                return facade.Create(Broker);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<SocialClientes> Read()
        {
            using (MsSqlFacade<SocialClientes, SocialClientesMapper> facade = new MsSqlFacade<SocialClientes, SocialClientesMapper>())
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
        public static int Update(SocialClientes Broker)
        {
            using (MsSqlFacade<SocialClientes, SocialClientesMapper> facade = new MsSqlFacade<SocialClientes, SocialClientesMapper>())
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
            using (MsSqlFacade<SocialClientes, SocialClientesMapper> facade = new MsSqlFacade<SocialClientes, SocialClientesMapper>())
            {
                //// we use the Collection to build the broker entity on an abstract phase to manage it as a all
                return facade.Delete(id);
            }
        }
    }
}
