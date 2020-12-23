<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina.Master" AutoEventWireup="true" CodeBehind="Perfis_Lista.aspx.cs" Inherits="SchoolSystem.Views.Perfis.Perfis_Lista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid bg-light" style="height: 100%;">
        <div class="row pt-3">
            <div class="col-12 text-center">
                <h2 class="text-roxo">Perfis</h2>
            </div>
        </div>

        <hr />

        <div class="row bg-light">
            <div class="col-0 col-sm-0 col-md-2 col-lg-2 col-xl-2 mb-1">
                <button class="navbar-toggler text-center" type="button" style="width: 100%;" data-toggle="collapse" data-target="#navbarFiltros" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                    <h4 class="text-roxo text-center">Filtros</h4>
                </button>
                <div class="collapse navbar-collapse" id="navbarFiltros">
                    <asp:TextBox ID="txtLogin" type="text" PlaceHolder="Login" class="form-text form-control campo-normal" style="width:100%;" runat="server" MaxLength="15"></asp:TextBox>
                    <asp:TextBox ID="txtPermissao" type="text" PlaceHolder="Permissão" class="form-text form-control campo-normal" style="width:100%;" runat="server" MaxLength="15"></asp:TextBox>
                    <asp:CheckBox ID="checkExcluidos" runat="server" Text="Excluídos" />
                    <asp:Button ID="btnFiltrar" class="btn btn-normal text-light" style="width: 100%;" runat="server" Text="Filtrar" OnClick="btnFiltrar_Click" />
                </div>
            </div>
            <div class="col-12 col-sm-12 col-md-8 col-lg-8 col-xl-8">
                <asp:GridView
                    ID="gridPerfis"
                    DataKeyNames="IDPERFIL"
                    runat="server"
                    AutoGenerateColumns="False"
                    class="table table-hover table-bordered"
                    AllowPaging="True"
                    OnPageIndexChanging="gridPerfis_PageIndexChanging"
                    OnSelectedIndexChanged="gridPerfis_SelectedIndexChanged">
                    <Columns>
                        <asp:CommandField SelectText="Editar" HeaderText="#" ShowSelectButton="True" ButtonType="Button" CausesValidation="False" InsertVisible="False" ShowCancelButton="False" ItemStyle-HorizontalAlign="Center" ControlStyle-CssClass="btn btn-sm btn-normal text-light" ItemStyle-VerticalAlign="Middle" ></asp:CommandField>
                        <asp:BoundField DataField="IDPERFIL" HeaderText="IDPERFIL" ShowHeader="False" Visible="False" />
                        <asp:BoundField DataField="LOGIN" HeaderText="Login" ItemStyle-HorizontalAlign="Center" ItemStyle-VerticalAlign="Middle" />
                        <asp:BoundField DataField="NOME_PERMISSAO" HeaderText="Permiss&#227;o" ItemStyle-HorizontalAlign="Center" ItemStyle-VerticalAlign="Middle" />
                    </Columns>
                    <HeaderStyle BackColor="#19194d" ForeColor="White" HorizontalAlign="Center" />
                    <PagerSettings PageButtonCount="5" />
                    <SelectedRowStyle HorizontalAlign="Left" />
                </asp:GridView>
            </div>
            <div class="col-0 col-sm-0 col-md-2 col-lg-2 col-xl-2"></div>
        </div>
    </div>
</asp:Content>
