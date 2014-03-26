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
    public class AcknowledgeRutas : IHttpHandler
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
                    /// value for the parse client
                    if (kvp.Key == "__c")
                    {
                        dynamic_obj.cliente = kvp.Value;
                    }
                    /// value for the parse axis
                    if (kvp.Key == "__a")
                    {
                        dynamic_obj.axis = kvp.Value;
                    }
                    /// value for the parse speed
                    if (kvp.Key == "__s")
                    {
                        dynamic_obj.speed = kvp.Value;
                    }
                }
                /// json convert
                string json = JsonConvert.SerializeObject(SatelliteLogics.AcknowledgeRutas(dynamic_obj.axis, dynamic_obj.speed, int.Parse(dynamic_obj.cliente)));
                /// context response
                context.Response.Write(json);
            }
            catch (Exception ex)
            {
                /// context response as an error
                context.Response.Write("{\"acknowledge\": {\"response\": \"" + ex.ToString() + "\"}");
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
