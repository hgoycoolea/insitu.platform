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
    public class ReadPromocionesPorCategorias : IHttpHandler
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
                string categorias = string.Empty;
                string barrio = string.Empty;
                /// foreach string for the value collection
                foreach (KeyValuePair<string, string> kvp in Collection)
                {
                    /// value for the parse id
                    if (kvp.Key == "__c")
                    {
                        categorias = kvp.Value;
                    }
                    /// value for the parse id
                    if (kvp.Key == "__b")
                    {
                        barrio = kvp.Value;
                    }
                }
                /// this will give me the categories i am looking for
                string[] categorias_split = categorias.Split(',');
                /// we convert the categorias into integers
                List<int> categorias_int = categorias_split.Select(int.Parse).ToList();
                /// json
                string json =  JsonConvert.SerializeObject(ClientLogics.ReadPromocionesPorCategorias(categorias_int,int.Parse(barrio)));
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
