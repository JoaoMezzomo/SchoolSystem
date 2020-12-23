using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SchoolSystem.Models;
using SchoolSystem.Controllers;
using System.Data;

namespace SchoolSystem.Views.Perfis
{
    public partial class Perfis_Lista : System.Web.UI.Page
    {
        private static Sessions SessionsSite = new Sessions();
        private static DataTable DataTableGrid = new DataTable();

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
            //if (SessionsSite.CAD_PERFIS_IDPERMISSAO != (int)Enums.Permissoes.Admin)
            //{
            //    Response.Redirect("/Login.aspx");
            //}
        }

        private void CarregarTabela() 
        {
            if (!checkExcluidos.Checked)
            {
                DataTableGrid = Controllers.Perfis.BuscarTodosPerfisTabela_NaoExcluidos();
            }
            else
            {
                DataTableGrid = Controllers.Perfis.BuscarTodosPerfisTabela_Excluidos();
            }

            gridPerfis.DataSource = DataTableGrid;
        }

        protected void gridPerfis_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridPerfis.DataSource = DataTableGrid;
            gridPerfis.PageIndex = e.NewPageIndex;
            gridPerfis.DataBind();
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            CarregarTabela();
            gridPerfis.DataBind();

            if (string.IsNullOrEmpty(txtLogin.Text) && string.IsNullOrEmpty(txtPermissao.Text))
            {
                return;
            }

            DataTable dataTableFiltro = DataTableGrid.Clone();

            foreach (DataRow row in DataTableGrid.Rows)
            {
                if (!string.IsNullOrEmpty(txtLogin.Text) && !string.IsNullOrEmpty(txtPermissao.Text))
                {
                    if (row["LOGIN"].ToString().ToUpper() == txtLogin.Text.ToUpper() && row["NOME_PERMISSAO"].ToString().ToUpper() == txtPermissao.Text.ToUpper())
                    {
                        dataTableFiltro.ImportRow(row);
                    }
                }
                else if (!string.IsNullOrEmpty(txtLogin.Text))
                {
                    if (row["LOGIN"].ToString().ToUpper() == txtLogin.Text.ToUpper())
                    {
                        dataTableFiltro.ImportRow(row);
                    }
                }
                else if (!string.IsNullOrEmpty(txtPermissao.Text)) 
                {
                    if (row["NOME_PERMISSAO"].ToString().ToUpper() == txtPermissao.Text.ToUpper())
                    {
                        dataTableFiltro.ImportRow(row);
                    }
                }   
            }

            if (dataTableFiltro.Rows.Count <= 0)
            {
                DataRow rowZero = dataTableFiltro.NewRow();
                dataTableFiltro.Rows.Add(rowZero);
            }

            DataTableGrid = dataTableFiltro;
            gridPerfis.DataSource = DataTableGrid;
            gridPerfis.DataBind();
        }

        protected void gridPerfis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gridPerfis.SelectedIndex < 0)
            {
                return;
            }

            string chave = "";
            chave = gridPerfis.SelectedDataKey.Value.ToString();

            if (string.IsNullOrEmpty(chave))
            {
                return;
            }

            Global.CookieCriar(Global.CK_IDPERFIL, chave, this.Request, this.Response);
            Global.CookieCriar(Global.CK_PAGINAANTERIOR, "/Views/Perfis/Perfis_Lista.aspx", this.Request, this.Response);

            Response.Redirect("/Views/Perfis/Perfis_Edita.aspx");
        }
    }
}