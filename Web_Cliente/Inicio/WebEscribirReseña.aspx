<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebEscribirReseña.aspx.cs" Inherits="Web_Cliente.Inicio.WebEscribirReseña" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <nav id="navi" class="navbar navbar-expand-lg navbar-light sticky-top">
        <div class="container">
            <a id="titulo" class="navbar-brand">Reserva Restaurante</a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>

            <div class="collapse navbar-collapse" id="navbarSupportedContent">
                <ul class="navbar-nav mr-auto">
                    <li class="nav-item"> </li>
                </ul>
                <ul class="navbar-nav mr-right">
                    <li class="nav-item">
                        <asp:HyperLink NavigateUrl="~/Inicio/WebRestaurantes.aspx" class="nav-link" runat="server">Restaurantes</asp:HyperLink>
                    </li>
                    <li class="nav-item">
                        <asp:HyperLink NavigateUrl="~/Inicio/WebMisReservas.aspx" class="nav-link" runat="server">Mis Reservas</asp:HyperLink>
                    </li>
                    
                    <li class="nav-item">
                        <asp:HyperLink NavigateUrl="~/Inicio/WebMisReseñas.aspx" class="nav-link" runat="server">Mis Reseñas</asp:HyperLink>
                    </li>
                    <li class="nav-item">
                        <asp:HyperLink NavigateUrl="~/WebInicio.aspx" class="nav-link" runat="server">Cerrar Sesión</asp:HyperLink>
                    </li>
                </ul>
            </div>
        </div>
    </nav>

    <section class="drivers-area bg-img" style="background-image: url(https://cdn.otstatic.com/cfe/7/images/banner-1280-85a499.jpg)">
      <div class="title-area">
        <p>Escriba</p>
        <h2>Su Reseña</h2>
      </div>
    </section>

    <section class="padded" style="padding-top: 100px; padding-bottom: 100px;">
        <div class="container">
            <div class="row">
                <div class="col-md-4"></div>
                <div class="col-md-4">
                        <div class="form-group">
                            <label>Restaurante</label>
                            <asp:TextBox ID="txtRestaurante" runat="server" class="form-control" ReadOnly="True"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Título</label>
                            <asp:TextBox ID="txtTitulo" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group" style="margin-bottom: 30px;">
                            <label>Contenido</label>
                            <asp:Textbox ID="txtContenido" mode="multiline" runat="server" class="form-control" ></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Button class="btn btn-buscar" ID="btnEscribirReseña" runat="server" Text="Enviar" style="margin-bottom: 100px;" OnClick="btnEscribirReseña_Click" />
                        </div>
                   
                </div>
                <div class="col-md-4"></div>
            </div>
        </div>
    </section>
    
    <section id="footer">
            <div class="container">
                <div class="col-md-12">
                    <ul>
                        <li><a href="#nosotros">Nosotros</a></li>
                        <li><a href="#contacto">Contacto</a></li>
                    </ul>
                </div>
                <div id="social">
                    <a href=""><i class="fab fa-twitter-square fa-2x"></i></a>
                    <a href=""><i class="fab fa-facebook-square fa-2x"></i></a>
                    <a href=""><i class="fab fa-instagram-square fa-2x"></i></a>
                </div>
                <div>
                    <p>Copyright © 2021. Todos los derechos reservados.</p>
                </div>
            </div>
    </section>
</asp:Content>
