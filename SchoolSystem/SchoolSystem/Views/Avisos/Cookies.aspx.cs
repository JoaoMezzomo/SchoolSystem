using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchoolSystem.Views.Avisos
{
    public partial class Cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblTexto.Text = Texto();
        }

        private string Texto() 
        {
            string texto = @"   Identificamos que seu navegador está com o uso de cookies desativado, ou o mesmo não suporta esta tecnologia.
    O SchoolSytem faz utilização de cookies para prorporcionar uma melhor experiência de uso para seus usuários.
    Caso esteja com os cookies desativados em seus navegador, recomendamos que ative essa tecnologia para poder utilizar o sistema.
    Caso seu navegador não suporte cookies, recomendamos a utilização dos seguintes navegadores: Microsoft Edge, Mozilla Firefox ou Google Chrome.";

            return texto;
        }
    }
}