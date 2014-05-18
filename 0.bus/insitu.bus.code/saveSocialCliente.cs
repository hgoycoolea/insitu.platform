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
    public class saveSocialCliente : IHttpHandler
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
                    if (kvp.Key == "__u")
                    {
                        dynamic_obj.UsuarioSocial = kvp.Value;
                    }
                    /// value for the parse id
                    if (kvp.Key == "__t")
                    {
                        dynamic_obj.TipoSocial = kvp.Value;
                    }
                    /// value for the parse id
                    if (kvp.Key == "__l")
                    {
                        dynamic_obj.Locacion = kvp.Value;
                    }
                    /// value for the parse id
                    if (kvp.Key == "__d")
                    {
                        dynamic_obj.Descripcion = kvp.Value;
                    }
                    /// value for the parse id
                    if (kvp.Key == "__u")
                    {
                        dynamic_obj.UrlImagen = kvp.Value;
                    }
                }
                SocialClientes entity = new SocialClientes();
                entity.Descripcion = dynamic_obj.Descripcion;
                entity.Locacion = dynamic_obj.Locacion;
                entity.NombreSocial = dynamic_obj.NombreSocial;
                entity.TipoSocial = int.Parse(dynamic_obj.TipoSocial);
                entity.Locacion = dynamic_obj.Locacion;
                entity.UrlImagen = dynamic_obj.UrlImagen;
                entity.UsuarioSocial = dynamic_obj.UsuarioSocial;
                int id_aux = int.Parse(dynamic_obj.ID);
                string json = string.Empty;
                if (id_aux != -1)
                {
                    /// json
                    json = ClientLogics.CreateSocialCliente(entity).ToString();
                }
                else
                {
                    json = ClientLogics.UpdateSocialCliente(entity).ToString();
                }
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
