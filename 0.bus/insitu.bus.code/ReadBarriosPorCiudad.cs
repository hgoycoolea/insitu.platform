using insitu.business.partial;
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
    public class ReadBarriosPorCiudad : IHttpHandler
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
                string ciudad = string.Empty;
                /// foreach string for the value collection
                foreach (KeyValuePair<string, string> kvp in Collection)
                {
                    /// value for the parse client
                    if (kvp.Key == "__c")
                    {
                        ciudad = kvp.Value;
                    }
                }
                /// we now parse the city
                int int_ciudad = int.Parse(ciudad);
                /// 
                string json = JsonConvert.SerializeObject(SatelliteLogics.ReadBarriosPorCiudad(int_ciudad));
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
