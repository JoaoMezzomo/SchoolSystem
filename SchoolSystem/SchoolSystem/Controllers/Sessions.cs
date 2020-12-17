using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolSystem.Controllers
{
    public class Sessions : System.Web.UI.Page
    {
        public string Login 
        {
            get 
            {
                return Page.Session["Login"].ToString();
            }
            set 
            {
                Page.Session["Login"] = value;
            } 
        }

        public string Senha
        {
            get
            {
                return Page.Session["Senha"].ToString();
            }
            set
            {
                Page.Session["Senha"] = value;
            }
        }
    }
}