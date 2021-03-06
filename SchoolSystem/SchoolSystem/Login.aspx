﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SchoolSystem.Login" %>

<!DOCTYPE html>

<html lang="pt-br">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>SchoolSystem - Login</title>

    <link href="/Content/bootstrap.css" rel="stylesheet"/>
    <script src="/Scripts/jQuery.js" type="text/javascript"></script>
    <script src="/Scripts/bootstrap.js" type="text/javascript"></script>
    <style>
        html, body, form {
            height: 100%;
        }

        .titulo-central {
            position: absolute;
            top: 40%;
            left: 25%;
        }

        .campo-obrigatorio {
            border-color:#ff1a1a;
        }

        .campo-normal {
            border-color:black;
        }

        .text-roxo {
            color: #19194d;
        }

        .bg-roxo {
            background-color: #19194d;
        }

        .btn-salvar {
            background-color: #19194d;
            border-color:green;
            border-width: 2px;
        }

        .btn-cancelar {
            background-color: #19194d;
            border-color:#ff1a1a;
            border-width: 2px;
        }

        .btn-normal {
            background-color: #19194d;
            border-color:black;
            border-width: 2px;
        }
    </style>

    <script>
        function EsqueciASenha() {
            alert('Entre em contato com a diretoria da escola para criar uma nova senha.')
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fliud" style="height: 100%;">
            <div class="row" style="height: 100%;">
                <div class="col-0 col-sm-0 col-md-8 col-lg-8 col-xl-8 d-none d-sm-none d-md-block d-lg-block d-xl-block bg-roxo" style="height: 100%;">
                    <h1 class="titulo-central text-light">SchoolSystem</h1>
                </div>
                <div class="col-12 col-sm-12 col-md-4 col-lg-4 col-xl-4 d-block d-sm-block d-md-block d-lg-block d-xl-block bg-light" style="height: 100%;">
                    <div class="container pt-5 mt-5">
                        <div class="row text-center">
                            <h1 class="text-roxo">SchoolSystem</h1>
                        </div>
                        <div class="row">
                            <div class="col-0 col-sm-0 col-md-1 col-lg-1 col-xl-1"></div>
                            <div class="col-12 col-sm-12 col-md-10 col-lg-10 col-xl-10">
                                <asp:Label ID="lblLogin" for="txtLogin" class="text-roxo" runat="server" Text="Login"></asp:Label>
                                <asp:TextBox ID="txtLogin" type="text" class="form-text form-control campo-normal" runat="server" MaxLength="15"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="reqtxtLogin" runat="server" ErrorMessage="Informe seu Login" ControlToValidate="txtLogin" ValidationGroup="Obrigatorio" Display="Dynamic" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-0 col-sm-0 col-md-1 col-lg-1 col-xl-1"></div>
                        </div>
                        <div class="row">
                            <div class="col-0 col-sm-0 col-md-1 col-lg-1 col-xl-1"></div>
                            <div class="col-12 col-sm-12 col-md-10 col-lg-10 col-xl-10">
                                <asp:Label ID="lblSenha" for="txtSenha"  class="text-roxo" runat="server" Text="Senha"></asp:Label>
                                <asp:TextBox ID="txtSenha" type="password" class="form-control campo-normal" runat="server" MaxLength="30"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="reqtxtSenha" runat="server" ErrorMessage="Informe sua Senha" ControlToValidate="txtSenha" ValidationGroup="Obrigatorio" Display="Dynamic" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-0 col-sm-0 col-md-1 col-lg-1 col-xl-1"></div>
                        </div>
                        <div class="row text-center mt-3">
                            <div class="col-2"></div>
                            <div class="col-8">
                                <asp:Button ID="btnEntrar" class="btn text-light btn-normal" runat="server" Text="Entrar" style="width: 100%;" OnClick="btnEntrar_Click" ValidationGroup="Obrigatorio" CausesValidation="True" />
                                <asp:Label ID="lblSenhaIncorreta"  class="text-danger" runat="server" Text="Usuário ou Senha Incorretos" Visible="False"></asp:Label>
                            </div>
                            <div class="col-2"></div>
                        </div>
                        <div class="row text-center mt-2">
                            <div class="col-12">
                                <asp:HyperLink ID="linkEsqueceuASenha" class="text-primary" runat="server" href="#" onclick="EsqueciASenha()">Esqueceu a senha?</asp:HyperLink>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
