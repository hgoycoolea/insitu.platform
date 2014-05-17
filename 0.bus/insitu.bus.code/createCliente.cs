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
    public class createCliente : IHttpHandler
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
                    if (kvp.Key == "__n")
                    {
                        dynamic_obj.NumeroTelefono = kvp.Value;
                    }
                    /// value for the parse id
                    if (kvp.Key == "__e")
                    {
                        dynamic_obj.Email = kvp.Value;
                    }
                    /// value for the parse id
                    if (kvp.Key == "__s")
                    {
                        dynamic_obj.Sexo = kvp.Value;
                    }
                    /// value for the parse id
                    if (kvp.Key == "__no")
                    {
                        dynamic_obj.Nombre = kvp.Value;
                    }
                    /// value for the parse id
                    if (kvp.Key == "__a")
                    {
                        dynamic_obj.Apellido = kvp.Value;
                    }
                    /// value for the parse id
                    if (kvp.Key == "__u")
                    {
                        dynamic_obj.UUID = kvp.Value;
                    }
                    /// value for the parse id
                    if (kvp.Key == "__b")
                    {
                        dynamic_obj.Barrio = kvp.Value;
                    }
                }
                Clientes cliente = new Clientes();
                cliente.Apellido = dynamic_obj.Apellido;
                cliente.Barrio = int.Parse(dynamic_obj.Barrio);
                cliente.Email = dynamic_obj.Email;
                cliente.Nombre = dynamic_obj.Nombre;
                cliente.NumeroTelefono = dynamic_obj.NumeroTelefono;
                cliente.Sexo = int.Parse(dynamic_obj.Sexo);
                cliente.UUID = dynamic_obj.UUID;
                /// json
                string json = ClientLogics.CreateCliente(cliente).ToString();
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
