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
        <div class="row">
            <div class="col-0 col-sm-0 col-md-2 col-lg-2 col-xl-2"></div>
            <div class="col-12 col-sm-12 col-md-1 col-lg-1 col-xl-1">
                <asp:Button ID="btnEditar" class="btn btn-normal text-light" style="width: 100%;" runat="server" Text="Editar" OnClick="btnEditar_Click" />
            </div>
            <div class="col-0 col-sm-0 col-md-9 col-lg-9 col-xl-9"></div>
        </div>

        <div class="row">
            <div class="col-0 col-sm-0 col-md-2 col-lg-2 col-xl-2"></div>
            <div class="col-12 col-sm-12 col-md-8 col-lg-8 col-xl-8">
                <hr />
            </div>
            <div class="col-0 col-sm-0 col-md-2 col-lg-2 col-xl-2"></div>
        </div>

        <div class="row bg-light">
            <div class="col-0 col-sm-0 col-md-2 col-lg-2 col-xl-2"></div>
            <div class="col-12 col-sm-12 col-md-8 col-lg-8 col-xl-8">
                <asp:GridView
                    ID="gridPerfis"
                    DataKeyNames="IDPERFIL"
                    runat="server"
                    AutoGenerateColumns="False"
                    class="table table-hover table-bordered"
                    AllowPaging="True"
                    OnPageIndexChanging="gridPerfis_PageIndexChanging">
                    <Columns>
                        <asp:TemplateField HeaderText="#" ItemStyle-HorizontalAlign="Center">  
                            <EditItemTemplate>  
                                <asp:CheckBox ID="checkGridSelecionar" runat="server"/>  
                            </EditItemTemplate>  
                            <ItemTemplate>  
                                <asp:CheckBox ID="checkGridSelecionar" runat="server"/>  
                            </ItemTemplate>  
                        </asp:TemplateField>  
                        <asp:BoundField DataField="IDPERFIL" HeaderText="IDPERFIL" ShowHeader="False" Visible="False" />
                        <asp:BoundField DataField="LOGIN" HeaderText="Login" ItemStyle-HorizontalAlign="Center" />
                        <asp:BoundField DataField="IDPERMISSAO" HeaderText="Permiss&#227;o" ItemStyle-HorizontalAlign="Center" />
                    </Columns>
                    <HeaderStyle BackColor="#19194d" ForeColor="White" HorizontalAlign="Center" />
                    <PagerSettings PageButtonCount="5" />
                </asp:GridView>
            </div>
            <div class="col-0 col-sm-0 col-md-2 col-lg-2 col-xl-2"></div>
        </div>
    </div>
</asp:Content>
