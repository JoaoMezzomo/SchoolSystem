<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina.Master" AutoEventWireup="true" CodeBehind="Perfis_Edita.aspx.cs" Inherits="SchoolSystem.Views.Perfis.Perfis_Edita" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid bg-light" style="height: 100%;">
        <div class="row pt-3">
            <div class="col-12 text-center">
                <h2 class="text-roxo">Perfil</h2>
            </div>
        </div>
        <hr />
        <div class="row">
            <div class="col-12 col-sm-12 col-md-3 col-lg-3 col-xl-3">
                <asp:Label ID="lblLogin" for="txtLogin" class="text-roxo" runat="server" Text="Login"></asp:Label>
                <asp:TextBox ID="txtLogin" type="text" class="form-text form-control campo-obrigatorio" style="width:100%;" runat="server" MaxLength="15"></asp:TextBox>
                <asp:RequiredFieldValidator ID="reqtxtLogin" runat="server" ErrorMessage="Campo Obrigatório" ControlToValidate="txtLogin" ValidationGroup="Obrigatorio" Display="Dynamic" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </div>
            <div class="col-12 col-sm-12 col-md-3 col-lg-3 col-xl-3">
                <asp:Label ID="lblSenha" for="txtSenha" class="text-roxo" runat="server" Text="Senha"></asp:Label>
                <asp:TextBox ID="txtSenha" type="password" class="form-text form-control campo-obrigatorio" style="width:100%;" runat="server" MaxLength="30"></asp:TextBox>
                <asp:RequiredFieldValidator ID="reqtxtSenha" runat="server" ErrorMessage="Campo Obrigatório" ControlToValidate="txtSenha" ValidationGroup="Obrigatorio" Display="Dynamic" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </div>
            <div class="col-12 col-sm-12 col-md-3 col-lg-3 col-xl-3 pt-1">
                <asp:Label ID="Label1" for="ddlPermissao" class="text-roxo" runat="server" Text="Permissão"></asp:Label>
                <asp:DropDownList ID="ddlPermissao" class="form-control campo-obrigatorio" style="width:100%;" runat="server"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="reqddlPermissao" runat="server" ErrorMessage="Campo Obrigatório" ControlToValidate="ddlPermissao" ValidationGroup="Obrigatorio" Display="Dynamic" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </div>
            <div class="col-12 col-sm-12 col-md-3 col-lg-3 col-xl-3">
                <asp:Label ID="lblCPF" for="txtCPF" class="text-roxo" runat="server" Text="CPF"></asp:Label>
                <asp:TextBox ID="txtCPF" type="text" class="form-text form-control campo-normal" style="width:100%;" runat="server" MaxLength="30"></asp:TextBox>
            </div>
        </div>
        <div class="row pt-0 pt-sm-0 pt-md-3 pt-lg-3 pt-xl-3">
            <div class="col-12 col-sm-12 col-md-6 col-lg-6 col-xl-6">
                <asp:Label ID="lblNome" for="txtNome" class="text-roxo" runat="server" Text="Nome"></asp:Label>
                <asp:TextBox ID="txtNome" type="text" class="form-text form-control campo-obrigatorio" style="width:100%;" runat="server" MaxLength="50"></asp:TextBox>
                <asp:RequiredFieldValidator ID="reqtxtNome" runat="server" ErrorMessage="Campo Obrigatório" ControlToValidate="txtNome" ValidationGroup="Obrigatorio" Display="Dynamic" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </div>
            <div class="col-12 col-sm-12 col-md-3 col-lg-3 col-xl-3">
                <asp:Label ID="lblIdade" for="txtIdade" class="text-roxo" runat="server" Text="Idade"></asp:Label>
                <asp:TextBox ID="txtIdade" type="text" class="form-text form-control campo-normal" style="width:100%;" runat="server" MaxLength="3"></asp:TextBox>
            </div>
            <div class="col-12 col-sm-12 col-md-3 col-lg-3 col-xl-3 pt-1">
                <asp:Label ID="lblSexo" for="ddlSexo" class="text-roxo" runat="server" Text="Sexo"></asp:Label>
                <asp:DropDownList ID="ddlSexo" class="form-control campo-normal" style="width:100%;" runat="server"></asp:DropDownList>
            </div>
        </div>
        <div class="row mt-0 mt-sm-0 mt-md-3 mt-lg-3 mt-xl-3">
            <div class="col-12 col-sm-12 col-md-6 col-lg-6 col-xl-6">
                <asp:Label ID="lblEndereco" for="txtEndereco" class="text-roxo" runat="server" Text="Endereço"></asp:Label>
                <asp:TextBox ID="txtEndereco" type="text" class="form-text form-control campo-normal" style="width:100%;" runat="server" MaxLength="100"></asp:TextBox>
            </div>
            <div class="col-12 col-sm-12 col-md-3 col-lg-3 col-xl-3">
                <asp:Label ID="lblTelFixo" for="txtTelFixo" class="text-roxo" runat="server" Text="Telefone Fixo"></asp:Label>
                <asp:TextBox ID="txtTelFixo" type="text" class="form-text form-control campo-normal" style="width:100%;" runat="server" MaxLength="50"></asp:TextBox>
            </div>
            <div class="col-12 col-sm-12 col-md-3 col-lg-3 col-xl-3">
                <asp:Label ID="lblTelCelular" for="txtTelCelular" class="text-roxo" runat="server" Text="Telefone Celular"></asp:Label>
                <asp:TextBox ID="txtTelCelular" type="text" class="form-text form-control campo-normal" style="width:100%;" runat="server" MaxLength="50"></asp:TextBox>
            </div>
        </div>
        <div class="row mt-0 mt-sm-0 mt-md-3 mt-lg-3 mt-xl-3">
            <div class="col-12 col-sm-12 col-md-6 col-lg-6 col-xl-6">
                <asp:Label ID="lblNomePai" for="txtNomePai" class="text-roxo" runat="server" Text="Nome do Pai"></asp:Label>
                <asp:TextBox ID="txtNomePai" type="text" class="form-text form-control campo-normal" style="width:100%;" runat="server" MaxLength="50"></asp:TextBox>
            </div>
            <div class="col-12 col-sm-12 col-md-6 col-lg-6 col-xl-6">
                <asp:Label ID="lblNomeMae" for="txtNomeMae" class="text-roxo" runat="server" Text="Nome da Mãe"></asp:Label>
                <asp:TextBox ID="txtNomeMae" type="text" class="form-text form-control campo-normal" style="width:100%;" runat="server" MaxLength="50"></asp:TextBox>
            </div>
        </div>
        <div class="row mt-0 mt-sm-0 mt-md-3 mt-lg-3 mt-xl-3">
            <div class="col-12">
                <asp:CheckBox ID="checkExcluido" runat="server" />
                <asp:Label ID="lblExcluido" for="checkExcluido" class="text-roxo" runat="server" Text="Excluído"></asp:Label>
            </div>
        </div>
        <div class="row my-3">
            <div class="col-12 col-sm-12 col-md-2 col-lg-2 col-xl-2 text-center text-sm-center text-md-left text-lg-left text-xl-left">
                <asp:Button ID="btnSalvar" class="btn mt-3 text-light btn-salvar" runat="server" Text="Salvar" style="width: 70%;" ValidationGroup="Obrigatorio" CausesValidation="True" OnClick="btnSalvar_Click" />
            </div>
            <div class="col-0 col-sm-0 col-md-8 col-lg-8 col-xl-8"></div>
            <div class="col-12 col-sm-12 col-md-2 col-lg-2 col-xl-2 text-center text-sm-center text-md-right text-lg-right text-xl-right">
                <asp:Button ID="btnCancelar" class="btn mt-3 text-light btn-cancelar" runat="server" Text="Cancelar" style="width: 70%;" OnClick="btnCancelar_Click" />
            </div>
        </div>
    </div>
</asp:Content>
