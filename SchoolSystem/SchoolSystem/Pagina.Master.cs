using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchoolSystem
{
    public partial class Pagina : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Controllers.Login.VerificarLogin())
            {
                Response.Redirect("/Login.aspx");
            }
        }

        protected void linkSair_Click(object sender, EventArgs e) 
        {
            Controllers.Login.RealizarLogout();
            Response.Redirect("/Login.aspx");
        }
    }
}