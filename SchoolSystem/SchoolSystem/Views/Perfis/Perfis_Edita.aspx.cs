using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SchoolSystem.Controllers;
using SchoolSystem.Models;

namespace SchoolSystem.Views.Perfis
{
    public partial class Perfis_Edita : System.Web.UI.Page
    {
        private static Sessions SessionsSite = new Sessions();
        private static CAD_PERFIS Perfil = new CAD_PERFIS();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarPagina();
                CarregarDados();
                CarregarPermissao();
            }
        }

        private void CarregarPagina() 
        {
            ddlSexo.Items.Clear();
            ddlSexo.Items.Add(new ListItem("", "0"));
            ddlSexo.Items.Add(new ListItem("Masculino", "M"));
            ddlSexo.Items.Add(new ListItem("Feminino", "F"));

            ddlPermissao.Items.Clear();
            ddlPermissao.Items.Add(new ListItem("", "0"));

            List<CAD_PERMISSOES> permissoes = Controllers.Permissoes.BuscarTodasPermissoes();

            foreach (CAD_PERMISSOES permissao in permissoes)
            {
                ddlPermissao.Items.Add(new ListItem(permissao.NOME, permissao.IDPERMISSAO.ToString()));
            }
        }

        private void CarregarDados() 
        {
            Perfil = Controllers.Perfis.BuscarDadosPerfil(SessionsSite.CAD_PERFIS_IDPERFIL);

            txtLogin.Text = Perfil.LOGIN;

            txtSenha.Text = Perfil.SENHA;

            ddlPermissao.SelectedValue = Perfil.IDPERMISSAO.ToString();

            txtCPF.Text = Perfil.CPF;

            txtNome.Text = Perfil.NOME;

            if (Perfil.IDADE != 0)
            {
                txtIdade.Text = Perfil.IDADE.ToString();
            }
            else
            {
                txtIdade.Text = "";
            }

            if (Perfil.SEXO == 'M' || Perfil.SEXO == 'F')
            {
                ddlSexo.SelectedValue = Perfil.SEXO.ToString();
            }
            else
            {
                ddlSexo.SelectedIndex = -1;
            }

            txtEndereco.Text = Perfil.ENDERECO;

            txtTelFixo.Text = Perfil.TELEFONE_FIXO;

            txtTelCelular.Text = Perfil.TELEFONE_CELULAR;

            txtNomePai.Text = Perfil.NOME_PAI;

            txtNomeMae.Text = Perfil.NOME_MAE;

            if (Perfil.EXCLUIDO)
            {
                checkExcluido.Checked = true;
            }
            else
            {
                checkExcluido.Checked = false;
            }

        }

        private void CarregarPermissao() 
        {
            if (SessionsSite.CAD_PERFIS_IDPERMISSAO != (int)Enums.Permissoes.Admin)
            {
                txtLogin.Attributes.Add("disabled", null);
                txtSenha.Attributes.Add("disabled", null);
                ddlPermissao.Attributes.Add("disabled", null);
                checkExcluido.Enabled = false;
            }
        }
    }
}