using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp_cuatrimestral_equipo_15
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["Theme"] = "light";
                btnTheme.Text = "🌙";
            }
        }

        protected void btnTheme_Click(object sender, EventArgs e)
        {
            if ((string)Session["Theme"] == "light")
            {
                Session["Theme"] = "dark";
                btnTheme.Text = "☀️";
            }
            else if ((string)Session["Theme"] == "dark")
            {
                Session["Theme"] = "light";
                btnTheme.Text = "🌙";
            }
        }
    }
}