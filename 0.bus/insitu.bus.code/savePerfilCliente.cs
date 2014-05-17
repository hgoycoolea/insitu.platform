using cl.maia.business.facades;
using insitu.business.partial;
using insitu.data.entities;
using insitu.data.mappers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace insitu.bus.code
{
    public class savePerfilCliente : IHttpHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public void ProcessRequest(HttpContext context)
        {
            try
            {
                /// this is the empy response
                string Html = string.Empty;
                /// Dictionary Collection Native Encryption
                Dictionary<string, string> Collection = cl.maia.bus.Utils.ContextForm.ProcessNativeEncryptedForm(context.Request.Form);
                /// new expando object
                dynamic dynamic_obj = new ExpandoObject();
                /// foreach string for the value collection
                foreach (KeyValuePair<string, string> kvp in Collection)
                {
                    /// value for the parse id
                    if (kvp.Key == "__id")
                    {
                        dynamic_obj.ID = kvp.Value;
                    }
                    /// value for the parse id
                    if (kvp.Key == "__c")
                    {
                        dynamic_obj.Cliente = kvp.Value;
                    }
                    /// value for the parse id
                    if (kvp.Key == "__t")
                    {
                        dynamic_obj.ToleranciaDistancia = kvp.Value;
                    }
                    /// value for the parse id
                    if (kvp.Key == "__a")
                    {
                        dynamic_obj.AprendizajeCompras = kvp.Value;
                    }
                    /// value for the parse id
                    if (kvp.Key == "__ta")
                    {
                        dynamic_obj.TipoAlerta = kvp.Value;
                    }
                }
                PerfilClientes entity = new PerfilClientes();
                entity.AprendizajeCompras = int.Parse(dynamic_obj.AprendizajeCompras);
                entity.Cliente = int.Parse(dynamic_obj.Cliente);
                entity.ID = int.Parse(dynamic_obj.ID);
                entity.TipoAlerta = int.Parse(dynamic_obj.TipoAlerta);
                entity.ToleranciaDistancia = int.Parse(dynamic_obj.ToleranciaDistancia);
                /// json
                string json = ClientLogics.UpdatePerfilCliente(entity).ToString();
                /// context response
                context.Response.Write(json);
            }
            catch(Exception ex)
            {
                /// context response as an error
                context.Response.Write("{\"acknowledge\": {\"response\": \""+ex.ToString()+"\"}");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsReusable
        {
            get { throw new NotImplementedException(); }
        }
    }
}
