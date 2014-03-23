﻿using cl.maia.business.facades;
using insitu.data.entities;
using insitu.data.mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insitu.business.concrete
{
    public static class RutasLogics
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Rutas Get(int id)
        {
            using (MsSqlFacade<Rutas, RutasMapper> facade = new MsSqlFacade<Rutas, RutasMapper>())
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
        public static int Create(Rutas Broker)
        {
            using (MsSqlFacade<Rutas, RutasMapper> facade = new MsSqlFacade<Rutas, RutasMapper>())
            {
                //// we use the Collection to build the broker entity on an abstract phase to manage it as a all
                return facade.Create(Broker);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Rutas> Read()
        {
            using (MsSqlFacade<Rutas, RutasMapper> facade = new MsSqlFacade<Rutas, RutasMapper>())
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
        public static int Update(Rutas Broker)
        {
            using (MsSqlFacade<Rutas, RutasMapper> facade = new MsSqlFacade<Rutas, RutasMapper>())
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
            using (MsSqlFacade<Rutas, RutasMapper> facade = new MsSqlFacade<Rutas, RutasMapper>())
            {
                //// we use the Collection to build the broker entity on an abstract phase to manage it as a all
                return facade.Delete(id);
            }
        }
    }
}