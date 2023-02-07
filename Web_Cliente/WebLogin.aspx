<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebLogin.aspx.cs" Inherits="Web_Cliente.Login.WebLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="padded">
        <div class="container">
            <div class="row">
                <div class="col-md-4"></div>
                <div class="col-md-4">
                        <h2 class="titulo-subpaginas" style="margin-bottom: 50px;">Inicio de Sesión</h2>
                        <div class="form-group">
                            <asp:TextBox ID="txtCorreo" runat="server" type="text" class="form-control" placeholder="usuario"></asp:TextBox>
                        </div>
                        <div class="form-group" style="margin-bottom: 30px;">
                            <asp:TextBox ID="txtClave" runat="server" type="password" class="form-control" placeholder="clave"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Button class="btn btn-buscar" ID="btnIniciarSesion" runat="server" Text="Iniciar sesión" style="margin-bottom: 100px;" OnClick="btnIniciarSesion_Click" />
                        </div>
                   
                </div>
                <div class="col-md-4"></div>
            </div>
        </div>
    </section>
</asp:Content>
