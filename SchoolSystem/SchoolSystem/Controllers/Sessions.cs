using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolSystem.Controllers
{
    public class Sessions : System.Web.UI.Page
    {
        public Int64 CAD_PERFIS_IDPERFIL
        {
            get
            {
                return Page.Session["CAD_PERFIS_IDPERFIL"] != null ? Convert.ToInt64(Page.Session["CAD_PERFIS_IDPERFIL"]) : 0;
            }
            set
            {
                Page.Session["CAD_PERFIS_IDPERFIL"] = value;
            }
        }

        public string CAD_PERFIS_LOGIN 
        {
            get 
            {
                return Page.Session["CAD_PERFIS_LOGIN"] != null ? Page.Session["CAD_PERFIS_LOGIN"].ToString() : "";
            }
            set 
            {
                Page.Session["CAD_PERFIS_LOGIN"] = value;
            } 
        }

        public string CAD_PERFIS_SENHA
        {
            get
            {
                return Page.Session["CAD_PERFIS_SENHA"] != null ? Page.Session["CAD_PERFIS_SENHA"].ToString() : "";
            }
            set
            {
                Page.Session["CAD_PERFIS_SENHA"] = value;
            }
        }
    }
}