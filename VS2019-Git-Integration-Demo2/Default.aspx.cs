using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VS2019_Git_Integration_Demo2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProgrammingPref obj = new ProgrammingPref();
            lblMsg.Text = obj.MyPreference();
        }
    }
}