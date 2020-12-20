<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cookies.aspx.cs" Inherits="SchoolSystem.Views.Avisos.Cookies" %>

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

        .text-roxo {
            color: #19194d;
        }

        .bg-roxo {
            background-color: #19194d;
        }

        .btn-normal {
            background-color: #19194d;
            border-color:black;
            border-width: 2px;
        }

        .caixa-texto {
            border-color: #19194d;
            border-left-width: 2px;
            border-right-width: 2px;
            border-left: solid;
            border-right: solid;
        }

    </style>
</head>
<body class="bg-light">
    <form id="form1" runat="server">
        <div class="container caixa-texto" style="height: 100%">
            <div class="row" style="height: 100%">
                <div class="col-12 text-center mt-5">
                    <h1 class="text-roxo">Cookies</h1>
                </div>

                <div class="col-0 col-sm-0 col-md-2 col-lg-2 col-xl-2"></div>
                <div class="col-12 col-sm-12 col-md-8 col-lg-8 col-xl-8" style="text-align:justify;">
                    <asp:Label ID="lblTexto" class="text-dark" runat="server" Text=""></asp:Label>
                </div>
                <div class="col-0 col-sm-0 col-md-2 col-lg-2 col-xl-2"></div>

                <div class="col-12 text-center">
                    <asp:LinkButton ID="linkRetornar" class="btn btn-normal text-light" style="width:150px; bottom:0px;" runat="server" href="/Login.aspx">Ok</asp:LinkButton>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
