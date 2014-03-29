using System;
using System.Collections.Generic;
using System.Configuration;
using System.Device.Location;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace insitu.web.code
{
    public class Default : System.Web.UI.Page
    {
        /// <summary>
        /// Load Event that's managed on the page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Page_Load(object sender, System.EventArgs e)
        {
            string axis = "-33.0049102,-68.91068740000003";
            string axis1 = "-33.015278,-68.907173";
            /// first we get the lat and lon in terms of (x,y) -> (lat, lon)
            string[] geo = axis.Split(',');

            string[] geo1 = axis1.Split(',');
            /// latitude
            double lat1 = double.Parse(geo[0]);
            /// longitude
            double lon1 = double.Parse(geo[1]);
            /// latitude
            double lat2 = double.Parse(geo1[0]);
            /// longitude
            double lon2 = double.Parse(geo1[1]);

            GeoCoordinate coord1 = new GeoCoordinate(lat1, lon1);
            GeoCoordinate coord2 = new GeoCoordinate(lat2, lon2);

            double distance = coord1.GetDistanceTo(coord2);

            Response.Write(distance.ToString());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPreRender(EventArgs e)
        {
            /// base render override for the page
            base.OnPreRender(e);
        }
        /// <summary>
        /// OnInit Method that takes the first initialization for the handlers
        /// </summary>
        /// <param name="e"></param>
        override protected void OnInit(EventArgs e)
        {
            //
            // CODEGEN: This call is required by the ASP.NET Web Form Designer.
            //
            InitializeComponent();
            base.OnInit(e);
        }
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            /// Event Handlers
            this.Load += new System.EventHandler(this.Page_Load);
        }
    }
}
