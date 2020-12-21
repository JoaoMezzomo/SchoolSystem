using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SchoolSystem.Models;
using SchoolSystem.Controllers;

namespace SchoolSystem.Views.Perfis
{
    public partial class Perfis_Lista : System.Web.UI.Page
    {
        private static Sessions SessionsSite = new Sessions();

        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarPermissao();

            if (!IsPostBack)
            {
                CarregarTabela();
                gridPerfis.DataBind();
            }
        }

        private void CarregarPermissao()
        {
            if (SessionsSite.CAD_PERFIS_IDPERMISSAO != (int)Enums.Permissoes.Admin)
            {
                Response.Redirect("/Login.aspx");
            }
        }

        private void CarregarTabela() 
        {
            gridPerfis.DataSource = Controllers.Perfis.BuscarTodosPerfisTabela();
        }

        protected void gridPerfis_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            CarregarTabela();
            gridPerfis.PageIndex = e.NewPageIndex;
            gridPerfis.DataBind();
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow gridRow in gridPerfis.Rows)
            {
                CheckBox checkbox = gridRow.FindControl("checkGridSelecionar") as CheckBox;

                if (checkbox.Checked)
                {
                    gridPerfis.SelectedIndex = gridRow.RowIndex;

                    Global.CookieCriar(Global.CK_IDPERFIL, gridPerfis.SelectedDataKey.Value.ToString(), this.Request, this.Response);
                    Global.CookieCriar(Global.CK_PAGINAANTERIOR, "/Views/Perfis/Perfis_Lista.aspx", this.Request, this.Response);

                    Response.Redirect("/Views/Perfis/Perfis_Edita.aspx");
                    break;
                }
            }

            Global.MostrarMensagem(this, "Nenhum item selecionado para edição!");
        }
    }
}